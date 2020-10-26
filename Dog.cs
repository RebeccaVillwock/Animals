using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Pet, Talkable
    {
        private Boolean friendly;

        public Dog(Boolean friendly, String name)
        {
            this.name = name;
            this.friendly = friendly;
        }

        public Boolean isFriendly() { return friendly; }

        public string talk()
        {
            return "Bark";
        }

        public override string ToString() { return "Dog: name = " + name + " friendly = " + friendly; }

        public string getName()
        {
            return name;
        }

        
    }
}
