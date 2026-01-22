namespace Terminal.Admin.App.Data;

public class PpsProvider
{
    public List<string> GetPpsValues()
    {
        return new List<string>
        {
            "mFRR12.5+",
            "mFRR12.5-",
            "aFRR+",
            "aFRR-",
            "mFRR5"
        };
    }
}
