using System.ServiceModel.Web;
namespace HelloWCF
{
    public class HelloToWCF 
    {
        
        public string GetMessage(string name)
        {
            return $"{name}, Welcome to WCF";
        }
    }
}
