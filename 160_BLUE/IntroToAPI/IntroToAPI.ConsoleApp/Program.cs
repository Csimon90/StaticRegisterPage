using static System.Console;

Clear();

HttpClient _client = new HttpClient();

HttpResponseMessage response = await _client.GetAsync("htt[s://swapi.dev/api/people/1");
//System.Console.WriteLine(await response.Content.ReadAsStringAsync());

if (response.IsSuccessStatusCode)
{
    var content = await response.Content.ReadAsStringAsync();
    System.Console.WriteLine(content);
}