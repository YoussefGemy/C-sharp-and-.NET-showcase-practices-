using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Packt.Shared{
    public static class StringExtensions{ 
        public static bool IsValidEmail(this string input) { 
            // use simple regular expression to check 
            // that the input string is a valid email 
            return Regex.IsMatch(input,@"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+"); 
        }
    }

    
    public partial class Person:IComparable<Person>{
        #region Properties
        ///read-only preoperties
        // a property defined using C# 1 - 5 syntax
        public string Origin { 
            get{
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using C# 6+ lambda expression syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age =>  System.DateTime.Today.Year - DateOfBirth.Year;


        ///read and write
        public string FavoriteIceCream { get; set; }
        
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor { 
            get{
                return favoritePrimaryColor;
            }
            set{
                switch(value.ToLower()){
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor=value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. " + 
                            "Choose from: red, green, blue."
                        );
                }
            }
        }

        ///Indxer
        public Person this[int index] {
            get{
                return Children[index];
            }
            set{
                Children[index] = value;
            }
        }
        #endregion
        #region Delegates, Events and Interfaces
        // public delegate void EventHandler(object sender, EventArgs e);
        // public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);    
        // event delegate field
        public event EventHandler Shout;
        // data field 
        public int AngerLevel; 
        // method 
        public void Poke() { 
            AngerLevel++; 
            if (AngerLevel >= 3){ 
                // if something is listening... 
                //[1]
                // if (Shout != null){ 
                //     // ...then call the delegate
                //     Shout(this, EventArgs.Empty); 
                // }
                //[2]
                Shout?.Invoke(this, EventArgs.Empty);

            }
        }

        public int CompareTo(Person other){
            return Name.CompareTo(other.Name);
        }
        #endregion

        public override string ToString(){
            return $"{Name} is a {base.ToString()}";
        }
        public void TimeTravel(DateTime when) { 
            if (when <= DateOfBirth) { 
                throw new PersonException(
                    "If you travel back in time to a date earlier than your own birth, then the universe will explode!"
                ); 
            } 
            else{ 
                WriteLine($"Welcome to {when:yyyy}!"); 
            } 
        }
    }

    public class PersonComparer : IComparer<Person>{
        public int Compare(Person x, Person y){
            // Compare the Name lengths...
            int result = x.Name.CompareTo(y.Name);
            // ...if they are equal... 
            if (result == 0){
                // ...then compare by the Names...
                return x.Name.CompareTo(y.Name); 
            }
            else{
                // ...otherwise compare by the lengths.
                return result; 
            }
        }
    }
    public class Employee:Person{
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }
        public new void WriteToConsole(){ 
            WriteLine(
                format:"{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HireDate
            );
        }
        public override string ToString() { 
            return $"{Name}'s code is {EmployeeCode}"; 
        }
    }
    //we can prevent anyone from inherting from class by add sealed to the class defination 
    public sealed class ScroogeMcDuck{
    
    }

    public class Singer{
        // virtual allows this method to be overridden
        public virtual void Sing(){
            WriteLine("Singing...");
        }
    }
    public class LadyGaga : Singer{
        // sealed prevents overriding the method in subclasses
        public sealed override void Sing(){
            WriteLine("Singing with style...");
        }
    }
    public class PersonException : Exception{ 
        public PersonException() : base() { } 
        public PersonException(string message) : base(message) { }
        public PersonException(
        string message, Exception innerException)
        : base(message, innerException) { } 
    }
}