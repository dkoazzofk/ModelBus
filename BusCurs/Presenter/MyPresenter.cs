using BusCurs.Model;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs.Presenter
{
    public class MyPresenter
    {
        IMyVIew _view { get; set; }
        Random random = new Random();
        MyChart chart = new MyChart();
        public MyPresenter(IMyVIew view) 
        {
            _view = view;
            InitializeComponent();
        }    
        private void InitializeComponent()
        {
            _view.InputControlChart = chart;
            Button butt = new Button
            {
                Size = new Size(100, 100),
                Text = "Старт",
                Location = new Point(420,10)
            };
            butt.Click += new EventHandler(Start);
            _view.InputControlButton = butt;

        }

        private void Start(object args,EventArgs e)
        {
            chart.Series["Bus"].Points.Clear();

            Source source = new Source();
            Road road = new Road();
            BusStation busStation = new BusStation(); 

            road.BusInput(source.sources.Dequeue());
            Bus bus = busStation.InputHumanBus(road.BusOutput());
            chart.Series["Bus"].Points.AddXY(source.Calculate_X(bus), source.Calculate_Y(bus));
        }
    }
}
