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
        Grupo grupo = new Grupo();  
        public void CrearGrupo()
        {
            string nombre;
            string id;
            Console.Clear();
            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();
            grupo.Nombre = nombre;
            Console.WriteLine("ID:");
            id = Console.ReadLine();
            grupo.Id = id;
            var mensaje = servicioGrupo.CrearGrupo(grupo);
            Console.WriteLine(mensaje);
        }
    }
}
