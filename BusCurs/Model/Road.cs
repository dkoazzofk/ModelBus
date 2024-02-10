using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Road
    {
        public  Queue<Bus> queue { get; set; } = new Queue<Bus>();
        public void BusInput(Bus bus)
        {

            queue.Enqueue(bus);
        }
        public Bus BusOutput() { return queue.Dequeue(); }
        //Шансы поломки автобуса
    }
}
