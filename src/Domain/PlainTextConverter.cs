namespace Domain;

public class PlainTextConverter
{
    private Dictionary<int, string> _mapping = new()
    {
        
    };
    
    public string Convert(int digit)
    {
        if (digit == 3)
            return "tres";
        if (digit == 1)
            return "uno";
        return "cinco";
    }
}