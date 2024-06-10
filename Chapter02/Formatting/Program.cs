using static System.Console;
//if we use using static System.Console; by this way we can use writeline without system.console.

#region outPutFormat
// int numberOfApple = 12;
// decimal pricePerApple = 0.35M;

// WriteLine(
//     format:"{0} apples costs {1:C}",
//     arg0:numberOfApple,
//     arg1:pricePerApple*numberOfApple
// );

// string formatted = string.Format(
//     format: "{0} apples costs {1:C}",
//     arg0: numberOfApple,
//     arg1: pricePerApple * numberOfApple
// );

// System.Console.WriteLine(formatted);
// System.Console.WriteLine($"{numberOfApple} apples costs {pricePerApple *numberOfApple:N0}");


// string applesText = "Apples";
// int applesCount = 1234;
// string bananasText = "Bananas";
// int bananasCount = 56789;

// //{0,-8} means print arg0 in the first 8 character and the fill the reminder of 8 char with ' '
// //{0,8} it like the above but means make the text to the right like fill the reminder with ' ' the print the string

// //{1,7:N0} we've known N0 before so skip it.
// //then it's {1,7} look at it, it's look exactly like the above lines so skip it to.
// Console.WriteLine(
//     format: "{0,-8} {1,7:N0}",
//     arg0: "Name",
//     arg1: "Count"
// );
// Console.WriteLine(
//     format: "{0,-8} {1,7:N0}",
//     arg0: applesText,
//      arg1: applesCount
// );
// Console.WriteLine(
//     format: "{0,-8} {1,7:N0}",
//     arg0: bananasText,
//     arg1: bananasCount
//  );    
#endregion

#region Getting text input from the user

///<summary>
/// foramat like 
/// C
/// N0
/// are important 
/// C for price sign like $
/// N0 for numbers and put ',' to make it readable and doesn't print any decimal numbers
/// actually the number after the character who prevent the numbers after the decimal point 
/// like if i write N1 it'll print 1 number after decimal point and so on.
///</summary>

// Console.Write("Type your first name and press ENTER: "); 
// string firstName = Console.ReadLine();

// Console.Write("Type your age and press ENTER: ");
// string age = Console.ReadLine();

// Console.WriteLine($"Hello {firstName}, you look good for {age}.");

///how to read only one key from the user 

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine(
    "Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers
);




#endregion



