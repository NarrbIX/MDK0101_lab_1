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
            double fee = 0;
            if (cost < 2000)
            {
                fee = 150;
                if (dist > 3)
                    fee += (dist - 3) * 50;
            }
            if ((hour >= 12 && hour <= 14) || (hour >= 18 && hour <= 20))
                fee *= 1.3;
            Console.WriteLine($"Стоймость доставки: {fee:F0} руб.");
            Console.WriteLine($"Итого к оплате: {cost + fee:F0} руб.");

        }
    }
}