using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Console.Write("Въведи брой коли: ");
            int n = int.Parse(Console.ReadLine());
      
            for (int i = 0; i < n; i++)
            {
                Car car = new Car();
                cars.Add(car);

                Console.Write("Марка: ");
                car.Brand = Console.ReadLine();
                Console.Write("Модел: ");
                car.Model = Console.ReadLine();
                Console.Write("Рег. номер: ");
                car.RegistratioinNumber = Console.ReadLine();
                Console.Write("Година на производство: ");
                car.YearOfManufacture = int.Parse(Console.ReadLine());
                Console.WriteLine($"Брой коли: {cars.Count}");

                foreach (var item in cars)
                {
                    item.Introduce(); 
                    item.Move(); 
                    item.Eco();
                } 
            }
        }
    }
}
