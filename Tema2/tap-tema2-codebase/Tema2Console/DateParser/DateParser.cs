namespace Tema2Console.DateParser;

public class DateParser : IDateParser
{
    public bool TryParseDate(string dateString, out DateTime pasedDate)
    {
        return DateTime.TryParseExact(dateString, "dd-MM-yyyy",
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out pasedDate);
    }
}