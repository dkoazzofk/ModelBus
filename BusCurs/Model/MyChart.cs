using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusCurs.Model
{
    public class MyChart : Chart
    {
        public MyChart() 
        {
            Location = new System.Drawing.Point(10, 10);
            Size = new System.Drawing.Size(600,600);
            Series.Add("Dima");
            Series["Dima"].ChartType = SeriesChartType.Column;
            Series["Dima"].Points.AddXY("Category1", 10);
            ChartAreas.Add("ChartArea1");
            ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }
    }
}
