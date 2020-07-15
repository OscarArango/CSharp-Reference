using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator {
    public class StandardMessages {
        public static void welcomeMessage() {
            Console.WriteLine("Welcome to My first Console Project done completely from scratch.");
        }

        public static void userFirstNumber() {
            Console.Write("Number 1: ");
        }

        public static void userOperator() {
            Console.WriteLine("Select the operator (+, -, *, /)");
        }

        public static void userSecondNumber() {
            Console.Write("Number 2: ");
        }

        public static void EndApplication() {
            Console.ReadLine();
        }
    }
}
