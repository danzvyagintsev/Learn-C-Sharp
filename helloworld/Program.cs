// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "Maria";
string secondFriend = "Scott";
string thirdFriend = "   John";
string fourthFriend = "    Brian   ";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}."); //String Interpolation

Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend + "."); //String Concatenation

Console.WriteLine($"{thirdFriend.TrimStart()} and {fourthFriend.Trim()} are not my friends."); //Trim() Method
