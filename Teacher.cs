using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Teacher: Person, Talkable
    {
        private int age { get; set; }

        public Teacher(int age, string name)
        {
            this.name = name;
            this.age = age;

        }
        public string talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
