using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logica
{
    public class ServicioEstudiante : IcrudEstudiante<Estudiante>
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public ServicioEstudiante()
        {
        }
        public string CrearEstudiante(Estudiante estudiante)
        {
            try
            {

                estudiantes.Add(estudiante);
                return $" Se Registro el estudiante {estudiante.Nombre}";
            }
            catch (Exception)
            {

                return "Error al crear el estudiante";
            }
        }
    }
}
