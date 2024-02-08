using BusCurs.Model;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.View.CLass
{
    public class MyVIew: Form, IMyVIew
    {

        public MyChart InputControl { set => Controls.Add(value); }
        public MyVIew()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyVIew
            // 
            this.ClientSize = new System.Drawing.Size(722, 538);
            this.Name = "MyVIew";
            this.ResumeLayout(false);

        }
    }
}
