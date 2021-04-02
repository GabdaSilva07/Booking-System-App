using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Form_UI
{
    class UserModel
    {
        private static string email { get; set; }

        private string firstName { get; set; }

        private string surname { get; set; }

        private int age { get; set; }

        private string password { get; set; }

        private bool isAdmin { get; set; }

        public UserModel()
        { }

        public UserModel(string email, string firstName, string surname, int age, string password, bool isAdmin)
        {
            Email = email;
            Firstname = firstName;
            Surname = surname;
            Age = age;
            Password = password;
            Admin = isAdmin;
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Admin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

    }
}
