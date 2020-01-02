using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EClass
{
    public partial class QuestionAdd : Form
    {
        public QuestionAdd()
        {
            InitializeComponent();
        }

        private void QuestinAdd_Load(object sender, EventArgs e)
        {
            using (ExamEntities db = new ExamEntities())
            {
                foreach (var item in db.Catagories)
                {
                    cbCatagory.Items.Add(item.Name.ToString());
                }

                if (ObjectPasser.Question != null)
                {

                    List<Choice> choices = new List<Choice>();
                    Catagory cat = new Catagory();
                    choices = db.Choices.Where(x => x.QuestionId == ObjectPasser.Question.Id).OrderByDescending(x => x.IsCorrect).ToList();
                    if (choices.Count != 0)
                    {
                        txtChoice1.Text = choices[0].Choice1;
                        txtChoice2.Text = choices[1].Choice1;
                        txtChoice3.Text = choices[2].Choice1;
                        txtChoice4.Text = choices[3].Choice1;
                    }
                    txtQuestion.Text = ObjectPasser.Question.Question1;

                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || cbCatagory.Text == "" || txtChoice1.Text == "" || txtChoice2.Text == "" || txtChoice3.Text == "" || txtChoice4.Text == "")
            {
                MessageBox.Show("Alanlar Boş geçilemez");
            }
            else
            {

                AddQuestion.AddOrUpdateQuestion(txtQuestion.Text, cbCatagory.Text, txtChoice1.Text, txtChoice2.Text, txtChoice3.Text, txtChoice4.Text);
            }
            ObjectPasser.Question = null;
        }



        private void QuestinAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (ObjectPasser.UserLoggedIn.UserType == 1)
            {
                ObjectPasser.Question = null;
                Login lg = new Login();
                lg.Show();

            }
            else
            {
                ObjectPasser.Question = null;
                AdminPanel ap = new AdminPanel();
                ap.Show();

            }
        }


    }
}
