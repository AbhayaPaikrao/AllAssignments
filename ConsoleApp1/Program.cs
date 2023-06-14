// See https://aka.ms/new-console-template for more information
using ConsoleApp1;


Console.WriteLine("Hello, World!");
var dob = new DateTime(2023, 6, 14);
Person person = new Person("Abhu", "Paikrao", "paikraoabhya@gmail.com", dob);

Console.WriteLine("Hi" + " " + person.First_name + person.Last_name);
if (person.Adult)
{
    Console.WriteLine("you are Adult");
}
else
{
    Console.WriteLine("you are not Adult");
}
Console.WriteLine(person.Adult);
if (person.IsTodayYourBirthDay)
{
    Console.WriteLine("Today is your birthday ,Happy Birthday " + " " + person.First_name);
};
Console.ReadLine();