using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Modelos_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Yoshi","Maltipoo",2,"Macho");
            perro.ladrar();
            perro.InformacionPerro();
            //Perro perro = new Perro();
            //perro.nombre = "Yoshi";
            //perro.edad = 2;
            //perro.raza = "Maltipoo";
            //perro.color = "blanco";
            //perro.sexo = "Macho";
            //perro.ladrar();
            //perro.InformacionPerro(perro.nombre, perro.edad);

            Perro perro1 = new Perro("Lulu","Chipoo",2,"Hembra");
            perro1.InformacionPerro();
            perro1.ladrar();

            //Perro perro1 = new Perro();
            //perro1.nombre = "Lulu";
            //perro1.edad = 1;
            //perro1.raza = "chipoo";
            //perro1.color = "Caqui";
            //perro1.sexo = "Hembra";
            //perro1.ladrar();
            //perro1.InformacionPerro(perro1.nombre,perro1.edad);

            Gato gato = new Gato("Kiki","Callejero",3,"Variado");
            gato.InformacionGato();
            gato.maulla();

            Butaca butaca = new Butaca("Comerdor", 10, 5);
            butaca.getButacasLibres();
        }
    }
}
