using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class NuevoImplementacion : NuevoInterfaz
    {

       
        public void darAltaCliente(List<ClientesDto> listaAntigua)

        /// <summary>
        /// Implementación donde se pondrán los datos del usuario y lo añadirá a la lista.
        /// 171123 - chi
        /// </summary>
        {
            ClientesDto clienteNuevo = new ClientesDto();

            Console.WriteLine("Datos del usuario");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            nombre = clienteNuevo.NombreCliente;
            Console.WriteLine("Apellidos: ");
            string apellidos = Console.ReadLine();
            apellidos = clienteNuevo.ApellidosCliente;
            Console.WriteLine("DNI: ");
            string DNI = Console.ReadLine();
            DNI = clienteNuevo.DniCliente;
            Console.WriteLine("Fecha de nacimiento: ");
            string fechaNacimiento = Console.ReadLine();
            fechaNacimiento = clienteNuevo.FchNacimientoCliente; 
            Console.WriteLine("email: ");
            string email = Console.ReadLine();
            email = clienteNuevo.EmailCliente;
            Console.WriteLine("Tlf: ");
            int tlf = Convert.ToInt32(Console.ReadLine());
            tlf = clienteNuevo.TlfCliente;
            Console.WriteLine("Fecha de Alta: ");
            string fechaAlta = Console.ReadLine();
            fechaAlta = clienteNuevo.FchBajaCliente;
            listaAntigua.Add(clienteNuevo);




        }



    }
}
