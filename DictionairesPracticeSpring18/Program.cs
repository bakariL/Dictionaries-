using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionairesPracticeSpring18
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionaries can grow and shirnk 
            //Create Dictionary <data type key, data type int value> 
            //Syntax - Dictionary<key data tpye, value datae tpye> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {  //create another bdoy with key value pairs....use , at the end of the {}
                { "Kerry", 90 }, //"Kerry" is the key, 90 is the value
                {"Berry", 85 },
                {"Michelle", 100 }
              };


            //create another dictionary for vending machine
            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" }
            };

            //create emtpy dictionary drink machine 
            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using the add method, lets add drinks to our drink machine. 
            //This machine uses just the number to vend an item instead of
            // a letter-nummber pair.

            drinkMachine.Add(10, "Ginger Ale"); //grab through the key, its the unique idenitfier 
            drinkMachine.Add(12, "Fruit Punch");
            drinkMachine.Add(14, "Coke");
            drinkMachine.Add(8, "Sprite");
            drinkMachine.Add(6, "Orange");
            drinkMachine.Add(4, "Root Beer");

            Console.WriteLine(drinkMachine.Count);//counts how many items in my drink machine...count is a property not a method, returns the size 

            //We have another property, called .Key 
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key); //prints the keys..so all the numbers 10, 12,14,8,6,4
            }
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value); //prints the values...so ginger ale, fruit punch, coke, sprite, orange, root beer
            }



            //Create a dictionary for a theater coat check with 10 elements. 
            // the key will be the number and value willl be the coat style
            //Print all values to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(1, "Peacoat");
            coatCheck.Add(2, "Winter Coat");
            coatCheck.Add(3, "Windbreaker");
            coatCheck.Add(4, "Vest");
            coatCheck.Add(5, "Pullover");
            coatCheck.Add(6, "Track Jacket");
            coatCheck.Add(7, "Coat");
            coatCheck.Add(8, "Peaccoat");
            coatCheck.Add(9, "Pullover");
            coatCheck.Add(10, "Winter coat");

            foreach (KeyValuePair<int, string> coats in coatCheck)
            {
                Console.WriteLine(coats.Value);
            }

            //create dictionary for a car calet service with 10 cars. 
            //they key be the customers last name and the calue
            //will be the car make. print all keys to the console. 

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Lewis", "S550 Benz" },
                {"Williams", "Ford Tarus"  },
                {"Smith", "Lexus GS300" },
                {"Porter", "Tesla S" },
                {"Johnson", "Ford Explorer" },
                {"Davis", "Hummer" },
                {"Irving", "Bently" },
                {"Adams", "Tahoe" },
                {"James", "Kia" },
                {"Daniels", "Toyota camry" }
            };

            foreach (KeyValuePair<string, string> lastName in carValet)
            {
                Console.WriteLine(lastName.Key);
            }


            //Create a dictonary of 10 zoo animals. The key will be
            //the animal type and the value will be the number of that 
            //animal type at the zoo. Print the animal with the highest
            //quantity to the console. 
            Dictionary<string, int> animal = new Dictionary<string, int>();
            
                animal.Add("Bear", 1);
                animal.Add("Tiger", 2);
                animal.Add("Lion", 2);
                animal.Add("Monkey", 3);
                animal.Add("Parrot", 4);
                animal.Add("Chimpazee", 3);
                animal.Add("Zebra", 5);
                animal.Add("Donkey", 5);
                animal.Add("Horse", 6);
                animal.Add("Cow", 7);

            int highest = 0;
            foreach(KeyValuePair<string,int> animalZoo in animal)
            {
                if (animalZoo.Value > highest)
                {
                    highest = animalZoo.Value;
                }
            }

         foreach(KeyValuePair<string,int> animalZoo in animal)
            {
                if(animalZoo.Value == highest)
                {
                    Console.WriteLine(animalZoo.Key);
                }
            }
        }
    }
}
