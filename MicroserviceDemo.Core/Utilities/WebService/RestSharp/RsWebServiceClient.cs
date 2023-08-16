using Newtonsoft.Json;
using RestSharp;

namespace MicroserviceDemo.Core.Utilities.WebService.RestSharp
{
    public class RsWebServiceClient
    {
        public static RestResponse GetWebService(string apiUrl, string api, List<string>? parameters = null)
        {
            var client = new RestClient(apiUrl);
            var request = new RestRequest(api, Method.Get);
            if (parameters != null || parameters?.Count > 0)
            {
                string? parameterJson = "";
                foreach (var parameter in parameters)
                {
                    parameterJson = JsonConvert.SerializeObject(parameter);
                }
                request.AddParameter(parameterJson, ParameterType.QueryString);
            }
            var response = client.Execute(request);
            return response;
        }

        public static RestResponse PostWebService(string apiUrl, string api, List<string> parameters, List<string>? authParameters = null)
        {
            var client = new RestClient(apiUrl);
            var request = new RestRequest(api, Method.Post);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json; charset=utf-8");
            if (authParameters != null || authParameters?.Count > 0)
            {
                var authJson = JsonConvert.SerializeObject(authParameters);
                request.AddParameter("application/json", authJson, ParameterType.RequestBody);
            }
            else
            {
                var parameterJson = JsonConvert.SerializeObject(parameters);
                request.AddParameter("application/json", parameterJson, ParameterType.RequestBody);
            }
            var response = client.Execute(request);
            return response;
        }
    }
}
