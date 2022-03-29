using RestSharp;

namespace Evrensel.WebApplication.Provider
{
    public class ProductProvider
    {
        public string GetAll()
        {
            var client = new RestClient("https://localhost:9002/api/products");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
           
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
