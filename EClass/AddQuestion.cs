using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace EClass
{
    public static class AddQuestion
    {
        public static bool AddOrUpdateQuestion(string questiontext, string cata, string trueAns, string ans2, string ans3, string ans4)
        {
            ExamEntities db = new ExamEntities();

            Random rnd = new Random();
            Question question = new Question();

            List<Choice> choices = new List<Choice>();
            Choice choice1 = new Choice();
            Choice choice2 = new Choice();
            Choice choice3 = new Choice();
            Choice choice4 = new Choice();

            question.Question1 = questiontext;
            question.CatId = db.Catagories.Where(x => x.Name == cata).FirstOrDefault().Id;
            db.Questions.Add(question);

            choice1.Choice1 = trueAns;
            choice1.IsCorrect = true;
            choices.Add(choice1);

            choice2.Choice1 = ans2;
            choices.Add(choice2);

            choice3.Choice1 = ans3;
            choices.Add(choice3);

            choice4.Choice1 =ans4;
            choices.Add(choice4);

            choices = choices.OrderBy(item => rnd.Next()).ToList();
            foreach (var item in choices)
            {
                item.QuestionId = question.Id;
                db.Choices.AddOrUpdate(item);
            }
           int i= db.SaveChanges();

            System.Windows.MessageBox.Show("Soru kaydedildi");

            return Convert.ToBoolean(i);

        }
    }
}
