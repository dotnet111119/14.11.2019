using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car()
            {
                _color = "black",
                _height = 0.7f,
                _model = "CV",
                _work = true,
                _year = 2020
            };
            Console.WriteLine(honda);
            honda.BadTire();
            Console.WriteLine(honda);

            Car mitsubishi = new Car("Mitsubishi");
            Console.WriteLine(mitsubishi);

            Car ferrari = new Car("Ferrari", 2021, "red", 0.5f, true);
            Console.WriteLine(ferrari);

        }
    }
}
