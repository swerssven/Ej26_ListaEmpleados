using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Ej26_ListaEmpleados
{
    public partial class Form1 : Form
    {
        public static ArrayList listaEmpleados = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Anyadir2_Click(object sender, EventArgs e)
        {
            CreacionEmpleado c = new CreacionEmpleado();
            AddOwnedForm(c);
            c.Show();
            c.Focus();
        }

        private void View_Empleados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (Empleados x in listaEmpleados)
            {
                if (View_Empleados.SelectedItems.Count > 0 && View_Empleados.SelectedItems[0].Text.Equals(x.Nombre + " " + x.Apellidos))
                {
                    txt_Informacion.Text = x.informacion();
                }
            }
        }

        private void btn_Eliminar2_Click(object sender, EventArgs e)
        {
            Empleados aux = null;
            foreach (Empleados x in listaEmpleados)
            {
                if (View_Empleados.SelectedItems.Count > 0 && View_Empleados.SelectedItems[0].Text.Equals(x.Nombre + " " + x.Apellidos))
                {
                    aux = x;
                    View_Empleados.SelectedItems[0].Remove();
                    txt_Informacion.Text = String.Empty;
                }
            }

            if (aux != null)
            {
                listaEmpleados.Remove(aux);
            }
        }
    }
}
