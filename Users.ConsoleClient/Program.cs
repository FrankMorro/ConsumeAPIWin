var Host = DIHost.CreateDefaultHost();

Host.Services.AddConsoleServices(
    Host.Configuration.GetSection("UsersEndpoints").Get<UsersEndpoints>());

Host.Build();

var view = Host.GetRequiredService<IUsersView>();

await view.RenderUsersAsync();
