using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entidades
{
    public class Grupo
    {
        public List<Estudiante> estudiantes;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Grupo()
        {

        }
        public Grupo(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}

