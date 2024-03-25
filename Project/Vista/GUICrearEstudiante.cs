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
        
        public void CrearEstudiante()
        {
            string nombre;
            string apellido;
            char sexo;
            double promedio;
            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            apellido = Console.ReadLine();
            do
            {
                Console.WriteLine("Sexo (M/F):");
                string input = Console.ReadLine();

                if (input.Length == 1 && char.TryParse(input, out sexo))
                {
                    sexo = char.ToUpper(sexo); 
                    if (sexo == 'M' || sexo == 'F')
                    {
                        break; 
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("¡Debes ingresar solo un carácter!");
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (true);
            estudiante.Sexo = sexo;
            Console.WriteLine("Promedio:");
            promedio = double.Parse(Console.ReadLine());
            var mensaje = servicio.CrearEstudiante(estudiante);
            Console.WriteLine(mensaje);
        }
    }
}
