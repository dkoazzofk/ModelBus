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
            InitializeComponent();
        }    
        private void InitializeComponent()
        {
            _view.InputControl = new MyChart();
        }

        private void Start(object args,EventHandler e)
        {

        }
    }
}
