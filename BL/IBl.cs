using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE; 

namespace BL
{
    public interface IBl
    {
        bool CheckOrderDate(DateTime x, DateTime y);
        bool CheckAvailableDate(int key, DateTime x, DateTime y);
        bool CheckCollectionClearance(Host x);
        GuestRequest GetGuestRequest(int key);
        void AddRequest(GuestRequest req);
        void UpdateRequest(GuestRequest req);
        Order GetOrder(int key);
        bool CheckOrder(int key);
        void AddOrder(GuestRequest req);
        void UpdateOrder(int key);
        void confirmOrder(int key);
        void fillOrder(int key, DateTime x, DateTime y);
        void DeleteOrder(Order ord);
        Host GetHost(int key);
        void AddHost(Host host);
        void UpdateHost(Host host);
        void DeleteHost(Host host);
        HostingUnit GetUnit(int key);
        void AddUnit(HostingUnit unit);
        void DeleteUnit(HostingUnit unit);
        List<GuestRequest> getAllRequest();
        List<HostingUnit> getAllUnits();
    }
}
