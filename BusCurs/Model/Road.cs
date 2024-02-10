using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Model
{
    public class Road
    {
        public Queue<Bus> queue { get; set; } = new Queue<Bus>();
        public float length { get; set; } = Randoms.Parametre_ravn(20,40)*1000;
        public void BusInput(Bus bus)
        {
            Random random = new Random();
            int chance = random.Next(1, 11);
            if(chance <= 2)  bus._time += Randoms.Parametre_ravn(20,60);
            bus._time += length / bus._speed;

            queue.Enqueue(bus);
        }
        public Bus BusOutput() { return queue.Dequeue(); }
        //Шансы поломки автобуса
    }
}
