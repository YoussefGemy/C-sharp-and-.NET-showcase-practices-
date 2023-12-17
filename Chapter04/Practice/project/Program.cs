using System.Net;
using Mmath;
//I'm the main project
//Call CalculatePrimeFactors 'Cause I've test it

var MMath=new MyMath();
for(int i=10;i<=100;i++){
    System.Console.WriteLine($"The primeFactorsOf {i} is {MMath.CalculatePrimeFactors(i)}");
}