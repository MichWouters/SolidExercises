using SingleResponsability_End;
using SingleResponsability_End.Person;

PersonDataCapture personDataCapture = new PersonDataCapture();
PersonValidator personValidator = new PersonValidator();
AccountGenerator accountGenerator = new AccountGenerator();

StandardMessages.WelcomeMessage();
Person user = personDataCapture.Capture();
bool isUserValid = personValidator.Validate(user);

if (isUserValid == false)
{
    StandardMessages.EndApplication();
    return;
}

accountGenerator.CreateAccount(user);
StandardMessages.EndApplication();