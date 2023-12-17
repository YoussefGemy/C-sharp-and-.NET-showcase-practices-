using System.Collections.Generic;
using static System.Console;
using System.Threading;
using System;

namespace Packt.Shared{
    public interface IPlayable{
        void Play();
        void Pause();
        //What if we want to add another method after create at least one class that implement the interface?
        //it was imposible untill c#
        //.NET 5 ,.NET Core 3.0 and .NET Standard 2.1 and later versions
        //now we can add methods with default implemntaion like this:

        void Stop(){ // default interface implementation
            WriteLine("Default implementation of Stop.");
        }

    }
    public class DvdPlayer : IPlayable{
        public void Pause(){
            WriteLine("DVD player is pausing.");
        }
        public void Play(){
            WriteLine("DVD player is playing.");
        }
    }

    public static class Squarer{
        public static double Square<T>(T input)where T : IConvertible{
            // convert using the current culture
            double d = input.ToDouble(
            Thread.CurrentThread.CurrentCulture);
            return d * d;
        }
    }
    /*
        I'm trying to make flexible app here so I want to make a class that take an input 
        after that give it parametr to check if it equall to the stored value
    */
    //  if I made it using object it won't work cause it will compare ref not value
    public class Thing{
        public object Data = default(object);
        public string Process(object input){
            if (Data == input){
                return "Data and input are the same.";
            }
            else{
                return "Data and input are NOT the same.";
            }
        }
    }
    //but it will work here cause i use generic
    public class GenericThing<T> where T : IComparable{
        public T Data = default(T);
        public string Process(T input){
            if (Data.CompareTo(input) == 0){
                return "Data and input are the same.";
            }
            else{
                return "Data and input are NOT the same.";
            }
        }
    }
}