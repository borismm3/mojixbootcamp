using Microsoft.Extensions.Configuration;

namespace SeleniumTraining.src.code.util
{
    public class GetPropertiesTodoly
    {
        private static readonly Lazy<GetPropertiesTodoly> lazyInstance = new Lazy<GetPropertiesTodoly>(() => new GetPropertiesTodoly());
        private readonly IConfiguration config;

        private GetPropertiesTodoly()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                            + "/src/resources/properties/TodolyApp.json";
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

        public static GetPropertiesTodoly Instance => lazyInstance.Value;

        public string Browser => config.GetValue<string>("AppSettings:browser");
        public string Host => config.GetValue<string>("AppSettings:host");
        public string User => config.GetValue<string>("AppSettings:user");
        public string Password => config.GetValue<string>("AppSettings:password");
    }
}
