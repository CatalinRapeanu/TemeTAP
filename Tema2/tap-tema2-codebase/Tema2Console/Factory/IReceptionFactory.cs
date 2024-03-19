using Tema2Console.Receptions;

namespace Tema2Console.Factory;

public interface IReceptionFactory
{
    Reception Create(Order order);
}