using Delivery.Entities;
using Delivery.Entities.Enums;

namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1001,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}