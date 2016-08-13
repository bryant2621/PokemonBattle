using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace TestService
{
    [ServiceContract]
    public interface IRestTestService
    {
        [WebInvoke(UriTemplate = "test/{args}", Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract()]
        string GetTest(string args);
    }
}
