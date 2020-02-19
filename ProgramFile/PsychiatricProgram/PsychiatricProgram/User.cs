using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsychiatricProgram
{
    class User
    {
        string name, past_1, past_2;
        int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void setUserpast(string past1, string past2)
        {
            this.past_1 = past1;
            this.past_2 = past2;
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
