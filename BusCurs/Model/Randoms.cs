using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Randoms
    {
        NormalDistribution r = new NormalDistribution();
        public Random r_ = new Random();
        public float Parametre(float min, float max)
        {
            float result = (float)(r.NextDouble());
            return (float)(min + Math.Abs(result) * (max - min)); // очень сложный алгоритм
        }

        public float Parametre_exp(float min, float max)//экспоненциальное распределение
        {
            float result = ((float)(-Math.Log(r_.NextDouble())) / 2.0f);
            return (float)(min + result * (max - min));
        }

        public float Parametre_ravn(float min, float max)//равномерное распределение
        {
            return (float)(min + r_.NextDouble() * (max - min));
        }

        public int Razbros_na_floors(int Procent, int Number_of_humans) // генерация количества людей на этажах
        {
            return (int)(r.NextDouble() * Procent * 2 - Procent) + Number_of_humans;
        }
    }
}
