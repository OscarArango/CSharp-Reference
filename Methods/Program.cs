using System;

namespace Methods {
    class Program {
        
        // Our Main Method
        static void Main(string[] args) {
            //Our Add method references our new method helper class down below.
            Console.Write("Welcome, What is your name?: ");
            string usrName = Convert.ToString(Console.ReadLine());

            //We collect the age and store it in a variable called answer.
            Console.Write("How Old are you?: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            //We then create another variable and we put the users age plus 8 in it.
            int result = Add(answer, 8);
            Console.WriteLine(result);

            //based on the users age and the plus 8, we determine what statement runs.
            if (result >= 10) {
                Console.WriteLine(usrName + " your result is larger than 10!");
            }
            else {
                Console.WriteLine(usrName + " Result is smaller than 10!");
            }
            Console.ReadKey();
        }

        //this example does not return anything from the method. it simply's runs and writes to the console the sum of 2 numbers
        public static void AddNoReturn(int num01, int num02) {
            Console.WriteLine(num01 + num02);
        }


        // Helper Math methods, these are return types.
        public static int Add(int num01, int num02) {
            return num01 + num02;
        }
        public static int Sub(int num01, int num02) {
            return num01 - num02;
        }
        public static int Mul(int num01, int num02) {
            return num01 * num02;
        }
        public static int Div(int num01, int num02) {
            return num01 / num02;
        }
    }
}
