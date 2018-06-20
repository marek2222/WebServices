using System;

namespace EmployeeService
{
  public interface IEmployee
  {
    DateTime DateOfBirth { get; set; }
    string Gender { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    EmployeeType Type { get; set; }
  }
}