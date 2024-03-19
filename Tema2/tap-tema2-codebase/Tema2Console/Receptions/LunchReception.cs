using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class LunchReception : Reception
{
    public LunchReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        logger.Log("Processing Lunch order...");
        logger.Log("Validating order parameters...");

        if (order.LunchQuantity == 0)
        {
            logger.Log("-Lunch order must specify Quantity");
            return 0;
        }

        if (order.LunchPrice == 0)
        {
            logger.Log("-Lunch order must specify Price");
            return 0;
        } 
        
        if (!dateParser.TryParseDate(order.LunchServingDate, out var pasedServingDate))
        {
            logger.Log("-Serving Date must be a valid date");
            return 0;
        }

        decimal price = 0;
        
        if (pasedServingDate < DateTime.Now.AddDays(7))
        {
            price += order.LunchQuantity * order.LunchPrice;
        }
        else
        {
            price += (order.LunchQuantity * order.LunchPrice) * 0.5m;
        }

        return price;
    }
}