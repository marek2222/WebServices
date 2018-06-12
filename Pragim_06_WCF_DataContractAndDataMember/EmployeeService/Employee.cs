using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EmployeeService
{
  //[DataContract(Namespace = "http://pragimtech.com/Employee")]
  [DataContract]
  //[Serializable]
  public class Employee
  {
    //[DataMember]
    //[DataMember(Name="ID", Order = 1)]
    [DataMember(Order = 1)]
    public int Id { get; set; }

    [DataMember(Order = 2)]
    public string Name { get; set; }

    [DataMember(Order = 3)]
    public string Gender { get; set; }

    [DataMember(Order = 4)]
    public DateTime DateOfBirth { get; set; }
    
  }
}
