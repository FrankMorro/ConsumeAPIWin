namespace Users.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, UsersEndpoints endpoints)
    {
        services.AddHttpClient<IUsersModel, UsersModel>(httpClient => new UsersModel(httpClient, endpoints));

        services.AddScoped<IUsersViewModel, UsersViewModel>();

        return services;
    }

    public static IServiceCollection AddConsoleServices(this IServiceCollection services, UsersEndpoints endpoints)
    {
        services.AddCoreServices(endpoints);

        services.AddScoped<IUsersView, UsersView>();

        return services;
    }
}
