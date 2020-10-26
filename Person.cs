using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Person
    {
        public string name { get; set; }

        public Person()
        {
            name = "";
        }
        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
