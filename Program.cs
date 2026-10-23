using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Жигули";
            car.Number = "Т144ТО";
            car.Mileage = 10350;
            car.Show();
            Console.WriteLine("Средний пробег за год " + car.Raschet(2));
        }
        public class Car
        {
            public string Brand;
            public string Number;
            public int Mileage;
            
            public void Show()
            {
                Console.WriteLine($" Brand {Brand}, Number {Number}, Mileage {Mileage}");
            }
            public double Raschet(int Age)
            {
                return (double)Mileage / Age;
            }
        }
    }
}
