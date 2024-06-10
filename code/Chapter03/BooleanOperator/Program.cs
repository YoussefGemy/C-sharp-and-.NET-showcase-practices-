using System;
using static System.Console;

namespace boolean{
    class program{
        static void Main(string[] args){

            bool a = true;
            bool b = false;
            #region Logical operators
                // WriteLine($"AND | a | b ");
                // WriteLine($"a | {a & a,-5} | {a & b,-5} ");
                // WriteLine($"b | {b & a,-5} | {b & b,-5} ");
                // WriteLine();
                // WriteLine($"OR | a | b ");
                // WriteLine($"a | {a | a,-5} | {a | b,-5} ");
                // WriteLine($"b | {b | a,-5} | {b | b,-5} ");
                // WriteLine();
                // WriteLine($"XOR | a | b ");
                // WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
                // WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
            #endregion

            #region Conditional logical operators
            /*
                Conditional logical operators are similar to logical operators, but you use two symbols instead 
                of one,for example, && instead of &, or || instead of |.
            */    
            /// short-circuiting Boolean operators.
                WriteLine($"a & DoStuff() = {a & DoStuff()}");
                WriteLine($"b & DoStuff() = {b & DoStuff()}");
                System.Console.WriteLine();
                WriteLine($"a && DoStuff() = {a && DoStuff()}");
                WriteLine($"b && DoStuff() = {b && DoStuff()}");
            #endregion
        }
        private static bool DoStuff(){
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}