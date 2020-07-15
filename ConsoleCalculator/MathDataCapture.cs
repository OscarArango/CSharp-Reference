using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator {
    public class MathDataCapture {
        public static Numbers Capture() {
            
            // Ask for user input
            Numbers input = new Numbers();

            StandardMessages.userFirstNumber();
            input.FirstNumber = Double.Parse(Console.ReadLine());

            StandardMessages.userOperator();
            input.ops = Console.ReadLine();

            StandardMessages.userSecondNumber();
            input.SecondNumber = Double.Parse(Console.ReadLine());

            return input;
        }
    }
}
