using OpenClosed_End.Accounts;

namespace OpenClosed_End.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount AccountProcessor { get; set; }
    }
}