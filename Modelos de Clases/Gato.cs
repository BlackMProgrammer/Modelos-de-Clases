using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Modelos_de_Clases
{
    class Gato
    {
        private string _nombre;
        private string _raza;
        private int _edad;
        private string _color;

        public Gato(string _nombre, string _raza, int _edad, string _color) {

            this._nombre = _nombre;
            this._raza = _raza;
            this._edad = _edad;
            this._color = _color;
            
        }

        public void InformacionGato() {

            Console.WriteLine("El nombre del gato es {0}, su raza es: {1}, su edad es de {2} años y su color es {3}.",_nombre,_raza,_edad,_color);
        }
        public void maulla() {
            Console.WriteLine("Meooooow!");
        }
    }
}
