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
        public Transport?[] TransportCity = new Transport?[33];

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

        public Plane? GetFromAirport(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    Plane? temp = (Plane)TransportCity[i];
                    TransportCity[i] = null;
                    temp.Vzlet();
                    CountPlane--;
                    return temp;
                }
            }
            throw new Exception("нет такого самолета");

        }

        public Bus? GetFromBusStation(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    Bus? temp = (Bus)TransportCity[i];
                    TransportCity[i] = null;
                    temp.Otehal();
                    CountBus--;
                    return temp;
                }
            }
            throw new Exception("нет такого автобуса");
        }

        public Ship? GetFromPort(string nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i].NameOfTransport == nameOfTransport)
                {
                    Ship? temp = (Ship)TransportCity[i];
                    TransportCity[i] = null;
                    temp.Otpliv();
                    CountShip--;
                    return temp;
                }
            }
            throw new Exception(" нет такой лодки");
        }
        public void Print()
        {
            foreach (var item in TransportCity)
            {
                Console.WriteLine(item);
            }
        }
    }
}
