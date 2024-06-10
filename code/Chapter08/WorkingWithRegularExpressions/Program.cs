using System.Text.RegularExpressions; 
using static System.Console;


Write("Enter your age: "); 
string input = ReadLine();
//var ageChecker = new Regex(@"\d");//(mean the input contain at least one digit) 
//var ageChecker = new Regex(@"\d{3}-\d{2}-\d{4}");
//mean the input containt 3 digit and - and 2 digit and - and 4 digit and any other thing 
//var ageChecker = new Regex(@"^\d+$");

//we also can do this by make it in class and just call it
// Regex ageChecker = new(DigitsOnlyText);
// Regex ageChecker = new(DigitsOnlyText, RegexOptions.Compiled);
Regex ageChecker = DigitsOnly();

if (ageChecker.IsMatch(input)){
    WriteLine("Thank you!");
}
else{
    WriteLine($"This is not a valid age: {input}");
}


//string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
//the above way is the dumb way it was used till c# 10 
//by make \ before and "
//now it becomes more easier we just start the string by """ not " and end it with """ not " like below

string films = 
""" 
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
///wow
string[] filmsDumb = films.Split(',');
WriteLine("Dumb attempt at splitting:");
foreach (string film in filmsDumb){
    WriteLine(film);
}

//Regex csv = new("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
// Regex csv = new(CommaSeparatorText);
Regex csv = CommaSeparator();
MatchCollection filmsSmart = csv.Matches(films);
WriteLine("Smart attempt at splitting:");
foreach (Match film in filmsSmart){
    WriteLine(film.Groups[2].Value);
}

//go to line 10;


//Regex onlyNumbers=new();
//Regex Comma=new(CommaSeparatorText);