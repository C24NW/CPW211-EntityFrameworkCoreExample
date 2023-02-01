using EntityFrameworkCoreExample;
using Microsoft.EntityFrameworkCore.Metadata;

using StudentContext dbContext = new();

//Add with EF Core
Student s1 = new()
{
    FullName = "Full NameOne",
    EmailAddress = "full1nameone@email.com",
    DateOfBirth = new DateTime(1950, 1, 1),
};

Student s2 = new()
{
    FullName = "Full NameTwo",
    EmailAddress = "fullnametwo@email.com",
    DateOfBirth = new DateTime(1950, 2, 2),
};

dbContext.Students.Add(s1); //Prepares the Student insert statement
dbContext.SaveChanges(); //Executes pending insert.

dbContext.Students.Add(s2); //Prepares the Student insert statement
dbContext.SaveChanges(); //Executes pending insert.

//Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); //Method Syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}
