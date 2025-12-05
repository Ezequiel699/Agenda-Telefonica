using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agenda Telefônica");
            Dictionary<string, string> Agenda = new Dictionary<string,string>()
            {
                {"Alex", "8496333021" },
                {"Juan", "8496333021" },
                {"Ezequiel", "8496333021" },
                {"Pedro", "8496333021" },
                {"Jose", "8496333021" },
                {"Maria", "8496333021" },
                {"Carmen", "8496333021" },
                {"Simom", "8496333021" }

            };
            while (true)
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Agendar contacto");
                Console.WriteLine("2.Buscar cotacto por nombre");
                Console.WriteLine("3. Listar todos");
                Console.WriteLine("4.Borrar un contacto");
                Console.WriteLine("5.Salir");
                Console.Write("Que desear hacer el dia de hoy? ");
                string eleccionUsuario = Console.ReadLine();


                if (eleccionUsuario == "1")
                {
                    Console.Write("Ingrese el nombre del contacto: ");
                    string nombreContacto = Console.ReadLine();
                    Console.Write("Ingrese el número de teléfono del contacto: ");
                    string numeroTelefono = Console.ReadLine();
                    Agenda[nombreContacto] = numeroTelefono;
                    Console.WriteLine("Contacto agregado exitosamente.");
                }
                else if (eleccionUsuario == "2")
                {
                    if (Agenda.Count == 0)
                    {
                        Console.WriteLine("La agenda esta vacia");
                    }
                    else
                    {
                        Console.Write("Ingrese el nombre del contacto a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        if (Agenda.ContainsKey(nombreBuscar))
                        {
                            Console.WriteLine("Contacto encontrado: " + nombreBuscar + " - " + Agenda[nombreBuscar]);
                        }
                        else
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }
                    }


                }
                else if (eleccionUsuario == "3")
                {
                    foreach (var contacto in Agenda)
                    {
                        Console.WriteLine("Nombre: " + contacto.Key + ", Teléfono: " + contacto.Value);
                    }
                }
                else if (eleccionUsuario == "4")
                {
                    Console.Write("Ingrese el nombre del contacto a borrar: ");
                    string nombreBorrar = Console.ReadLine();

                    if (Agenda.ContainsKey(nombreBorrar))
                    {
                        Agenda.Remove(nombreBorrar);
                        Console.WriteLine("Contacto borrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Contacto no encontrado.");
                    }
                }
                else if (eleccionUsuario == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                }


            }

        }
    }
}
