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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            if(rbRememberMe.Checked == true)
            {
                //TODO : Last Login will save to somewhere and will be pulled next start
            }
        }
        #region PasswordHiding
        bool isChecked = false;
        private void rbShowHide_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbShowHide.Checked;
            if (rbShowHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void rbShowHide_Click(object sender, EventArgs e)
        {
            if (rbShowHide.Checked && !isChecked)
                rbShowHide.Checked = false;
            else
            {
                rbShowHide.Checked = true;
                isChecked = false;
            }
        }
             #endregion

        private void Login_Click(object sender, EventArgs e)
        {
            using(ExamEntities db = new ExamEntities())
            {
                var user = db.Users.Where(x => x.Username == txtUserName.Text).FirstOrDefault();
                if (user!=null)
                {
                    if (user.Password == txtPassword.Text)
                    {
                        ObjectPasser.UserLoggedIn = user;
                        if(user.UserType == 0)
                        {
                            //TODO: Admin Login
                            this.Hide();
                            AdminPanel ap = new AdminPanel();
                            ap.Show();
                            
                        }
                        else if(user.UserType == 1)
                        {
                            //TODO: Teacher Login
                            this.Hide();
                            QuestionAdd qa = new QuestionAdd();
                            qa.Show();
                        }
                        else
                        {
                            //TODO: Student Login
                            this.Hide();
                            StudentPanel sp = new StudentPanel();
                            sp.Show();

                        }
                    }
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

     
    }
}
