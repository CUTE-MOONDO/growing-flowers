using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsychiatricProgram
{
    class User
    {
        string name;
        int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string getUserName()
        {
            return name;
        }

        public int getUserAge()
        {
            return age;
        }
    }
}
