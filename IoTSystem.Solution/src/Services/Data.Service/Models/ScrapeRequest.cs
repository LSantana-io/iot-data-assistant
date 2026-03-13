namespace Data.Service.Models;

public class ScrapeRequest
{
    public Guid Id { get; set; }
    public string PlatformName { get; set; } = string.Empty;
    public string DataType { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending"; // Pending, Concluded, Failed
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? FinishedAt { get; set; }
    public byte[]? DataRaw { get; set; } //Where CSV files will be saved
}