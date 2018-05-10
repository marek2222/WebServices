using System.ServiceModel;
namespace HelloService
{
    [ServiceContract(Namespace="http://PragimTech.com/ServiceVersion1")]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}