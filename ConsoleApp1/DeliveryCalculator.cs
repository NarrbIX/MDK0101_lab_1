using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DeliveryService
    {
        public static void CalculateAndShow()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите стоймость заказа (руб.): ");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите расстояние (км.): ");
            double dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время заказа (руб.): ");
            double hour = double.Parse(Console.ReadLine());

        }
    }
}