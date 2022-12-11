
using Newtonsoft.Json;

public class SWAPI_Service
{
    private readonly HttpClient _client = new HttpClient();


    //Async methods
    public async Task<Person> GetPersonAsync(string url)
    {
        HttpResponseMessage response = await _client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var person = JsonConvert.DeserializeObject<Person>(content);
            return person;
        }
        return null; 
    }

 
}
