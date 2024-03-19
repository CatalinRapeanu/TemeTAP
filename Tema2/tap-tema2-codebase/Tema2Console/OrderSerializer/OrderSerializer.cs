using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tema2Console.ReceptionSerializer;

public class OrderSerializer : IOrderSerializer
{
    public List<Order> GetOrderFromJsonString(string orderJson)
    {
        return JsonConvert.DeserializeObject<List<Order>>(orderJson, new StringEnumConverter());
    }
}