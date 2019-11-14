using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411
{
    /// <summary>
    /// 
    /// </summary>
    public class Mobile
    {
        #region DATA MEMBERS

        // DATA
        public string _model;
        public float _size;
        public string _color;

        #endregion

        #region Functionallity 


        /// <summary>
        /// Ctor
        /// </summary>
        public Mobile()
        {

        }


        public Mobile(string _model, float _size, string _color)
        {
            this._model = _model;
            this._size = _size;
            this._color = _color;
        }

        // FUNCTIONALLITY

        /// <summary>
        /// What the function does
        /// </summary>
        /// <param name="x">what is x?</param>
        /// <returns></returns>
        public float Ring(int x)
        {
            Console.WriteLine($"{_model} is Ringing...");
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
        }
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public override string ToString()
        {
            return $"Mobile: model={_model} size={_size} color={_color}";
        }

        #endregion  

    }
}
