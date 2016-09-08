using System.ServiceModel;

namespace HelloWCF
{
    [ServiceContract]
    public interface IHelloToWCF
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
