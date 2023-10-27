using System.Text.Json;
using Users.MAUI.Models;

namespace MauiAppBlazor.Services;

internal class RickAndMortyService : IRickAndMortyService
{
    const string URL = "https://rickandmortyapi.com/api/character";
    public async Task<RickAndMorty> Get()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(URL);
        var content = await response.Content.ReadAsStringAsync();
        var rickAndMorty = JsonSerializer.Deserialize<RickAndMorty>(content);

        return rickAndMorty;
    }
}
