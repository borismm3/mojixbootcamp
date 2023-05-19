using Microsoft.Extensions.Configuration;

namespace SeleniumTraining.src.code.util
{
    public class GetPropertiesTodoist
    {
        private static readonly Lazy<GetPropertiesTodoist> lazyInstance = new Lazy<GetPropertiesTodoist>(() => new GetPropertiesTodoist());
        private readonly IConfiguration config;

        private GetPropertiesTodoist()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                            + "/src/resources/properties/TodoistApp.json";
            try
            {
                config = new ConfigurationBuilder()
                             .AddJsonFile(path)
                             .Build();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading configuration: {ex.Message}");
            }
        }

        public static GetPropertiesTodoist Instance => lazyInstance.Value;

        public string Browser => config.GetValue<string>("AppSettings:browser");
        public string Host => config.GetValue<string>("AppSettings:host");
        public string User => config.GetValue<string>("AppSettings:user");
        public string Password => config.GetValue<string>("AppSettings:password");
    }
}
