using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class VirtualPet
    {
        //private instance variables (pet attributes)

        private string petName;
        public string PetName { get; set; }

        private int hungerLevel;
        public int HungerLevel
        {
            get
            {
                return hungerLevel;
            }
            set
            {
                hungerLevel = value;
            }
        }

        private int thirstLevel;
        public int ThirstLevel
        {
            get
            {
                return thirstLevel;
            }
            set
            {
                thirstLevel = value;
            }
        }

        private int boredomLevel;
        public int BoredomLevel
        {
            get
            {
                return boredomLevel;
            }
            set
            {
                boredomLevel = value;
            }
        }

        private int sickLevel;
        public int SickLevel
        {
            get
            {
                return sickLevel;
            }
            set
            {
                sickLevel = value;
            }
        }




        //Constructor

        public VirtualPet(string Name)
        {
            this.PetName = Name;
            HungerLevel = 5;
            ThirstLevel = 5;
            BoredomLevel = 5;
            SickLevel = 5;
        }







        //Methods

        public void FeedingPet()
        {
            Console.WriteLine("{0} 's Hunger Level is {1} ", PetName, HungerLevel);
            Console.WriteLine("How much do you want to feed {0} ? \n Pick a level between 1 and 10", PetName);
            HungerLevel -= HungerLevel = Convert.ToInt32(Console.ReadLine());
            ThirstLevel += 5;

        }

        public void SetName(string Name)
        {
            this.PetName = Name;
        }
        public string GetName()
        {
            return PetName;
        }

        public void WaterPet()
        {
            Console.WriteLine("{0} 's thirst level is {1} ", PetName, ThirstLevel);
            Console.WriteLine("How much do you want to water {0} ? \n Pick a level between 1 and 10", PetName);
            ThirstLevel -= Convert.ToInt32(Console.ReadLine());
            if (ThirstLevel > 10)
            {
                Console.WriteLine("You killed {0}", PetName);
            }
            else if (ThirstLevel > 5)
            {
                BoredomLevel = 8;
            }

        }

        public void PlayWithPet()
        {
            Console.WriteLine("{0} 's boredom level is {1}. How many minutes do you want to play with your pet? Enter a number between 1-10", PetName, BoredomLevel);
            BoredomLevel -= Convert.ToInt32(Console.ReadLine());
            SickLevel += 5;
        }
        public void TakePetToTheVet()
        {
            SickLevel -= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0} is now healthy", PetName);
            SickLevel = 5;
        }
    }

}






