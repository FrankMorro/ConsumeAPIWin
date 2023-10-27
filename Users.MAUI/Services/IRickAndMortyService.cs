using Users.MAUI.Models;

namespace MauiAppBlazor.Services;

public interface IRickAndMortyService
{
    public Task<RickAndMorty> Get();
}
