namespace Users.Console.Views;

public class UsersView : IUsersView
{
    private readonly IUsersViewModel _viewModel;

    public UsersView(IUsersViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    public async Task RenderUsersAsync()
    {
        await _viewModel.GetUsersAsync();
        foreach (var user in _viewModel.Users)
        {
            WriteTop();
            WriteMiddler(user.Id.ToString());
            WriteMiddler(user.Name);
            WriteMiddler(user.Email);
            WriteMiddler(user.Phone);
            WriteBotton();
        }
    }

    static void WriteTop() =>
        System.Console.WriteLine(" ╔{0}╗", new string('═', 70));

    static void WriteMiddler(string text) =>
        System.Console.WriteLine(" ║ {0,-69}║", text);

    static void WriteBotton() =>
        System.Console.WriteLine(" ╚{0}╝", new string('═', 70));
}
