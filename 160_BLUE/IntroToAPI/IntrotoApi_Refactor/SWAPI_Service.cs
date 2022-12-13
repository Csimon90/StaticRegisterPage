
using Newtonsoft.Json;

public class SWAPI_Service
{
    private readonly HttpClient _client = new HttpClient();


//Async Method template
    public async Task<T> GetTAsync<T>(string url) //where T : class
    {
        var response = await _client.GetTAsync(url);
        if(response.IsSuccessStatusCode)
        {
            var content =await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(content);
            return obj;
        }
        return default; 
    }



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

    public async Task<SearchResult<Person>> GetSearchPersonAsync(string query)
        {
            var response = await _client.GetAsync("https://swapi.dev/api/people?search="+query);
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var searchResult = JsonConvert.DeserializeObject<SearchResult<Person>>(content);
                return searchResult;
            }
        return null;
        }
    public async Task<SearchResult<T>> GetSearchResultAsync<T>(string query, string category) where T:class
    {
    if(response.IsSuccessStatusCode)
    {
        var response = await _client.GetAsync($"https://swapi.dev/api/{category}?search={queary}");
        var searchResult = JsonConvert.DeserializeObject<SearchResult<T>>(content);
        return searchResult;
    }
    return null;
}




}