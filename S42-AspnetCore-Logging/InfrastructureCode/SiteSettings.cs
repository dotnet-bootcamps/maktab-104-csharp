namespace S42_AspnetCore_Logging.InfrastructureCode;

public class SiteSettings
{
    public SeqSettings SeqSettings { get; set; }
    public string WorkDays { get; set; }
    public int StartWorkFrom { get; set; }
}

public class SeqSettings
{
    public string Address { get; set; }
    public string ApiKey { get; set; }
}
