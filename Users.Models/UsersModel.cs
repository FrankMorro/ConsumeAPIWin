namespace Users.Models;

public class UsersModel : IUsersModel
{
    private readonly HttpClient _httpClient;
    private readonly UsersEndpoints _endpoints;

    public UsersModel(HttpClient httpClient, UsersEndpoints endpoints)
    {
        _httpClient = httpClient;
        _endpoints = endpoints;
    }

    public async Task<IReadOnlyCollection<User>> GetUserAsync() =>
        await _httpClient.GetFromJsonAsync<IReadOnlyCollection<User>>(_endpoints.Users);
}
