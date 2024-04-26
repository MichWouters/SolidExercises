// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my app!");

// Ask for user information
Person user = new Person();

Console.WriteLine("What is your first name?");
user.FirstName = Console.ReadLine();

Console.WriteLine("What is your last name?");
user.LastName = Console.ReadLine();

if (string.IsNullOrWhiteSpace(user.FirstName))
{
    Console.WriteLine("You did not give a valid first name");
    Console.ReadLine();
    return;
}

if (string.IsNullOrWhiteSpace(user.LastName))
{
    Console.WriteLine("You did not give a valid last name");
    Console.ReadLine();
    return;
}

// Create a username for the user
Console.WriteLine($"Your username is : {user.FirstName.Substring(0, 1)}{user.LastName})");
Console.ReadLine();