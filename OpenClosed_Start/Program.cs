﻿using OpenClosed_Start.Models;

var applicants = new List<PersonModel>
   {
       new PersonModel { FirstName = "Tim", LastName = "Corey" },
       new PersonModel { FirstName = "Sue", LastName = "Storm" },
       new PersonModel { FirstName = "Nancy", LastName = "Roman" }
   };

List<EmployeeModel> employees = new List<EmployeeModel>();
AccountsFactory accountProcessor = new AccountsFactory();

foreach (var person in applicants)
{
    employees.Add(accountProcessor.Create(person));
}

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}

Console.ReadLine();