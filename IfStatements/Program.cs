using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("How old are you?"); //Ask the user their age

            int age = Convert.ToInt32(Console.ReadLine()); //Take the user response and put it into a variable checking that it's a integer and not a string.

            if(age < 18) { //this checks if the age is less then 18.
                Console.WriteLine("That's too bad! You will have to wait a couple of years.");
            } else if(age == 18) { //This checks if the age is equal to.
                Console.WriteLine("Puh, barely made it!");
            } else { //And this is for all other conditions.
                Console.WriteLine("You are allowed to enter.");
            }
        }
    }
}
