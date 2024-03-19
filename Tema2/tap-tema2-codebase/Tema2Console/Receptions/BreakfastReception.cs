using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class BreakfastReception : Reception
{
    public BreakfastReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        logger.Log("Processing Breakfast order...");
        logger.Log("Validating order parameters...");

        if (order.BreakfastQuantity == 0)
        {
            logger.Log("-Breakfast order must specify Quantity");
            return 0;
        }

        if (order.BreakfastPrice == 0)
        {
            logger.Log("-Breakfast order must specify Price");
            return 0;
        } 
        
        if (!dateParser.TryParseDate(order.BreakfastServingDate, out var pasedServingDate))
        {
            logger.Log("-Serving Date must be a valid date");
            return 0;
        }

        decimal price = 0;
        
        if (pasedServingDate < DateTime.Now.AddDays(7))
        {
            price += order.BreakfastQuantity * order.BreakfastPrice;
        }
        else
        {
            price += (order.BreakfastQuantity * order.BreakfastPrice) * 0.5m;
        }

        return price;
    }
}