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
        public float length { get; set; } = Randoms.Parametre_ravn(5,20)*1000;
        public Bus InputBus(Bus bus)
        {
            Random random = new Random();
            int chance = random.Next(1, 11);
            if(chance <= 1)  bus._time += Randoms.Parametre_ravn(20,60);
            bus._time += length / bus._speed;

            return bus;
        }


    }
}
