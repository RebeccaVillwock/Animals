using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class CreatePet
    {
        public Pet pet;

        //ask user what type of pet they want
        public string requestPetType()
        {
            string userInput;

            Console.WriteLine("What type of pet would you like?");
            Console.WriteLine("1) Cat");
            Console.WriteLine("2) Dog");

            userInput = Console.ReadLine();
            
            while(!(userInput == "1" || userInput == "2"))
            {
                Console.WriteLine("That was an invalid option");
                Console.WriteLine("Please try again");

                Console.WriteLine("What type of pet would you like?");
                Console.WriteLine("1) Cat");
                Console.WriteLine("2) Dog");

                userInput = Console.ReadLine();
            }
            return userInput;
        }

        public string setPetName()
        {
            string petName;
            Console.WriteLine("What is your pets name?");
            petName = Console.ReadLine();

            return petName;
        }
        public Boolean setDogFriendlyness()
        {
            Boolean friendly;
            string userInput;

            Console.WriteLine("Is your dog friendly yes or no?");
            userInput = Console.ReadLine();

            while(!(userInput.ToLower() == "yes" || userInput.ToLower() == "no"))
            {
                Console.WriteLine("Input was invalid please try agian");
                Console.WriteLine("Is your dog friendly yes or no?");
                userInput = Console.ReadLine();
            }

            if(userInput.ToLower() == "yes")
            {
                friendly = true;
            }
            else
            {
                friendly = false;
            }

            return friendly;
        }

        public int setMiceKilled()
        {
            string userInput;
            int miceKilled;

            Console.WriteLine("How many mice has your cat killed?");
            userInput = Console.ReadLine();

            miceKilled = Int32.Parse(userInput);

            return miceKilled;
        }

        //create the type of pet they want
        public Pet createPet()
        {
            string userInput;
            string petName;

            userInput = requestPetType();

            petName = setPetName();
           
            //for a cat
            if(userInput == "1")
            {
                int miceKilled = setMiceKilled();
                pet = new Cat(miceKilled, petName);
            }
            //for a dog
            else
            {
                bool friendly = setDogFriendlyness();
                pet = new Dog(friendly, petName);

            }

            return pet;
        }

        public void addToArrayList(ArrayList list)
        {
            list.Add(pet);
        }
    }
}
