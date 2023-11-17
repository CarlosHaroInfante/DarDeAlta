using DarDeAlta.Servicios;
using DarDeAlta.Dtos;
namespace DarDeAlta
{
    /// <summary>
    /// Clase principal del programa donde se encontrará nuestro método Main.
    /// 171123 - chi
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main donde se encontrará la llamada a métodos y el bucle donde el usuario elegirá una opción del menú.
        /// 171123 - chi
        /// </summary>
        
        static void Main(string[] args)
        {

            List<ClientesDto> listaClientes = new List<ClientesDto>(); //LLamada al método de clientesDto y le hacemos  una copia.
            
            MenuInterfaz menu = new MenuImplementacion(); //Creo una copua menú menú
              
            NuevoInterfaz banco = new NuevoImplementacion(); //Creo la copia donde el usuario rellenará con sus datos.
            bool cerrarMenu = false; //Menú iniciado en falso
            
            while (!cerrarMenu) //Le ponemos el simbolo ! para cambiar a true.
            {
                int opcionElegida = menu.menu(); //Llamada al método

                switch (opcionElegida)
                {

                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Darse de Alta en el Banco");
                        banco.darAltaCliente(listaClientes); //El método banco en el que está darAltaCliente
                        break;
                    case 2:
                        Console.WriteLine("[INFO - Ninguna opcion valida]");
                        break;

                }
            }
        }
    }
}
