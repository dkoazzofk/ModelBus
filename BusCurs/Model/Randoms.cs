using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public static class Randoms
    {
        //NormalDistribution r = new NormalDistribution();
        //public Random r_ = new Random();
        public static float Parametre_exp(float min, float max)//экспоненциальное распределение
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            float result = ((float)(-Math.Log(r_.NextDouble())) / 2.0f);
            return (float)(min + result * (max - min));
        }

        public static float Parametre_ravn(float min, float max)//равномерное распределение
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            return (float)(min + r_.NextDouble() * (max - min));
        }

        public static int Razbros_na_floors(int Procent, int Number_of_humans) // генерация количества людей на этажах
        {
            NormalDistribution r = new NormalDistribution();
            Random r_ = new Random();
            return (int)(r.NextDouble() * Procent * 2 - Procent) + Number_of_humans;
        }
    }
}
