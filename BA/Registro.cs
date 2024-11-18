using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Registro


    {
        public string Matricula { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string  Carrera{ get; set; }


        public Registro(string matricula,
            string apellido,
            string nombre,
            string carrera)

        {
            Matricula = matricula;
            Apellido = apellido;
            Nombre = nombre;
            Carrera = carrera;
        }
       
    }


    
}
