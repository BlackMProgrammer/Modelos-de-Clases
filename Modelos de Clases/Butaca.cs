using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Modelos_de_Clases
{
    class Butaca
    {
        private string _lugar;
        private int _ocupadas;
        private int _cantidad;

        public Butaca(string _lugar,int _cantidad, int _ocupadas ) {

            this._lugar = _lugar;
            this._cantidad = _cantidad;
            this._ocupadas = _ocupadas;
        }

        public void getButacasLibres() {
             int libres = _cantidad - _ocupadas;
            Console.WriteLine("La cantidad de butacas en el lugar: {0}, es de: {1}, las ocupadas es de {2}, por tanto las libres son: {3}",_lugar,_cantidad,_ocupadas,libres);
        }
    }
}
