﻿using OpenClosed_End.Applicants;

namespace OpenClosed_End.Accounts
{
    public class ManagerAccounts : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";

            output.IsManager = true;

            return output;
        }
    }
}