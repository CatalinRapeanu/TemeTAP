namespace Tema2Console.ReceptionSerializer;

public interface IOrderSerializer
{
    List<Order> GetOrderFromJsonString(string orderJson);
}