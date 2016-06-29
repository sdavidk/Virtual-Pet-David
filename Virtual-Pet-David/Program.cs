using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {


        static void Main(string[] args)
        {
            //Welcome message
            //establish pet name
            // prompt main menu


            VirtualPet name = new PetName();


            Console.WriteLine("Welcome to VirtualPet!");

            Console.WriteLine("Enter a name for your pet");

            while (true)

            {
                Console.WriteLine("Main Menu \n \n");
                Console.WriteLine("1. feed pet \n");
                Console.WriteLine("2. Water pet \n");
                Console.WriteLine("3. Play with pet \n");
                Console.WriteLine("4. Take pet to the Vet \n");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    name.FeedingPet();
                }
                else if (choice == 2)
                {
                    name.WaterPet();

                }
                else if (choice == 3)
                {
                    name.PlayWithPet();
                }
                else if (choice == 4)
                {
                    name.TakePetToTheVet();
                }
                else
                {
                    Console.WriteLine(" Choose a number between 1-4");
                }

            }


        }



    }
}
