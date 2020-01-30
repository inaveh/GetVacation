using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace IBl
{
    public interface Idal
    {
        GuestRequest GetGuestRequest(int key);
        void AddRequest(int key);
        void UpdateRequest(GuestRequest req);

        Order GetOrder(int key);
        bool CheckOrder(int key);
        void AddOrder(GuestRequest req);
        void DeleteOrder(Order ord);

        Host GetHost(int key);
        bool CheckHost(int key);
        void AddHost(Host host);
        void UpdateHost(Host host);
        void DeleteHost(Host host);


        HostingUnit GetUnit(int key);
        void AddUnit(HostingUnit unit);
        void UpdateUnit(HostingUnit unit);
        void DeleteUnit(HostingUnit unit);

        List<GuestRequest> getAllRequests();
        List<HostingUnit> getAllUnits();
    }

}
