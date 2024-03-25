using Project.Entidades;
using Project.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        private Grupo M;
        private Grupo N;
        private static List<Grupo> Grupos;

        static void Main(string[] args)
        {
            var grupo1 = new Grupo(1, "Grupo 1");
            Grupos.Add(grupo1);
            var grupo2 = new Grupo(1, "Grupo 2");
            Grupos.Add(grupo2);



            MenuPrincipal menu = new MenuPrincipal();
            menu.MenuP();
        }



    }
}
