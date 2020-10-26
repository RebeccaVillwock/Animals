using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Pet, Talkable
    {
        private int mousesKilled;


        public Cat(int mousesKilled, string name)
        {
            this.name = name;
            this.mousesKilled = mousesKilled;
        }
        public int getMousesKilled() { return mousesKilled; }

        public void addMouse() { mousesKilled++; }

        public string talk() { return "Meow"; }

        public override string ToString() { return "Cat: name = " + name + " mousesKilled = " + mousesKilled; }




        public string getName()
        {
            return name;
        }
    }
}
