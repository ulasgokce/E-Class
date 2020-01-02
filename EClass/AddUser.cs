using System;
using System.Data.Entity.Migrations;
using System.Windows;
using System.Windows.Forms;

namespace EClass
{
    public static class AddUser
    {
        public static bool AddOrUpdateUser(string username, string password, string usertype)
        {
            ExamEntities db = new ExamEntities();

            User user = new User();
            user.Username = username;
            user.Password = password;
            if (usertype == "Ogrenci")
            {
                user.UserType = 2;
            }
            else
            {
                user.UserType = 1;
            }
            db.Users.AddOrUpdate(user);
           int i= db.SaveChanges();
            System.Windows.MessageBox.Show("Kullanıcı kaydedildi");

            return Convert.ToBoolean(i);
        }

    }
}
