using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Pet
    {
        public string name{ get; set; }
        
        public Pet()
        {
            string name = "";
        }
        public Pet(string name)
        {
            this.name = name;
        }
    }
}
