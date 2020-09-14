using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos_de_Clases
{
    public class Perro
    {
      private string _nombre;
      private string _raza;
      private string _color;
      private int _edad;
      private string _sexo;
        private int _cantPerros;

        public Perro(string nombre, string raza, int edad, string sexo)
        {
            this._nombre = nombre;
            this._raza = raza;
            this._edad = edad;
            this._sexo = sexo;

            _cantPerros++;
        }

        public void InformacionPerro() {

            Console.WriteLine("El perro {0} tiene {1} años de edad, es {2} y su raza es: {3}", _nombre, _edad * 7, _sexo, _raza);
        }

        public void ladrar() 
        {
            Console.WriteLine("Wuau! Wuau!");
        }

        public int getCantPerros() 
        {
            Console.WriteLine("La cantidad de Perros es de {0}",_cantPerros);
            return _cantPerros;
        }
    }
}
