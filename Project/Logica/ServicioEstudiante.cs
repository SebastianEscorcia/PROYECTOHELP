using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logica
{
    public interface IServicioEstudiante
    {
        Estudiante CrearEstudiante(Estudiante estudiante);

    }

    public class ServicioEstudiante : IServicioEstudiante
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public ServicioEstudiante()
        {
        }
        public Estudiante CrearEstudiante(Estudiante estudiante)
        {
            try
            {


                return estudiante;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
