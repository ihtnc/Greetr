namespace Greetr.Lib;

public class Greetng : IGreetng
{
    const int MORNING_CUTOFF = 10;     // from 4am to 10am is morning
    const int DAY_CUTOFF = 16;         // from 10am to 4pm is the day
    const int NIGHT_CUTOFF = 22;       // from 4pm to 10pm is night
    const int UNSUPPORTED_CUTOFF = 4;  // from 10pm to 4am is unsupported


    public string Get()
    {
        var currentTime = DateTime.Now;

        switch (currentTime.Hour)
        {
            case > UNSUPPORTED_CUTOFF and < MORNING_CUTOFF:
                return Helper.GetMorningMessage();
            case > MORNING_CUTOFF and < DAY_CUTOFF:
                return Helper.GetGenericMessage();
            case > DAY_CUTOFF and < NIGHT_CUTOFF:
                return Helper.GetEveningMessage();
            default:
                return Helper.GetUnsupportedMessage();
        }
    }
}
