using Project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logica
{
    public class ServicioGrupo : IcrudGrupo<Grupo>
    {
        List<Grupo> grupos = new List<Grupo>();
        public string AgregarEstudiante(List<Grupo> M, List<Grupo> N, Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public string CrearGrupo(Grupo Grupo)
        {
            try
            {
                grupos.Add(Grupo);
                return $"Se agregó correctamente el grupo {Grupo.Nombre}";
            }
            catch (Exception)
            {

                return "No se pudo crear el grupo";
            }
        }

        public List<Grupo> Grupos()
        {
            throw new NotImplementedException();
        }
    }
}
