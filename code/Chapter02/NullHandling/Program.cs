// //int thisCannotBeNull = null;//compile error!

// int? thisCouldBeNull = null;
// Console.WriteLine(thisCouldBeNull);
// Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

// thisCouldBeNull = 7;
// Console.WriteLine(thisCouldBeNull);
// Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

// ///As we've seen in the code before this lines, to make variable nullable we must add ? after it's datatype except for strings
// //The first line is blank because it is outputting the null value!

// /*
// the most significant change to the language in C# 8.0 was the introduction of nullable and non-nullable reference types. 
// "But wait!", you are probably thinking, "Reference types are already nullable!"
// And you would be right, but in C# 8.0 and later, reference types can be configured to no longer 
// allow the null value by setting a file- or project-level option to enable this useful new feature. 
// Since this is a big change for C#, Microsoft decided to make the feature opt-in.
// #nullable disable
// #nullable enable
// */


/// <summary>
/// in this program we'll see a nullable reference type 
/// as we see the string that i didn't declare it as nullable show wrongs as it couldn't be declared without value
/// </summary>
// #nullable enable
// using System.Globalization;
// namespace prg{
//     class Address{
//         public string? Building;
//         public string Street;
//         public string City; 
//         public string Region;
//     }
//     class programm{
//         static void Main(String[] args){
//             var add=new Address();
//             add.Building = null;
//             add.Street   = null;
//             add.City     = "London";
//             add.Region   = null;

//         }
//     }
// }

string authorName = null;

//int x = authorName.Length;// the following throws a NullReferenceException

int? y = authorName?.Length;// instead of throwing an exception, null is assigned to y
//if the variable that i'll do op on it could be null i should write ? after the name of it like authorName(?).Length
//to avoid null exciption


/// if i wanna do like make condition or something else
/// like i the answer is null print (number)
/// Ex
var result = authorName?.Length ?? 3; 
Console.WriteLine(result);