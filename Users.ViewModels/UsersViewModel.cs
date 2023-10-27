namespace Users.ViewModels;

public class UsersViewModel : IUsersViewModel
{
    readonly IUsersModel _users;

    public UsersViewModel(IUsersModel users)
    {
        _users = users;
    }

    public IReadOnlyCollection<User> Users { get; private set; }

    public async Task GetUsersAsync()
    {
        Users = await _users.GetUserAsync();
    }
}
