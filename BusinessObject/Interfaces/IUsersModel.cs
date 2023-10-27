namespace BusinessObject.Interfaces;

public interface IUsersModel
{
    Task<IReadOnlyCollection<User>> GetUserAsync();
}
