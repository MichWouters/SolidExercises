using OpenClosed_End.Applicants;

namespace OpenClosed_End.Accounts
{
    public interface IAccount
    {
        EmployeeModel Create(IApplicantModel person);
    }
}