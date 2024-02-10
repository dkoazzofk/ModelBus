using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public class Bus
    {
        public int number { get; set; }
        public float _member { get; set; }

        public float _speed {  get; set; }

        public Bus(float speed, float member) 
        {
            _speed = speed;
            _member = member;
        }

        public void InputBus(int human) => _member += human;

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
