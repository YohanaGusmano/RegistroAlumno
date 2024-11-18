using BA;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RegistroAlumno.FE
{
    public partial class FrmABMRegistros : Form

    {
        private Registros Registros = new Registros();

        public FrmABMRegistros()
        {
            InitializeComponent();

            DGV.DataSource = Registros.Lista;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro(txtMatricula.Text,
                                             txtApellido.Text,
                                             txtNombre.Text,
                                             txtCarrera.Text);

            Registros.Insert (Registro);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DGV.Rows.Remove(row);
                    }
                }
            }
        }
    }
}
