namespace MyFirstAzureApp.Config
{
    public class AppSettings
    {
        public string ApiUrl {get; set;} = string.Empty;
        public string JwtSecret {get; set;} = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
    }
}
