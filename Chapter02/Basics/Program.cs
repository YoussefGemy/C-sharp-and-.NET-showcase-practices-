// #error version
using System;
namespace basics{
    class programm{
        static void Main(string[] args){
                double heightInMeter=1.88;
                System.Console.WriteLine($"the variable {nameof(heightInMeter)} has a value {heightInMeter}.");


                //if i wanna print path for anything, sure the path contain\ so if i wanna take the \ 
                //i can write \\ or i can put @ before the string like that vv
                System.Console.WriteLine("C:\\televisions\\sony\\bravia.txt");
                System.Console.WriteLine(@"C:\televisions\sony\bravia.txt");//called verbatim strings
        }
    }
}