namespace SingleResponsability_End.Person
{
    public class PersonDataCapture
    {
        public Person Capture()
        {
            // Ask for user information
            Person person = new Person();

            person.FirstName = CaptureValue("first name");
            person.LastName = CaptureValue("last name");

            return person;
        }

        private string CaptureValue(string value)
        {
            Console.Write($"What is your {value}?: ");
            return Console.ReadLine();
        }
    }
}