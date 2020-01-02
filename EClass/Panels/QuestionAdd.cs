using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
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
            using (ExamEntities db = new ExamEntities())
            {
                Random rnd = new Random();
                Question question = new Question();

                List<Choice> choices = new List<Choice>();
                Choice choice1 = new Choice();
                Choice choice2 = new Choice();
                Choice choice3 = new Choice();
                Choice choice4 = new Choice();

                question.Question1 = txtQuestion.Text.ToString();
                question.CatId = db.Catagories.Where(x => x.Name == cbCatagory.Text.ToString()).FirstOrDefault().Id;
                db.Questions.Add(question);

                choice1.Choice1 = txtChoice1.Text.ToString();
                choice1.IsCorrect = true;
                choices.Add(choice1);

                choice2.Choice1 = txtChoice2.Text.ToString();
                choices.Add(choice2);

                choice3.Choice1 = txtChoice3.Text.ToString();
                choices.Add(choice3);

                choice4.Choice1 = txtChoice4.Text.ToString();
                choices.Add(choice4);


                var result = choices.Select(x => new { value = x, order = rnd.Next() })
                            .OrderBy(x => x.order).Select(x => x.value).ToList();
                foreach (var item in result)
                {
                    item.QuestionId = question.Id;
                    db.Choices.AddOrUpdate(item);
                }
                db.SaveChanges();
                ObjectPasser.Question = null;
                MessageBox.Show("Soru kaydedildi");

            }
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
