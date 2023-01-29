using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPHomeTask.Test
{
    public class TransportSystemCity
    {
        private int CountPlane = 0;
        private int CountBus = 11;
        private int CountShip = 22;
        public Transport?[] TransportCity;
        public TransportSystemCity()
        {
            TransportCity = new Transport?[33];
        }

        public void SetInAirport(string name, string nameOftranspor)
        {
            if (CountPlane == 10)
            {
                throw new Exception("нет места");

            }
            Plane plane = new Plane(name, nameOftranspor);
            TransportCity[CountPlane++] = plane;
            plane.Posadka();

        }
        public void SetInBusStation(string name, string nameOftranspor)
        {
            if (CountBus == 21)
            {
                throw new Exception("нет места");

            }
            Bus bus = new Bus(name, nameOftranspor);
            TransportCity[CountBus++] = bus;
            bus.Priehal();

        }
        public void SetInPort(string name, string nameOftranspor)
        {
            if (CountShip == 32)
            {
                throw new Exception("нет места");

            }
            Ship lodka = new Ship(name, nameOftranspor);
            TransportCity[CountShip++] = lodka;
            lodka.Pripliv();
        }

        public void GetFromAirport(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    TransportCity[i] = null;
                    CountPlane--;
                }
            }
            throw new Exception("нет такого самолета");

        }

        public void GetFromBusStation(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    TransportCity[i] = null;
                    CountBus--;
                }
            }
            throw new Exception("нет такого автобуса");
        }

        public void GetFromPort(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    TransportCity[i] = null;
                    CountShip--;
                }
            }
            throw new Exception("нет такой лодки");
        }
    }
}
