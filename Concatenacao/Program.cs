string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstNames = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstNames + "!");

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

int version1 = 11;
string updateText1 = "Update to Windows";
Console.WriteLine($"{updateText1} {version1}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");