using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public abstract class Reception
{
    protected ILogger logger;
    protected IDateParser dateParser;

    public Reception(ILogger logger, IDateParser dateParser)
    {
        this.logger = logger;
        this.dateParser = dateParser;
    }
    
    public abstract decimal FinalPrice(Order order);
}