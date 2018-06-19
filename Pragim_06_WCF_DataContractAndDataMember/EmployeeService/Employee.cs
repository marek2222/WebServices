using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EmployeeService
{
  //[Serializable]
  //[DataContract]
  
  [KnownType(typeof(FullTimeEmployee))]
  [KnownType(typeof(PartTimeEmployee))]
  [DataContract(Namespace = "http://pragimtech.com/Employee")]
  public class Employee
  {

    [DataMember(Order = 1)]
    public int Id               { get; set; }

    [DataMember(Order = 2)]
    public string Name          { get; set; }

    [DataMember(Order = 3)]
    public string Gender        { get; set; }

    [DataMember(Order = 4)]
    public DateTime DateOfBirth { get; set; }

    [DataMember(Order = 5)]
    public EmployeeType Type    { get; set; }

    //public int AnnualSalary     { get; set; }
    //public int HourlyPay        { get; set; }
    //public int HoursWorked      { get; set; }
  }

  public enum EmployeeType
  {
    FullTimeEmployee = 1,
    PartTimeEmployee = 2
  }
}
