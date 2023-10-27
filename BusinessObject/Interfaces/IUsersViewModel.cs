namespace BusinessObject.Interfaces;

public interface IUsersViewModel
{
    IReadOnlyCollection<User> Users { get; }
    Task GetUsersAsync();
}
