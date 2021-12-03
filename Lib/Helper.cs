namespace Greetr.Lib;

public static class Helper
{
    public static string GetMorningMessage()
    {
        var index = new Random().Next(1, 3);
        switch (index)
        {
            case 1: return "Good morning!";
            case 2: return "Rise and shine!";
            default: return "It's a brand new day!";
        }
    }

    public static string GetGenericMessage()
    {
        var index = new Random().Next(1, 3);
        switch (index)
        {
            case 1: return "Hi!";
            case 2: return "How's the day so far?";
            default: return "Hello!";
        }
    }

    public static string GetEveningMessage()
    {
        var index = new Random().Next(1, 3);
        switch (index)
        {
            case 1: return "Good evening!";
            case 2: return "Hello!";
            default: return "A pleasant night to you!";
        }
    }

    public static string GetUnsupportedMessage()
    {
        var index = new Random().Next(1, 3);
        switch (index)
        {
            case 1: return "Isn't it too late for you?";
            case 2: return "You're too early!";
            default: return "You should be sleeping!";
        }
    }
}