using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace EClass
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            using (ExamEntities db = new ExamEntities())
            {
                dgwQuestions.DataSource = (from em in db.Questions
                                                        select new { em.Id, em.Question1,em.CatId }).ToList(); 
                dgwUsers.DataSource = (from em in db.Users
                                      select new { em.Id, em.Username, em.UserType }).ToList(); 
            }
           
        }


        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAdd ua = new UserAdd();
            ua.Show();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            using (ExamEntities db = new ExamEntities())
            {
                if (dgwUsers.SelectedCells.Count > 0)
                {
                    User user = new User();
                    int selectedrowindex = dgwUsers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwUsers.Rows[selectedrowindex];
                    int id  = Convert.ToInt32( Convert.ToString(selectedRow.Cells["Id"].Value));
                    user = db.Users.Where(x => x.Id == id).FirstOrDefault();

                    db.Users.Remove(user);
                    db.SaveChanges();
                    dgwUsers.DataSource = (from em in db.Users
                                           select new { em.Id, em.Username, em.UserType }).ToList();
                }
            }
        }
        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
           
            using (ExamEntities db = new ExamEntities())
            {
                if (dgwUsers.SelectedCells.Count > 0)
                {
                    this.Hide();
                    User user = new User();
                    int selectedrowindex = dgwUsers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwUsers.Rows[selectedrowindex];
                    int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                    user = db.Users.Where(x => x.Id == id).FirstOrDefault();
                    ObjectPasser.User = user;
                    UserAdd ua = new UserAdd();
                    ua.Show();


                }
            }
        }


        #region Qustion CRUD
        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionAdd aq = new QuestionAdd();
            aq.Show();
        }

        private void btnQuestionUpdate_Click(object sender, EventArgs e)
        {
           
            using (ExamEntities db = new ExamEntities())
            {
                if (dgwQuestions.SelectedCells.Count > 0)
                {
                    this.Hide();
                    Question question = new Question();
                    int selectedrowindex = dgwQuestions.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwQuestions.Rows[selectedrowindex];
                    int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                    question = db.Questions.Where(x => x.Id == id).FirstOrDefault();
                    ObjectPasser.Question = question;
                    QuestionAdd qa = new QuestionAdd();
                    qa.Show();

                  
                }
            }

        }

        private void btnQuestionDelete_Click(object sender, EventArgs e)
        {
            using (ExamEntities db = new ExamEntities())
            {
                if (dgwQuestions.SelectedCells.Count > 0)
                {
                    Question question = new Question();
                    int selectedrowindex = dgwQuestions.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgwQuestions.Rows[selectedrowindex];
                    int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                    question = db.Questions.Where(x => x.Id == id).FirstOrDefault();

                    db.Questions.Remove(question);
                    db.SaveChanges();
                    dgwQuestions.DataSource = (from em in db.Questions
                                               select new { em.Id, em.Question1, em.CatId }).ToList();
                    MessageBox.Show("Soru başarıyla silindi");
                }
            }
        }
        #endregion

      
    }
}
