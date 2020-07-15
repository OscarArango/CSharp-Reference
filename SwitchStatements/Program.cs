using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements {
    class Program {
        static void Main(string[] args) {
        Start:
            //Random() generates numbers for us.  We can create a new instance of it by using the new keyword.  it's gets placed into the variable created for it.
            Random numberGenerator = new Random();

            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(1, 11);

            Console.WriteLine("What is " + num01 + " times " + num02 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 * num02) {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex) {
                    case 1:
                        Console.WriteLine("Good shit!");
                        break;
                    case 2:
                        Console.WriteLine("Hell yea, that's how you do it!");
                        break;
                    default:
                        Console.WriteLine("They can't fuck with you!");
                        break;
                }
            }
            else {
                //Were getting the absolute value from answer - num01 * num02.  It's used to determine how close we are to the correct answer and based on that provide feedback.
                int diff = Math.Abs(answer - (num01 * num02));

                if (diff == 1) {
                    Console.WriteLine("So Close!");
                }
                else if (diff <= 10) {
                    Console.WriteLine("You can do better than that.");
                }
                else {
                    Console.WriteLine("You are not even close.");
                }
            }

            Console.ReadKey();
            goto Start;
        }
    }
}
