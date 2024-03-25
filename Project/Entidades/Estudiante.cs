﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entidades
{
    public class Estudiante
    {
        public int Edad {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public double Promeido { get; set; }
        public Estudiante() { }
        public Estudiante(string nombre, string apellido, char sexo, double promedio, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Promeido = promedio;
            Edad = edad;
        }
    }
}
