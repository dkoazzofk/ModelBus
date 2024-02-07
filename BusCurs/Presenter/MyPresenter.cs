using BusCurs.Model;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Presenter
{
    public class MyPresenter
    {
        IMyVIew _view { get; set; }
        public MyPresenter(IMyVIew view) 
        {
            _view = view;
        }    
        private void InitializeComponent()
        {
            Button butt = new Button();
            butt.Text = "dima";
            butt.Size = new System.Drawing.Size(200, 200);
            _view.InputControl = butt;
            //_view.InputControl = new MyChart();
        }
    }
}
