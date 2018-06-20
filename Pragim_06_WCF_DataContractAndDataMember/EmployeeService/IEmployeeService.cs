﻿using System.ServiceModel;

namespace EmployeeService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
  [ServiceContract]
  public interface IEmployeeService
  {
    //[ServiceKnownType(typeof(FullTimeEmployee))]
    //[ServiceKnownType(typeof(PartTimeEmployee))]
    [OperationContract]
    Employee GetEmployee(int Id);

    [OperationContract]
    void SaveEmployee(Employee employee);
  }
}
