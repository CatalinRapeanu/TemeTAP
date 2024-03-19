using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class ProductReception : Reception
{
    public ProductReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        logger.Log("Processing Product order...");
        logger.Log("Validating order parameters...");
        
        if (string.IsNullOrEmpty(order.ProductName))
        {
            logger.Log("-Product order must specify Name");
            return 0;
        }
        
        if (order.ProductQuantity == 0)
        {
            logger.Log("-Product order must specify Quantity");
            return 0;
        }
        
        if (order.ProductPrice == 0)
        {
            logger.Log("-Product order must specify Price");
            return 0;
        }
        
        var price = order.ProductQuantity * order.ProductPrice;
        
        if (order.ProductName == "Fanta")
        {
            price *= 0.75m;
        }
        
        return price;
    }
}