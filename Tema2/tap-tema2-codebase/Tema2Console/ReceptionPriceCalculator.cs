using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tema2Console.DateParser;
using Tema2Console.Factory;
using Tema2Console.FileSource;
using Tema2Console.Logger;
using Tema2Console.Receptions;
using Tema2Console.ReceptionSerializer;

namespace Tema2Console
{
    public class ReceptionPriceCalculator
    { 
        private ILogger _logger;
        private IFileSource _fileSource;
        private IOrderSerializer _orderSerializer;
        private IDateParser _dateParser;
        private IReceptionFactory _factory;

        public ReceptionPriceCalculator(ILogger logger, IFileSource fileSource, IOrderSerializer orderSerializer,
            IDateParser dateParser, IReceptionFactory factory)
        {
            _logger = logger;
            _fileSource = fileSource;
            _orderSerializer = orderSerializer;
            _dateParser = dateParser;
            _factory = factory;
        }
        
        public decimal FinalPrice { get; set; }

        public void ProcessOrder()
        {
            _logger.Log("Start processing...");
            _logger.Log("Loading order from file...");
            
            var dataJson = _fileSource.GetOrderSource();

            _logger.Log("Deserializing Order object from json data...");
            
            var orders = _orderSerializer.GetOrderFromJsonString(dataJson);

            if (orders == null)
            {
                _logger.Log("Order type not parsed successfully.");
                return;
            }

            foreach (var order in orders)
            {
                var priceCalculator = _factory.Create(order);
                FinalPrice += priceCalculator.FinalPrice(order);
            }
            
            _logger.Log("Calculation completed.");
        }
    }
}
