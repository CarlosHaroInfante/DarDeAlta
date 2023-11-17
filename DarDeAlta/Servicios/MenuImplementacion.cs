using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Implementación donde se encuentra el menú
        /// 171123 - chi
        /// </summary>
        public int menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Escoge una opción");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Dar de Alta a un usuario");
            Console.WriteLine("-----------------");

           int opcion = Convert.ToInt32(Console.ReadLine()); //Opción lo leemos el número introducido por el usuario.

            return opcion;
        }
    }
}
