using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   internal class Car
   {
        private string brand;
        private string model;
        private string registratioinNumber;
        private int yearOfManufacture;

        private static int counter
        {
            get
            {
                return counter;
            }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string RegistratioinNumber
        {
            get { return registratioinNumber; }
            set { registratioinNumber = value; }
        }
        public int YearOfManufacture
        {
            get { return yearOfManufacture; }
            set { yearOfManufacture = value; }
            
        }
        public Car(string brand, string model, string registratioinNumber, int yearOfManufacture)
        {
            this.Brand = brand;
            this.Model = model;
            this.RegistratioinNumber = registratioinNumber;
            this.YearOfManufacture = yearOfManufacture;
        }

        public Car()
        {
            this.brand = null;
            this.model = null;
        }
        public void Introduce()
        {
            Console.WriteLine($"Марка: {this.Brand}, Модел: {this.Model}, Рег. номер: {this.RegistratioinNumber}, " +
            $"Година на производство: {this.YearOfManufacture}");
        }
        public void Move()
        {
            Console.WriteLine($"{this.Brand} {this.Model}: Brym-Brym-Brym");
        }
        public void Eco()
        {
            if (yearOfManufacture >= 2000)
            {
                Console.WriteLine("ECO");
            }
            else
            {
                Console.WriteLine("I'm not ECO car!");
            }
        }
    }
}
