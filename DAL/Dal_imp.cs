using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace IBl
{
    public class Dal_imp : Idal
    {
        public string msg;
        static Dal_imp instance = null;
        public static Dal_imp GetInstance()
        {
            if (instance == null)
                instance = new Dal_imp();
            return instance;
        }
        //funs for request
        public GuestRequest GetGuestRequest(int key)
        {
            GuestRequest req = DataSource.listOfRequests.FirstOrDefault(_req => _req.GuestRequestKey == key);
            return req?.Clone();
        }

        public void AddRequest(int key)
        {
            GuestRequest req = DataSource.listOfRequests.FirstOrDefault(_req => _req.GuestRequestKey == key);
            if (req != null)
                throw new MissingException("request already exist", key);
            DataSource.listOfRequests.Add(req.Clone());
        }

        public void UpdateRequest(GuestRequest req)
        {
            int count = DataSource.listOfRequests.RemoveAll(_req => _req.GuestRequestKey == req.GuestRequestKey);
            if (count == 0)
                throw new MissingException("Request is not exist", req.GuestRequestKey);
            AddRequest(req.GuestRequestKey);
        }

        //funs for order
        public Order GetOrder(int key)
        {
            Order order = DataSource.listOfOrders.FirstOrDefault( _order =>_order.OrderKey == key);
            return order?.Clone();
        }

        public bool CheckOrder(int key)
        {
            return DataSource.listOfOrders.Any(ord => ord.OrderKey == key);
        }

        public void AddOrder(GuestRequest req)
        {
            if (!CheckOrder(req.GuestRequestKey))
                throw new MissingException("the order already exist", req.GuestRequestKey);
            DataSource.listOfRequests.Add(req.Clone());
        }

        public void DeleteOrder(Order ord)
        {
            int counter=DataSource.listOfOrders.RemoveAll(it => it.OrderKey == ord.OrderKey);
            if (counter == 0)
                throw new KeyNotFoundException("הזמנה לא קיימת");
        }

        //פונ' עבור מארח

        public Host GetHost(int key)
        {
            Host host = DataSource.listOfHosts.FirstOrDefault(_host => _host.HostKey == key);
            return host == null ? null : host.Clone();
        }

        public bool CheckHost(int key)
        {
            return DataSource.listOfHosts.Any(_host => _host.HostKey == key);
        }

        public void AddHost(Host host)
        {
            if (!CheckOrder(host.HostKey))
                throw new MissingException("the host already exist", host.HostKey);
            DataSource.listOfHosts.Add(host.Clone());
        }

        public void UpdateHost(Host host)
        {
            int count = DataSource.listOfHosts.RemoveAll(_host => _host.HostKey == host.HostKey);
            if (count == 0)
                throw new MissingException("Host is not exist", host.HostKey);
            AddHost(host);
        }

        public void DeleteHost(Host host)
        {
            Host host2 = DataSource.listOfHosts.FirstOrDefault(_host => _host.HostKey == host.HostKey);
            if (host2 == null)
                throw new MissingException("host has not found", host2.HostKey);
            else
                DataSource.listOfHosts.RemoveAll(host3 => host3.HostKey == host.HostKey);
        }

         //פונ' עבור יחידת אירוח

        public HostingUnit GetUnit(int key)
        {
            HostingUnit unit = DataSource.listOfUnits.FirstOrDefault(_unit => _unit.UnitKey == key);
            return unit == null ? null : unit.Clone();
        }

        public bool CheckUnits(int key)
        {
            return DataSource.listOfUnits.Any(_units => _units.UnitKey == key);
        }

        public void AddUnit(HostingUnit unit)
        {
            if (!CheckUnits(unit.UnitKey))
                throw new MissingException("the hosting unit already exist", unit.UnitKey);
            unit.UnitKey = configuration.HostingUnitKey;
            configuration.HostingUnitKey++;
            DataSource.listOfUnits.Add(unit.Clone());
        }

        public void UpdateUnit(HostingUnit unit)
        {
            int count = DataSource.listOfUnits.RemoveAll(_unit => _unit.UnitKey == unit.UnitKey);
            if (count == 0)
                throw new MissingException("Unit is not exist", unit.UnitKey);
            AddUnit(unit);
        }

        public void DeleteUnit(HostingUnit unit)
        {
            HostingUnit hosting = DataSource.listOfUnits.FirstOrDefault(_unit => _unit.UnitKey == unit.UnitKey);
            if (hosting == null)
                throw new MissingException("Unit has an open order", unit.UnitKey);
            else
                    DataSource.listOfUnits.RemoveAll(unit2 => unit2.UnitKey == hosting.UnitKey); 
        }

        public List<GuestRequest> getAllRequests()
        {
            List<GuestRequest> newList = new List<GuestRequest>();
            foreach(var req in DataSource.listOfRequests)
            {
                newList.Add(req.Clone());
            }
            return newList;
        }

        public List<HostingUnit> getAllUnits()
        {
            List<HostingUnit> newList = new List<HostingUnit>();
            foreach(var unit in DataSource.listOfUnits)
            {
                newList.Add(unit.Clone());
            }
            return newList;
        }
}
}
