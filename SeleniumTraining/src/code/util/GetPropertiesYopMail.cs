using Microsoft.Extensions.Configuration;

namespace SeleniumTraining.src.code.util
{
    public class GetPropertiesYopMail
    {
        private static readonly Lazy<GetPropertiesYopMail> lazyInstance = new Lazy<GetPropertiesYopMail>(() => new GetPropertiesYopMail());
        private readonly IConfiguration config;

        private GetPropertiesYopMail()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                            + "/src/resources/properties/YopmailApp.json";
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

        public static GetPropertiesYopMail Instance => lazyInstance.Value;

        public string Browser => config.GetValue<string>("AppSettings:browser");
        public string Host => config.GetValue<string>("AppSettings:host");
        public string User => config.GetValue<string>("AppSettings:user");
    }
}
