using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace EClass
{
    public static class GetIn
    {
        public static int GetInside(string username, string password)
        {
            int usertype = -1;
            ExamEntities db = new ExamEntities();


            var user = db.Users.Where(x => x.Username == username).FirstOrDefault();
            if (user != null)
            {
                if (user.Password == password)
                {
                    ObjectPasser.UserLoggedIn = user;
                    usertype = user.UserType;
                }
                else
                {
                    System.Windows.MessageBox.Show("Geçersiz şifre");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
            }

            return usertype;
        }
    }
}
