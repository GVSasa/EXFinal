using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Name.Classes
{
    class Apellido
    {
        public static void Apll()
        {
            Console.WriteLine("escribe tu apellido"); //Imprimir lo necesario en pantalla

            string apellido = Console.ReadLine(); //meter lo escrito a un string 

            if (apellido.Length == 2)
            {
                Console.WriteLine("apellido no valido");
            }
            else
            {

            }
        }

        



    }
}
