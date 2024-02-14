using BusCurs.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Model
{
    public class Road : IRoadBus
    {
        public float length { get; set; } = Randoms.Parametre_ravn(1,5)*1000;
        public Bus InputBus(Bus bus)
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if(chance >= 0 || chance < 0.1)  bus._time += Randoms.Parametre_ravn(10,30);
            bus._time += length / bus._speed;
            return bus;
        }
    }
}
