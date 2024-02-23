using System.Threading.Tasks;
using RestSharp;

namespace PhotoBooth.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/booths", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/booths/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post(string newBooth)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/booths", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBooth);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string newBooth)
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/booths/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBooth);
      await client.PutAsync(request);
    }
  }
}