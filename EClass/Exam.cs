using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EClass
{
    public partial class Exam : Form
    {
        const int time = 60;
        private int timeLeft = -1;
        int nextClick = 0;

        public Exam()
        {
            InitializeComponent();

        }

        private void Exam_Load(object sender, EventArgs e)
        {
            List<Question> lastQuestions = new List<Question>(); ;
            var rnd = new Random();
            List<Question> questions = new List<Question>();
            MessageBox.Show("Sınav süresi 60 dakika başarılar");
            timer1.Start();
            ExamEntities db = new ExamEntities();
            List<Choice> choices = new List<Choice>();
            var questionsAnsweredByMe = db.Answers.Where(x => x.UserId == ObjectPasser.UserLoggedIn.Id).Select(y => y.QuestionId).ToList();
            var _availableQuestions = db.Questions.Where(x => !questionsAnsweredByMe.Contains(x.Id)).ToList();
            if (db.VW_UserFalseCountByCategory.Where(x => x.UserId == ObjectPasser.UserLoggedIn.Id).OrderByDescending(y => y.FalseCount).Take(1).FirstOrDefault()!=null)
            {
            int catId = db.VW_UserFalseCountByCategory.Where(x => x.UserId == ObjectPasser.UserLoggedIn.Id).OrderByDescending(y => y.FalseCount).Take(1).FirstOrDefault().CategoryId;
                List<Question> secondhalf = _availableQuestions.Where(x => x.CatId == catId).Take(4).ToList();
                var Firsthalf = _availableQuestions.Where(x => x.CatId != catId).Take(8 - (secondhalf.Count)).ToList();
                 lastQuestions = Firsthalf.Concat(secondhalf).ToList();
            }
            lastQuestions = _availableQuestions;


            lastQuestions= lastQuestions.OrderBy(item => rnd.Next()).ToList();

            lblQuestion.Text = lastQuestions[0].Question1;
            rbAns1.Text = lastQuestions[0].Choices.ElementAt(0).Choice1;
            rbAns2.Text = lastQuestions[0].Choices.ElementAt(1).Choice1;
            rbAns3.Text = lastQuestions[0].Choices.ElementAt(2).Choice1;
            rbAns4.Text = lastQuestions[0].Choices.ElementAt(3).Choice1;
            ObjectPasser.QuestionList = lastQuestions;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft == -1)
            {
                timeLeft = time * 60;
            }

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimer.Text = (timeLeft / 60) + ":" + (timeLeft % 60);
            }
            else
            {
                timer1.Stop();
                lblTimer.Text = "Time's up!";
                MessageBox.Show("Üzgünüm, Zamanında bitiremedin");
                btnNextQuestion.Enabled = false;
            }

            Thread.Sleep(1000);
        }

        private void Exam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StudentPanel sp = new StudentPanel();
            sp.Show();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            
            ExamEntities db = new ExamEntities();
           
            Answer answer = new Answer();
            answer.QuestionId = ObjectPasser.QuestionList[nextClick].Id;
            answer.UserId = ObjectPasser.UserLoggedIn.Id;
            Choice choice = new Choice();
            if (rbAns1.Checked)
            {
                answer.ChoiceId = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(0).Id;
            }
            else if (rbAns2.Checked)
            {
                answer.ChoiceId = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(1).Id;
            }
            else if (rbAns3.Checked)
            {
                answer.ChoiceId = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(2).Id;
            }
            else if (rbAns4.Checked)
            {
                answer.ChoiceId = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(3).Id;
            }

            db.Answers.Add(answer);
            db.SaveChanges();
            nextClick++;
            if (nextClick == 7)
            {
                MessageBox.Show("Testi bitirdiniz Tebrikler");
                this.Close();
                StudentPanel i = new StudentPanel();
                i.Show();
                ObjectPasser.QuestionList = null;
            }else if (ObjectPasser.QuestionList.Count > nextClick)
            {
                lblQuestion.Text = ObjectPasser.QuestionList[nextClick].Question1;
                rbAns1.Text = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(0).Choice1;
                rbAns2.Text = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(1).Choice1;
                rbAns3.Text = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(2).Choice1;
                rbAns4.Text = ObjectPasser.QuestionList[nextClick].Choices.ElementAt(3).Choice1;
               
            }
            

        }
    }
}
