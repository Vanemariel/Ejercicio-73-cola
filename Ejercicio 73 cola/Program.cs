using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();


            Console.WriteLine("¿hola cual es tu nombre");
            string nombre = Console.ReadLine();//puedo usar mucho texto
            Console.WriteLine("¿" + nombre + "ingresa tu apellido?");
            string cadena = Console.ReadLine();
            Console.WriteLine("¿ cual es tu calle de donde vivis");
            string direccion = Console.ReadLine();

            while (nombre + cadena + direccion != "")
            {
                queue.Enqueue(nombre + cadena + direccion);

                Console.WriteLine("Ingresa otro dato");

                Console.WriteLine("¿hola cual es tu nombre");
                nombre = Console.ReadLine();//puedo usar mucho texto

                Console.WriteLine("¿" + nombre + "ingresa tu apellido?");
                cadena = Console.ReadLine();

                Console.WriteLine("¿ cual es tu calle de donde vivis");
                direccion = Console.ReadLine();
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.ReadKey();

            /*string cadena;

            Queue<string> colaStr = new Queue<string>();

            Console.WriteLine("ingrese una cadena de texto");
            cadena = Console.ReadLine();

            while (cadena != "")
            {
                colaStr.Enqueue(cadena);
                Console.WriteLine("ingrese una cadena de texto");
                cadena=Console.ReadLine();  

            }
            while (colaStr.Count > 0)
            {
                Console.WriteLine(colaStr.Dequeue());
            }
            Console.ReadKey();*/
        }
    }
}