using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator {
    public class CalculateMath {
        public static Numbers Calculate() {
            
            //Calculate user input passed from MathDataCapture
            Numbers math = MathDataCapture.Capture();

            if (math.ops == "+") {
                math.answer = math.FirstNumber + math.SecondNumber;
                Console.WriteLine(math.answer);
            }
            if (math.ops == "-") {
                math.answer = math.FirstNumber - math.SecondNumber;
                Console.WriteLine(math.answer);
            }
            if (math.ops == "*") {
                math.answer = math.FirstNumber * math.SecondNumber;
                Console.WriteLine(math.answer);
            }
            if (math.ops == "/") {
                math.answer = math.FirstNumber / math.SecondNumber;
                Console.WriteLine(math.answer);
            }

            return math;
        }
    }
}
