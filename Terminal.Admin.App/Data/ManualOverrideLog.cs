namespace Terminal.Admin.App.Data;

public class ManualOverrideLog
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string User { get; set; } = string.Empty;
    public string AggregationBlock { get; set; } = string.Empty;
    public string LogType { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
