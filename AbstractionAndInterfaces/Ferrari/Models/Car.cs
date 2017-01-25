using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    using global::Ferrari.Models;
    using System;

    public class Car : ICar
    {


        public Car(string nameOfTheDriver)
        {
            this.Driver = nameOfTheDriver;
            this.Model = "488-Spider";
        }

        public string Model { get; }

        public string Driver { get; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{Brakes()}/{Gas()}/{this.Driver}";
        }
    }
}
