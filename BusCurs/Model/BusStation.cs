using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class BusStation
    {
        public int countHumans { get; set; }
        public Bus bus { get; set; }
        public BusStation()
        {
            Random rand = new Random();
            //countHumans = (int)Randoms.Parametre_ravn(20, 40);
            countHumans = rand.Next(50,60);
        }
        public Bus InputHumanBus(Bus bus)
        {
            countHumans = bus.InputBus(countHumans);
            return bus;
        }
        
    }
}
