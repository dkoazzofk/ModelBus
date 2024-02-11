using BusCurs.Model;
using BusCurs.Model.Interface;
using BusCurs.View.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusCurs.Presenter
{
    public class MyPresenter
    {
        IMyVIew _view { get; set; }
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
            chart.Series.Clear();
            IRoadBus[] buses = Route();
            for (int i = 1; i < 10; i++)
            {
                float speed = Randoms.Parametre_ravn(40,120) * 16.67f;
                int member = (int)Randoms.Parametre_ravn(40, 120);
                Bus bus = new Bus(speed, member);

                for(int  j = 0; j < buses.Length; j++) 
                    bus = buses[j].InputBus(bus);
                for (int j = buses.Length-1; j >= 0; j--)
                    bus = buses[j].InputBus(bus);

                chart.Series.Add($"{i}");
                chart.Series[$"{i}"].ChartType = SeriesChartType.Column;
                chart.Series[$"{i}"].Points.AddXY(i, bus._time);
            }
        }
        public IRoadBus[] Route()
        {
            IRoadBus[] roadBuses = new IRoadBus[7];
            for(int i = 0; i < 7; i++)
            {
                if (i % 2 == 0) roadBuses[i] = new Road();
                else roadBuses[i] = new BusStation();
            }
            return roadBuses;
        }
    }
}
