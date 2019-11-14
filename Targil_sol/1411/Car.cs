using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411
{
    public class Car
    {
        #region DATA

        public string _model;
        public int _year;
        public string _color;
        public float _height;
        public bool _work;

        #endregion

        #region Methods

        public Car()
        {

        }

        public Car(string _model)
        {
            this._model = _model;
        }

        public Car(string _model, int _year, string _color, float _height, bool _work)
        {
            this._model = _model;
            this._year = _year;
            this._color = _color;
            this._height = _height;
            this._work = _work;
        }

        public void FixCar()
        {
            _work = true;
        }

        public void Paint(string color)
        {
            _color = color;
        }

        public void BadTire()
        {
            Console.WriteLine("Oh no....");
            _height = _height / 2.0f;
            _work = false;
        }

        #endregion
    }
}
