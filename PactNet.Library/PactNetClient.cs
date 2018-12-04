using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PactNet.Library;

namespace PactNet.Library {
  public class PactNetClient {
    private string Uri { get; set; }

    public PactNetClient (string uri) {
      Uri = uri;
    }

    public async Task<User> Get (int id) {
      using (var client = new HttpClient { BaseAddress = new Uri(Uri) }) {
        var response = await client.GetAsync($"/api/user/{id}");

        if (response.StatusCode == HttpStatusCode.OK)
          return JsonConvert.DeserializeObject<User> (await response.Content.ReadAsStringAsync ());

        return null;
      }
    }

        public async Task<User> Post(int id, object data)
        {
            using (var client = new HttpClient { BaseAddress = new Uri(Uri) })
            {
                var myContent = JsonConvert.SerializeObject(data);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync($"/api/user/{id}", byteContent);

                if (response.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
                return null;
            }
        }
    }
}