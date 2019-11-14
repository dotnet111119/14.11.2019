using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411
{
    class Program
    {
        static int x = 1;
        static void Main(string[] args)
        {
            // 1
            Mobile iPhone = new Mobile();
            iPhone.Call();
            iPhone.Ring(1);
            iPhone._color = "Black";
            iPhone._model = "Samsung9";
            iPhone._size = 5.9f;

            // 2
            Mobile samsung9 = new Mobile()
            {
                _color = "White",
                _model = "Samsung",
                _size = Program.x
            };
            samsung9.Call();
            samsung9._color = "Black";
            samsung9._model = "Samsung9";
            //samsung9._size = 5.9f;

            // 3    
            Mobile nokia = new Mobile("nokia", 6.7f, "green");

            Console.WriteLine(nokia);
            Console.WriteLine(nokia.GetType());
        }
    }
}
