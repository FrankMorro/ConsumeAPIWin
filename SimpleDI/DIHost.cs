namespace SimpleDI;

public class DIHost
{
    static DIHost DIHostInstance;
    private DIHost() { }

    public IServiceCollection Services { get; private set; }

    public IConfiguration Configuration { get; private set; }

    public IServiceProvider ServiceProvider { get; private set; }

    public T GetService<T>() => ServiceProvider.GetService<T>();

    public T GetRequiredService<T>() => ServiceProvider.GetRequiredService<T>();

    public static DIHost CreateDefaultHost()
    {
        if (DIHostInstance is null)
        {
            DIHostInstance = new DIHost();
            DIHostInstance.LoadConfiguracion();
            DIHostInstance.Services = new ServiceCollection();
        }

        return DIHostInstance;
    }

    public void Build()
    {
        DIHostInstance.ServiceProvider =
            DIHostInstance.Services.BuildServiceProvider();
    }

    void LoadConfiguracion()
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true)
            .AddEnvironmentVariables()
            .Build();
    }
}
