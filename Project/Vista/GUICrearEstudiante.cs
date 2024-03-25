using Project.Entidades;
using Project.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Vista
{
    public class GUICrearEstudiante
    {
        ServicioEstudiante servicio = new ServicioEstudiante();
        Estudiante estudiante = new Estudiante();

        public Estudiante CrearEstudiante()
        {

            try
            {
                var estudiante = new Estudiante();

                Console.WriteLine("Nombre:");
                estudiante.Nombre = Console.ReadLine();
                Console.WriteLine("Apellido:");
                estudiante.Apellido = Console.ReadLine();
                var condicional = true;
                do
                {
                    Console.WriteLine("Sexo (M/F):");
                    estudiante.Sexo = Console.ReadLine().ToUpper();

                    if (estudiante.Sexo.Trim() != "")
                    {

                        if (estudiante.Sexo == "M" || estudiante.Sexo == "F")
                        {
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            condicional = false;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("¡Debes ingresar solo un carácter!");
                    }

                } while (condicional);
                Console.WriteLine("Edad:");
                estudiante.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Promedio:");
                estudiante.Promedio = double.Parse(Console.ReadLine());
                var mensaje = servicio.CrearEstudiante(estudiante);
                return mensaje;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se logro retornar al estudiante");
                return null;
            }
        }
    }
}
