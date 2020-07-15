using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables {
    class Program {
        static void Main(string[] args) {
            int num01; //Our variable using the integer declaration.  There are many types of declarations so be sure to use the proper one for the scenario.
            int num02;

            Console.Write("Type a number to be multiplied: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is " + num01 * num02);
        }
    }
}
