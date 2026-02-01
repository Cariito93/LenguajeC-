using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables.
            int hamb, papa, bebida, chamb, cpapa, cbebida, tot; //Declaración de las variables
            hamb = 2000; //Asignacion de valores a las variables iniciales
            papa = 1200; //Estos valores fueron otorgados por el docente
            bebida = 800; //Cuando toda la información es ingresada por el usuario, ya la cosa cambia
            //Estetica inicial, nada mas por quemar código.
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********Bienvenido**********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******Nuestro Menú es:******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Hamburguesa.......$2.000 c/u");
            Console.WriteLine("Papas.............$1.200 c/u");
            Console.WriteLine("Bebidas...........$  800 c/u");
            Console.WriteLine("----------------------------");
            //Ingreso de datos.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Por favor ingrese la cantidad de Hamburguesas: "); //Solicita el ingreso de cantidades por parte del usuario
            chamb = Convert.ToInt32(Console.ReadLine()); //lee el número ingresado por el usuario y lo convierte a entero
            Console.WriteLine("Por favor ingrese la cantidad de Papas: ");
            cpapa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la cantidad de Bebidas: ");
            cbebida = Convert.ToInt32(Console.ReadLine());
            //Proceso para mostrar el precio final.
            tot = (hamb * chamb) + (papa * cpapa) + (bebida * cbebida); //Multiplica la cantidad de cada cosa por el valor asignado inicialmente
            //Salida de valores.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El valor total de su compra es: " + tot.ToString("C")); //Muestra al usuario el valor total de la operación anterior
            Console.ReadKey();        
        }
    }
}
