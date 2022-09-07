using System.Net.Http.Headers;
using System.Net.Http.Json;


    public class ServerConnection
    {
        string baseAddress = "https://localhost:7230/";
        HttpClient client = new HttpClient();    

        public async Task<List<T>> CreateRequest<T>(string apiRoute)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(apiRoute);
            responseMessage.EnsureSuccessStatusCode();

#pragma warning disable CS8603
        if (responseMessage.IsSuccessStatusCode)
            {
                return await responseMessage.Content.ReadFromJsonAsync<List<T>>();              
            }
            else
            {
                return null;
            }          
        }
#pragma warning restore CS8603
    public async Task PostRequest<T>(string apiRoute,T obj)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);               
            await client.PostAsJsonAsync<T>(apiRoute, obj);              
        }

        public async Task DeleteRequest(string apiRoute)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            await client.SendAsync(new HttpRequestMessage(HttpMethod.Delete, apiRoute));
        }

        public async Task PutRequest<T>(string apiRoute, T obj)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            await client.PutAsJsonAsync<T>(apiRoute, obj);
    }
    }
public enum EventMetaType { Nature, Travel, Drinking, Entertainment, Sports }
