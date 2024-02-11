using BusCurs.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BusCurs.Model
{
    public class BusStation : IRoadBus
    {
        public int countHumans { get; set; }
        public Queue<Human> humans { get; set; }
        public Bus bus { get; set; }
        public BusStation()
        {
            Random rand = new Random();
            //countHumans = (int)Randoms.Parametre_ravn(20, 40);
            countHumans = rand.Next(50,60);
            humans = new Queue<Human>(countHumans);
        }
        public Bus InputBus(Bus bus)
        {
            humans = bus.InputBus(humans);
            return bus;
        }

        private void FullQue()
        {
            for (int i = 0; i < countHumans;i++)
            {
                Human human = new Human();
                humans.Enqueue(humans.Dequeue());
            }
        }
        
    }
}
