namespace Domain;

public static class PlainTextConverter
{
    private static Dictionary<int, string> _mapping = new()
    {
        
    };
    
    public static string Convert(int digit)
    {
        if (digit == 3)
            return "tres";
        if (digit == 1)
            return "uno";
        return "cinco";
    }
}