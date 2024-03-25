using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entidades
{
    public class Grupo
    {
        private List<Estudiante> estudiantes;
        private int id;
        private string nombre;

        public Grupo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.estudiantes = null;
        }


        public List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

