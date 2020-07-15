using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops {
    class Program {
        static void Main(string[] args) {
            //Here we are doing 3 things. 
            //1: Variable i is = to 0. 
            //2: Variable i is less than 100.
            //3: loop until Variable i is or equal to 100.
            for (int i = 1; i <= 100; i++) {
                if (i % 2 == 0) { //Checks if Variable i can be divided into 2 equally in order to increment.
                    Console.Write(i + ", ");//were using Write instead of WriteLine.
                }
                
            }

            Console.ReadKey();
        }
    }
}
