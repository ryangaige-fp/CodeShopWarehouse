using OrderSystem.Entities;

namespace OrderSystem.Data
{
    public interface IIOrderRepo
    {
        void UpdateOrder(Order order);
    }
}