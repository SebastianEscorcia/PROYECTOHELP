using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logica
{
    public interface IcrudGrupo <T>
    {
        string CrearGrupo(T Grupo);
        string AgregarEstudiante(List<T> M, List<T> N, Estudiante estudiante);
        List<T> Grupos();
    }
}
