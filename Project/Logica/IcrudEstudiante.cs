using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logica
{
    public interface IcrudEstudiante <T>
    {
        string CrearEstudiante(Estudiante estudiante);
     
    }
}
