using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EClass
{
    class GetIn
    {
        public static int GetInside(string username, string password)
        {
            int usertype = 2;
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
                    MessageBox.Show("Geçersiz şifre");
                }
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
            }

            return usertype;
        }
    }
}
