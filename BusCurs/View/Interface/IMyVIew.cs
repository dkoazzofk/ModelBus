﻿using BusCurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.View.Interface
{
    public interface IMyVIew
    {
        MyChart InputControlChart { set; }
        Button InputControlButton { set; }
    }
}
