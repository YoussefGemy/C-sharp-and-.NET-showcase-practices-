﻿///1
// int population = 66_000_000; // 66 million in UK 
// double weight = 1.88; // in kilograms
// decimal price = 4.99M; // in pounds sterling
// string fruit = "Apples"; // strings use double-quotes
// char letter = 'Z'; // chars use single-quotes
// bool happy = true; // Booleans have value of true or false

///2
// var population = 66_000_000; // 66 million in UK 
// var weight = 1.88; // in kilograms
// var price = 4.99M; // in pounds sterling
// var fruit = "Apples"; // strings use double-quotes 
// var letter = 'Z'; // chars use single-quotes
// var happy = true; // Booleans have value of true or false

///3
// using System.IO;
// using System.Xml;
///4
// // good use of var because it avoids the repeated type
// // as shown in the more verbose second statement
// var xml1 = new XmlDocument();
// XmlDocument xml2 = new XmlDocument();
// // bad use of var because we cannot tell the type, so we 
// // should use a specific type declaration as shown in 
// // the second statement
// var file1 = File.CreateText(@"D:\something.txt");
// StreamWriter file2 = File.CreateText(@"D:\something.txt");
///5
// //in C# 9,you can specify the type first and then use new without  repeating the type, as shown in the following code
// XmlDocument xml3 = new(); // target-typed new in C# 9

///default value
///6
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");


