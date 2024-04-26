using OpenClosed_End.Accounts;
    
namespace OpenClosed_End.Applicants
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new Accounts.Accounts();
    }
}