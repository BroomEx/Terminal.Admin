namespace Terminal.Admin.App.Data;

public class PowerUnit
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public double Power { get; set; }
    public string TedomAB1 { get; set; } = string.Empty;
    public string TedomAB2 { get; set; } = string.Empty;
}
