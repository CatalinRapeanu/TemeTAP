using Tema2Console.DateParser;
using Tema2Console.Logger;
using Tema2Console.Receptions;

namespace Tema2Console.Factory;

public class ReceptionFactory : IReceptionFactory
{
    public ILogger _logger;
    public IDateParser _dateParser;

    public ReceptionFactory(ILogger logger, IDateParser dateParser)
    {
        _logger = logger;
        _dateParser = dateParser;
    }
    
    
    public Reception Create(Order order)
    {
        switch (order.Type)
        {
            case OrderType.Room:
                return new HotelReception(_logger, _dateParser);
            case OrderType.Product:
                return new ProductReception(_logger, _dateParser);
            case OrderType.Breakfast:
                return new BreakfastReception(_logger, _dateParser);
            case OrderType.Lunch:
                return new LunchReception(_logger, _dateParser);
            case OrderType.Dinner:
                return new DinnerReception(_logger, _dateParser);
            
            default:
                return new UnknownReception(_logger, _dateParser);
        }
    }
}