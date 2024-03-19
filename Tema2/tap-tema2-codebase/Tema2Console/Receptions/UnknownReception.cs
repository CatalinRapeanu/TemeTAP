using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class UnknownReception : Reception
{
    public UnknownReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        return 0;
    }
}