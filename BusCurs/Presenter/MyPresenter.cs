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
        public IMyVIew _view { get; set; }
        public MyChart chart = new MyChart();
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
                Size = new Size(100, 50),
                Text = "Старт",
                Location = new Point(420,360)
            };
            butt.Click += new EventHandler(Start);
            _view.InputControlButton = butt;
            TextBox text = new TextBox 
            { 
                Size = new Size(100, 50),
                Location = new Point(420,20)
            };
            _view.InputControlTextBox = text;
            Label label = new Label
            {
                Text = "Количество остановок",
                Size = new Size(50, 50),
                Location = new Point(420, 10)
            };
        }

        private void Start(object args,EventArgs e)
        {
            chart.Series.Clear();

            IRoadBus[] buses = Route();
            chart.Series.Clear();
            for (int i = 0; i < 10; i++)
            {
                double speed = (double)Randoms.Parametre_ravn(40f,120f) * 16.67f;
                int member = (int)Randoms.Parametre_ravn(20f, 40f);
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
        private IRoadBus[] Route()
        {
            IRoadBus[] roadBuses = new IRoadBus[6];
            for(int i = 0; i < 6; i++)
            {
                if (i % 2 == 0) roadBuses[i] = new Road();
                else roadBuses[i] = new BusStation(CreatePeople(),i);
            }
            return roadBuses;
        }

        private Queue<Human> CreatePeople()
        {
            Random rand = new Random();
            Queue<Human> people = new Queue<Human>();
            for(int i = 0; i < 16; i++)
            {
                people.Enqueue(new Human(rand.Next(1,6)));
            }
            return people;
        }
    }
}
