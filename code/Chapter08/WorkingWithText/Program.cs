using System;
using System.Data;
using static System.Console;

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
//note that length is atribute not function

WriteLine($"First char is {city[0]} and third is {city[2]}.");

///split string 
string cities = "Paris,Berlin,Madrid,New York";
//split(????)  the ???? mean the things i wanna split from it and it's not included in the strings
string[] citiesArray = cities.Split(',');
foreach (string item in citiesArray){
    WriteLine(item);
} 

string fullName = "Alan Jones";
int indexOfTheSpace = fullName.IndexOf(' ');
//IndexOf return the index of string or char

string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace); 
string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);
WriteLine($"{lastName}, {firstName}");

string company = "Microsoft";
bool startsWithM = company.StartsWith("M"); 
bool endWithT = company.EndsWith("T");
//the two functions aren't sensitive for capital or small
bool containsN = company.Contains("N");
WriteLine($"Starts with M: {startsWithM}, end with T: {startsWithM}, contains an N: {containsN}");
//Some of the string methods are static methods
//This means that the method can only be called from the type like the below methodes

/*
Add statements to take an array of string values and combine them back together 
into a single string variable with separators using the Join method
*/
string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

string fruit = "Apples"; 
decimal price = 0.39M;
DateTime when = DateTime.Today;
WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.", fruit, price, when));
string.IsNullOrEmpty(company);
//concate  ==  +  but it's bad use cause it make new string and put the two strings in it
