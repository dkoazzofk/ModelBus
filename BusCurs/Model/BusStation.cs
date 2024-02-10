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
        public Randoms randoms { get; set; } = new Randoms();
        public BusStation()
        {
            countHumans = (int)randoms.Parametre_ravn(20, 40);
        }
        public Bus InputHumanBus(Bus bus)
        {
            bus.InputBus(countHumans);
            return bus;
        }
        
    }
}
