﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public  class Source
    {
        public Queue<Bus> sources { get; set; } = new Queue<Bus>();
        public int time { get; set; } = 0;

        public Source() 
        {
            sources.Enqueue(new Bus(Randoms.Parametre_ravn(30, 60),Randoms.Parametre_ravn(10, 40)));
        }
        public float Calculate_X(Bus bus)
        {
            return bus._member;
        }
        public float Calculate_Y(Bus bus)
        {
            return bus._speed;
        }
    }
}
