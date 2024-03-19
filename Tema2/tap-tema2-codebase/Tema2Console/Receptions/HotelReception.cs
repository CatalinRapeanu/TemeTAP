using Tema2Console.DateParser;
using Tema2Console.Logger;

namespace Tema2Console.Receptions;

public class HotelReception : Reception
{
    public HotelReception(ILogger logger, IDateParser dateParser) : base(logger, dateParser)
    {
    }

    public override decimal FinalPrice(Order order)
    {
        logger.Log("Processing Room order...");
        logger.Log("Validating order parameters...");

        if (order.Quantity == 0)
        {
            logger.Log("-Room order must specify Quantity");
            return 0;
        }

        if (order.Price == 0)
        {
            logger.Log("-Room order must specify Price");
            return 0;
        }

        if (string.IsNullOrEmpty(order.ReservationDate))
        {
            logger.Log("-Room order must specify Reservation Date");
            return 0;
        }

        if (!dateParser.TryParseDate(order.ReservationDate, out var pasedReservationDate))
        {
            logger.Log("-Reservation Date must be a valid date");
            return 0;
        }

        decimal price = 0;

        if (pasedReservationDate < DateTime.Now.AddMonths(1))
        {
            price += (order.Quantity * order.Price) * 0.9m;
        }
        else if (pasedReservationDate < DateTime.Now.AddMonths(2))
        {
            price += (order.Quantity * order.Price) * 0.8m;
        }
        else
        {
            price += order.Quantity * order.Price;
        }

        return price;
    }
}