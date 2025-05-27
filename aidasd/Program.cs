using System;
using System.Data;

namespace aidasd
{
    class Order///git
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Order Caesar = new Order { Id = 0, Name = "Цезарь-пицца" };
            Order Mega = new Order { Id = 1, Name = "Мега-пицца" };
            Order Burger = new Order { Id = 2, Name = "Бургер-пицца" };

            Queue<Order> OrderQueue = new Queue<Order>();

            OrderQueue.Enqueue(Caesar);
            Console.WriteLine("В очередь обавлен объект ''Цезарь''  ");
            OrderQueue.Enqueue(Mega);
            Console.WriteLine("В очередь обавлен объект ''Мега''  ");
            OrderQueue.Enqueue(Burger);
            Console.WriteLine("В очередь обавлен объект ''Бургер''  ");
            Console.WriteLine();

            foreach (var item in OrderQueue)
            {
                Console.WriteLine($"Идентификатор: {item.Id} | Объкет: {item.Name}");
            }

            OrderQueue.Dequeue();

            Console.WriteLine();
            Console.WriteLine("Из очереди удален объект");
            Console.WriteLine();

            foreach (var item in OrderQueue)
            {
                Console.WriteLine($"Идентификатор: {item.Id} | Объкет: {item.Name}");
            }

            Console.WriteLine(OrderQueue.Peek());
        }
    }
    class Test
    {

    }
}