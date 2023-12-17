using System;

namespace Packt.Shared{
    public delegate int DelegateWithMatchingSignature(string s);
    public partial class Person{
        public static Person Procreate(Person p1, Person p2){ 
            var baby = new Person { 
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby); 
            p2.Children.Add(baby);
            return baby; 
        }
        // instance method to "multiply" 
        public Person ProcreateWith(Person partner){
           return Procreate(this, partner);
        }

        // operator to "multiply"

        public static Person operator *(Person p1, Person p2){
            return Person.Procreate(p1, p2);
        }

        // method with a local function 
        public static int Factorial(int number) { 
            if (number < 0) { 
                throw new ArgumentException( 
                $"{nameof(number)} cannot be less than zero."); 
            }
            return localFactorial(number);
            int localFactorial(int localNumber){ // local function
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }
        public int MethodIWantToCall(string input){
            return input.Length; // it doesn't matter what this does
        }


    }
}