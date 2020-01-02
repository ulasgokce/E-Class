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
            ObjectPasser.User = null;
            if(txtUserName.Text == "" || txtPassword.Text == "" || cbUserType.Text == "" )
            {
                MessageBox.Show("Alanlar boş geçilemez");
            }
            else
            {

            AddUser.AddOrUpdateUser(txtUserName.Text, txtPassword.Text, cbUserType.Text);
            }
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
