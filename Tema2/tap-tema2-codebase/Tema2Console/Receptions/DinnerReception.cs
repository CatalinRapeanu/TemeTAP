using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class DinnerReception : Reception
{
    public DinnerReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        logger.Log("Processing Dinner order...");
        logger.Log("Validating order parameters...");

        if (order.DinnerQuantity == 0)
        {
            logger.Log("-Dinner order must specify Quantity");
            return 0;
        }

        if (order.DinnerPrice == 0)
        {
            logger.Log("-Dinner order must specify Price");
            return 0;
        } 
        
        if (!dateParser.TryParseDate(order.DinnerServingDate, out var pasedServingDate))
        {
            logger.Log("-Serving Date must be a valid date");
            return 0;
        }

        decimal price = 0;
        
        if (pasedServingDate < DateTime.Now.AddDays(7))
        {
            price += order.DinnerQuantity * order.DinnerPrice;
        }
        else
        {
            price += (order.DinnerQuantity * order.DinnerPrice) * 0.5m;
        }

        return price;
    }
}