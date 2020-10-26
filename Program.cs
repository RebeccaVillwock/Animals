using System;
using System.Collections;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            //lines to be printed out
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            //user input class
            CreatePet cp = new CreatePet();
            cp.createPet();

            cp.addToArrayList(zoo);
            
            //print list to screen
            foreach(Talkable thing in zoo)
            {
                Console.WriteLine(thing.ToString());
            }

        }
    }
}
