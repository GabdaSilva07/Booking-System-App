using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach_Form_UI.Models
{
    class User
    {

        public string email { get; set; }

        public string firstName { get; set; }

        public string  surname { get; set; }

        public int age { get; set; }

        public string password { get; set; }

        public User()
        {
        }

        public User(string email, string firstName, string surname, int age, string password)
        {
            this.email = email;
            this.firstName = firstName;
            this.surname = surname;
            this.age = age;
            this.password = password;
        }
    }
}
