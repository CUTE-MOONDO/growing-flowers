using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsychiatricProgram
{
    public class User
    {
        string name, past_1, past_2;
        int age;
        string[] anser1, anser2, anser3;
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

        public void setUserAnser1(string[] anser1)
        {
            for(int i =0; i<10; i++)
            {
                this.anser1[i] = anser1[i];
            }
        }

        public void setUserAnser2(string[] anser2)
        {
            for (int i = 0; i < 10; i++)
            {
                this.anser2[i] = anser2[i];
            }
        }

        public void setUserAnser3(string[] anser3)
        {
            for (int i = 0; i < 10; i++)
            {
                this.anser3[i] = anser3[i];
            }
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
