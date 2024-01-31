// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "Maria";
string secondFriend = "Scott";
string thirdFriend = "   John";
string fourthFriend = "    Brian   ";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine("My friend is " + firstFriend + " and " + secondFriend + ".");

Console.WriteLine($"{thirdFriend.TrimStart()} and {fourthFriend.Trim()} are not my friends.");
