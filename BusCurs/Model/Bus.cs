using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Bus
    {
        public int _member { get; set; }

        public float _speed {  get; set; }
        public float _time {  get; set; } = 0 ;

        public Bus(float speed, int member) 
        {
            _speed = speed;
            _member = member;
        }

        public int InputBus(int human)
        { 

            if (_member != 0)
            {
                int[] tmp = Calculate(_member, human);
                _member = tmp[0];                  
                _time += Randoms.Parametre_ravn(1,5)*(human - tmp[1]);
                return tmp[1];
            }
            else return human;
        }

        public int[] Calculate(int memberHuman, int human)
        {
            int[] tmp = [memberHuman,human];
            for (int i = 0; tmp[0] > 0 || tmp[1] > 0 ; i++)
            {
                if (tmp[0] == 0 || tmp[1] == 0) break;
                tmp[0] -= 1;
                tmp[1] -= 1;
            }
            return tmp;
        }

        public static float Parametre_exp(float min, float max)//экспоненциальное распределение
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            float result = ((float)(-Math.Log(r_.NextDouble())) / 2.0f);
            return (float)(min + result * (max - min));
        }
    }
}
