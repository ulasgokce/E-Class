using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace EClass
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
            if (ObjectPasser.User != null)
            {
                txtUserName.Text = ObjectPasser.User.Username;
                txtPassword.Text = ObjectPasser.User.Password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ExamEntities db = new ExamEntities())
            {
                User user = new User();
                user.Username = txtUserName.Text.ToString();
                user.Password = txtPassword.Text.ToString();
                if (cbUserType.Text == "Ogrenci")
                {
                    user.UserType = 2;
                }
                else
                {
                    user.UserType = 1;
                }
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
            }
            ObjectPasser.User = null;
            MessageBox.Show("Kullanıcı kaydedildi");
        }

        private void UserAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ObjectPasser.User = null;
            ap.Show();

        }

    }
}
