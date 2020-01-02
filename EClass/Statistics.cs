using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EClass
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            ExamEntities db = new ExamEntities();

            var seriesArray = db.VW_UserFalseCountByCategory.Where(x => x.UserId == ObjectPasser.UserLoggedIn.Id).Select(x => x.Category).ToList();
            var pointsArray = db.VW_UserFalseCountByCategory.Where(x => x.UserId == ObjectPasser.UserLoggedIn.Id).Select(x => x.FalseCount).ToList();

            Series series = this.testChart.Series.Add("İstatistik");
            series.ChartType = SeriesChartType.Pie;
        

            for (int i = 0; i < seriesArray.Count; i++)
            {
                 series.Points.AddXY(seriesArray[i], Convert.ToInt32(pointsArray[i]));
            }
           
        }

      

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StudentPanel i = new StudentPanel();
            i.Show();
        }

    }
}
