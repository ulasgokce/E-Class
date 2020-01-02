using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EClass
{
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
            lblUserName.Text = "Merhabalar " + ObjectPasser.UserLoggedIn.Username.ToUpper(); ;
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam i = new Exam();
            i.Show();
        }

        private void StudentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnPrevExamReview_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics i = new Statistics();
            i.Show();
        }
    }
}
