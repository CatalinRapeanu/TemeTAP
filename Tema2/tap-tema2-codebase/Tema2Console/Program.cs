using Tema2Console.Factory;
using Tema2Console.Logger;
using Tema2Console.ReceptionSerializer;

namespace Tema2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            var loggerInstance = new SecondLogger();
            
            //sau
            //var loggerInstance = new Logger.Logger();
            //in functie de ce logger vrem sa folosim
            
            var dateParserInstance = new DateParser.DateParser();
            var receptionPriceCalculator = new ReceptionPriceCalculator(
                loggerInstance, 
                new FileSource.FileSource(), 
                new OrderSerializer(), 
                dateParserInstance, 
                new ReceptionFactory(loggerInstance, 
                    dateParserInstance));
            
            receptionPriceCalculator.ProcessOrder();

            if (receptionPriceCalculator.FinalPrice == 0)
            {
                Console.WriteLine("No order was processed.");
            }
            else
            {
                Console.WriteLine($"Final price for you order: {receptionPriceCalculator.FinalPrice} RON");
            }
        }
    }
}
