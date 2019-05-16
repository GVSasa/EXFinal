using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name.Classes
{
    class Nombre
    {
        public static void Nmbr()
        {
            Console.WriteLine("escribe tu nombre"); //Imprimir lo necesario en pantalla

            string nombre = Console.ReadLine(); //meter lo escrito a un string 

            if (nombre.Length == 2)
            {
                Console.WriteLine("nombre no valido");
            }
            else
            {

            }
        }
    }
}
