using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusCurs.Model
{
    public  class Source
    {
        public Queue<Bus> sources { get; set; } = new Queue<Bus>();
    }
}
