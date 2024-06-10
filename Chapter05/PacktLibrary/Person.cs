using System;
using System.Collections.Generic;

namespace Packt.Shared{
    public partial class Person{
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList; 
        public List<Person> Children=new List<Person>();
        public const string Species = "Homo Sapien";
        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        // constructors
        public Person(){
            // set default values for fields
            // including read-only fields 
            Name = "Unknown"; 
            Instantiated = DateTime.Now;
        }
        public string SayHello(){
            return $"{Name} says 'Hello!'";
        }
        public string SayHello(string name){
            return $"{Name} says 'Hello {name}!'";
        }
        public string OptionalParameters(
        string command = "Run!", 
        double number = 0.0, 
        bool active = true)
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command, arg1: number, arg2: active);
        }
        public void PassingParameters(int x, ref int y, out int z){
            // out parameters cannot have a default
            // AND must be initialized inside the method 
            z = 99;
            // increment each parameter 
            x++;
            y++;
            z++;
        }
        public void WriteToConsole(){
            System.Console.WriteLine($"{Name} was born on a {this.DateOfBirth}");
        }
    }
}