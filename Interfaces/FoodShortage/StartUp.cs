using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            List<Rebel> rebels = new List<Rebel>();
            List<Citizen> citizens = new List<Citizen>();
            int foodSum = 0;
            int numPeople = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < numPeople; i++)
            {
                
                string personInfo = Console.ReadLine();
                string[] dataLoad = personInfo
                    .Split()
                    .ToArray();
                if (dataLoad.Length == 4)
                {
                    Citizen citizen = new Citizen(dataLoad[0], int.Parse(dataLoad[1]), dataLoad[2], dataLoad[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(dataLoad[0], int.Parse(dataLoad[1]), dataLoad[2]);
                    rebels.Add(rebel);
                }                          
            }

            string command;
            do
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                foreach (Rebel rebel in rebels)
                {
                    if (rebel.Name == command)
                    {
                        rebel.BuyFood();
                        break;
                    }
                }

                foreach (Citizen citizen in citizens)
                {
                    if (citizen.Name == command)
                    {
                        citizen.BuyFood();
                        break;
                    }
                }
            } while (command != "End");

            foreach (Rebel rebel in rebels)
            {
                foodSum += rebel.Food;
            }
            foreach (Citizen cit in citizens)
            {
                foodSum += cit.Food;
            }

            Console.WriteLine(foodSum);
        }
    }
}
