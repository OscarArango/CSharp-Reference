using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops {
    class Program {
        static void Main(string[] args) {
            //Auto rolling dice simulator.

            Random numberGen = new Random();//Using Random() we can generate numbers and put them into a variable.  

            int numberOfAttempts = 0;//Starts off at zero, our while loop will increment it as the loop runs.
            int attempt = 0;

            while (attempt != 6) {//While loop will continue to run the code in brackets until the condition is met.  Do While loops will run at least once.
                //Here we are putting Random() to work by using the variable with .Next(1, 7) 
                //and putting parameters into the semicolons. we did 1 through 7 because 7 isn't counted or used, it will be 0-6.
                attempt = numberGen.Next(1, 7);
                Console.WriteLine("Tom rolled: " + attempt + ".");
                numberOfAttempts++;//Here is our variable again, this is the one that gets incremented after each loop.
            }

            Console.WriteLine("It took Tom " + numberOfAttempts + " attempts to roll a six");
            Console.ReadKey();
        }
    }
}
