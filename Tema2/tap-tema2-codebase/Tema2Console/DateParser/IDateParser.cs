namespace Tema2Console.DateParser;

public interface IDateParser
{
    bool TryParseDate(string dateString, out DateTime pasedDate);
}