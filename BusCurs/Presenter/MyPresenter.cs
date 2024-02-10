﻿using BusCurs.Model;
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
            Source source = new Source();
            Road road = new Road();
            BusStation busStation = new BusStation();

            for (int i = 1; i < 5; i++)
            {
                float speed = Randoms.Parametre_ravn(40,120) * 16.67f;
                int member = (int)Randoms.Parametre_ravn(20, 40);
                Bus bus_start = new Bus(speed,member);
                source.sources.Enqueue(bus_start);

                road.BusInput(source.sources.Dequeue());
                Bus bus_end = busStation.InputHumanBus(road.BusOutput());


                chart.Series.Add($"{i}");
                chart.Series[$"{i}"].ChartType = SeriesChartType.Column;
                chart.Series[$"{i}"].Points.AddXY(i, bus_end._time);
            }
        }
    }
}
