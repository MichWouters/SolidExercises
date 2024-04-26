using SingleResponsability_End.Person;

public class AccountGenerator
{
    public void CreateAccount(Person user)
    {
        Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
    }
}