using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Form_UI
{
    class UserModel
    {
        private string firstName;
        private string surname;
        private string email;
        private int age;
        private string password;


        public UserModel()
        {
        }

        public UserModel(string firstName, string surname, string email, int age, string password)
        {
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Age = age;
            Password = password;
        }

        public string FirstName 
        { get { return firstName; } 
          set { firstName = value; } 
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age= value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
