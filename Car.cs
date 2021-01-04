using System;
using System.Collections.Generic;
using System.Text;

namespace Fastest_car
{
    class Car
    {
        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
