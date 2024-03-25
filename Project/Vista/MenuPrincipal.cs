using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Vista
{
    public class MenuPrincipal
    {
        GUICrearEstudiante MenuEstudiante = new GUICrearEstudiante();
        GUICrearGrupo MenuGrupo = new GUICrearGrupo();
        int op;
        public void MenuP()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("LOGICA DE CONJUNTOS");
                Console.WriteLine("1.Crear Grupo");
                Console.WriteLine("2.Crear Estudiante");
                Console.WriteLine("3.Agregrar Estudiante a un Grupo");
                Console.WriteLine("4.Operaciones entre conjuntos");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Digita una opción:");
                op = int.Parse((Console.ReadLine()));
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        MenuGrupo.CrearGrupo();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        MenuEstudiante.CrearEstudiante();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Digite una opción valida");
                        break;
                }
            } while (op != 5);
        }

    }
}
