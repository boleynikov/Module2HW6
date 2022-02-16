using Module2HW6.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Extention;
namespace Module2HW6
{
    class Starter
    {
        public static void Run()
        {
            ParkService park = new ParkService();
            Console.WriteLine($"Общая стоимость всех автомобилей таксопарка {park.PriceOfAllCars} $$$");
            Console.WriteLine();
            Console.WriteLine("Проверим каждую машину таксопарка");
            foreach (var car in park.Cars)
            {
                car.Run();
            }
            Console.WriteLine();
            Console.WriteLine("Теперь рассортируем все машины по расходу топлива");
            Array.Sort(park.Cars);
            foreach (var car in park.Cars)
            {
                car.Run();
            }
            Console.WriteLine("Найдём машину с диапазоном цены от 554000 до 675000");
            var findedCar = park.Cars.FindCar(554000, 675000);
            Console.WriteLine($"Цена машины - {findedCar.Price}");
            findedCar.Run();
        }
    }
}
