using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using BE;
using IBl;

namespace BL
{
    
    public class Bl_imp : IBl  
    {
        static Bl_imp instance = null;

        public static Bl_imp GetInstance()
        {
            if (instance == null)
                instance = new Bl_imp();
            return instance;
        }

        Dal_imp dl = new Dal_imp();

        public Bl_imp()
        {
            var dl = new Dal_imp();
        }

        //בדיקת תקינות תאריכים
        public bool CheckOrderDate(DateTime x, DateTime y)
        {
            return (x < y);
        }

        //בדיקת זמינות צימר
        public bool CheckAvailableDate(int key, DateTime x, DateTime y)
        {
            HostingUnit unit = GetUnit(key);
            int day = x.Day + 1; // start checking from the second day because the first day can be used by two people
            int time = (((y.Month - 1) * 31) + (y.Day)) - (((x.Month - 1) * 31) + (x.Day));
            int numMonth = (day + time) / 31; // number of monthes 
            int extra = (day + time) % 31; // number of extra days in the last month
            for (int i = x.Month; i <= (x.Month + numMonth); i++)
            {
                for (int j = day; (j < 31) || ((i == x.Month + numMonth) && (j < extra)); j++)
                {
                    if (unit.Diary[i, j] != false)
                        return false;
                }
                day = 0;
            }
            return true;
        }

        //בדיקת הרשאת עמלה
        public bool CheckCollectionClearance(Host x)
        {
            return (x.CollectionClearance);
        }
        
        //פונקציות בקשה
        public GuestRequest GetGuestRequest(int key)
        {
            return dl.GetGuestRequest(key);
        }

        public void AddRequest(GuestRequest req)
        {
            bool check1=CheckAvailableDate(req.GuestRequestKey, req.EntryDate, req.ReleaseDate);
            bool check2 = CheckOrderDate(req.EntryDate, req.ReleaseDate);
            if (check1 && check2)
                dl.AddRequest(req.GuestRequestKey);
            else throw new MissingException("worng dates");
        }

        public void UpdateRequest(GuestRequest req)
        {
            bool check = CheckOrderDate(req.EntryDate, req.ReleaseDate);
            CheckAvailableDate(req.GuestRequestKey, req.EntryDate, req.ReleaseDate);
        }

        //פונקציות הזמנה
        public Order GetOrder(int key)
        {
            return dl.GetOrder(key);
        }

        public bool CheckOrder(int key)
        {
            return dl.CheckOrder(key);
        }

        public void AddOrder(GuestRequest req)
        {
            bool check1=CheckOrderDate(req.EntryDate,req.ReleaseDate);
            bool check2 = CheckAvailableDate(req.GuestRequestKey, req.EntryDate, req.ReleaseDate);
            if (check1 && check2)
                dl.AddOrder(req);
            else
            {
                throw new MissingException("date aren't good");
            }
        }

        public void UpdateOrder(int key)
        {
            Order ord = GetOrder(key);
            GuestRequest req = GetGuestRequest(ord.GuestRequestKey);
            if (ord.OrderStatus == ORDER_STATUS.MailSent)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(GetGuestRequest(ord.GuestRequestKey).MailAddress);
                mail.From = new MailAddress("123INM@gmail.com");
                mail.Subject = "הצעה לחופשה";
                mail.Body = ord.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("123INM@gmail.com", "myGmailPassword");
                smtp.EnableSsl = true;
                try
                {
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            if (ord.OrderStatus != ORDER_STATUS.ClosedWithoutResponed || ord.OrderStatus != ORDER_STATUS.ClosedWithResponed)
                dl.UpdateRequest(req);                
            else
                throw new MissingException("the order is closed");
        }

        public void confirmOrder(int key)
        {
            Order ord = GetOrder(key);
            GuestRequest req = GetGuestRequest(ord.GuestRequestKey);
            ord.fee = ((((req.ReleaseDate.Month - 1) * 31) + (req.ReleaseDate.Day)) - (((req.EntryDate.Month - 1) * 31) + (req.EntryDate.Day))) * BE.configuration.Fee;
            fillOrder(ord.HostingUnitKey, req.EntryDate, req.ReleaseDate);
            req.Status = true;
        }

        public void fillOrder (int key, DateTime x, DateTime y)
        {
            HostingUnit unit = GetUnit(key);
            int day = x.Day + 1; // start checking from the second day because the first day can be used by two people
            int time = (((y.Month - 1) * 31) + (y.Day)) - (((x.Month - 1) * 31) + (x.Day));
            int numMonth = (day + time) / 31; // number of monthes 
            int extra = (day + time) % 31; // number of extra days in the last month
            for (int i = x.Month; i <= (x.Month + numMonth); i++)
            {
                for (int j = day; (j < 31) || ((i == x.Month + numMonth) && (j < extra)); j++)
                {
                    unit.Diary[i, j] = false;
                }
                day = 0;
            }
        }


        public void DeleteOrder(Order ord)
        {
            dl.DeleteOrder(ord);
        }

        //פונ מארח
        public Host GetHost(int key)
        {
            return dl.GetHost(key); 
        }

        public void AddHost(Host host)
        {
            dl.AddHost(host);
        }

        public void UpdateHost(Host host)
        {
            dl.UpdateHost(host);
        }

        public void DeleteHost(Host host)
        {
            dl.DeleteHost(host);
        }

        //פונ יחידות אירוח
        public HostingUnit GetUnit(int key)
        {
            return dl.GetUnit(key);
        }

        public void AddUnit(HostingUnit unit)
        {
            dl.AddUnit(unit);
        }

        //void UpdateUnit(HostingUnit unit)

        public void DeleteUnit(HostingUnit unit)
        {
            dl.DeleteUnit(unit);
        }

        public List<GuestRequest> getAllRequest()
        {
            return dl.getAllRequests();
        }

        public List<HostingUnit> getAllUnits()
        {
            return dl.getAllUnits();
        }
    }
}