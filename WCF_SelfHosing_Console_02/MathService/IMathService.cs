using System.ServiceModel;

namespace MathService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract]
  public interface IMathService
  {
    [OperationContract]
    int Addition(int num1, int num2);
  }
}
