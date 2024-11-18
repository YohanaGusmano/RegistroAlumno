using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Registros
    {
        public DataTable Lista { get; set; } 


        public Registros()

        {
            Lista = new DataTable();
            Lista.TableName = "Registro";
            Lista.Columns.Add("Matricula");
            Lista.Columns.Add("Apellido");
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Carrera");

            LeerArchivo();



        }

        private void LeerArchivo()
        { 
         if (System.IO.File.Exists("Registros.xml"))

            {
                Lista.ReadXml("Registros.xml");
            }
        }

        public void Insert(Registro Registro)

        {
            Lista.Rows.Add(); 
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Matricula"] = Registro.Matricula;
            Lista.Rows[NuevoRenglon]["Apellido"] = Registro.Apellido;
            Lista.Rows[NuevoRenglon]["Nombre"] = Registro.Nombre;
            Lista.Rows[NuevoRenglon]["Matricula"] = Registro.Matricula;


            Lista.WriteXml("Registros.xml");

        }
    }

}   

