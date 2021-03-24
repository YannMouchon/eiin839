using System.ServiceModel;
using System.ServiceModel.Web;

namespace MathsLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMathsOperations
    {

        [OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Add?a={a}&b={b}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int Add(int a, int b);

        [OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Sub?a={a}&b={b}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int Subtract(int a, int b);

        [OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Mult?a={a}&b={b}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int Multiply(int a, int b);

    }


}
