using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entidades
{
    public class Estudiante
    {
        private int edad;
        private string nombre;
        private string apellido;
        private string sexo;
        private double promedio;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Promedio { get => promedio; set => promedio = value; }
    }
}
