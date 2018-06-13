using System.ServiceModel;
namespace HelloService
{
    [ServiceContract(Namespace = "http://PragimTech.com/ServiceVersion1"
      , Name = "IHelloService")]
    public interface IHelloServiceChange
    {
        [OperationContract]
        string GetMessage(string name);
    }
}