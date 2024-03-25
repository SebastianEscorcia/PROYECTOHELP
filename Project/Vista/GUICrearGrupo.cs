using Project.Entidades;
using Project.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Vista
{
    public class GUICrearGrupo
    {
        ServicioGrupo servicioGrupo = new ServicioGrupo();
        static Grupo grupo;
        public void CrearGrupo()
        {
            string nombre;
            int id;
            Console.Clear();
            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();
            grupo.Nombre = nombre;
            Console.WriteLine("ID:");
            id = Convert.ToInt32(Console.ReadLine());
            grupo.Id = id;
            var mensaje = servicioGrupo.CrearGrupo(grupo);
            Console.WriteLine(mensaje);
        }
    }
}
