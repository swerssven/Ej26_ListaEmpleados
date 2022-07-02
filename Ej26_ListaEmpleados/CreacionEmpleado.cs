using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ej26_ListaEmpleados
{
    public partial class CreacionEmpleado : Form
    {
        
        public CreacionEmpleado()
        {
            InitializeComponent();
        }

        private void lst_TiposEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (lst_TiposEmpleados.SelectedItem.Equals("Becario"))
            {
                mostrarCampos("Carrera:", "Curso:", "Departamento:");
            }
            else if (lst_TiposEmpleados.SelectedItem.Equals("Cualificado"))
            {
                mostrarCampos("Titulación:", "Plus:", "Departamento:");
            }
            else if (lst_TiposEmpleados.SelectedItem.Equals("Jefe Cualificado"))
            {
                mostrarCampos("Titulación:", "Plus:", "Departamento:");
                lbl_jefe1.Show();
                lbl_jefe2.Show();
                lbl_jefe1.Text = "Cargo:";
                lbl_jefe2.Text = "Proyecto:";
                txt_jefe1.Show();
                txt_jefe2.Show();
            }
            else if (lst_TiposEmpleados.SelectedItem.Equals("Obrero"))
            {
                mostrarCampos("Horas Extra: ", "Precio HE: ", "Destino: ");
            }
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Form1 fPadre = Owner as Form1;
            try
            {
                if (lst_TiposEmpleados.SelectedItem != null && lst_TiposEmpleados.SelectedItem.Equals("Becario"))
                {
                    Becarios b = new Becarios(txt_Nombre.Text, txt_Apellidos.Text, Double.Parse(txt_Sueldo_Base.Text.Replace(",",".")),
                        txt_Dni.Text, txt_aux1.Text, txt_aux2.Text, txt_aux3.Text);
                    Form1.listaEmpleados.Add(b);

                    fPadre.View_Empleados.Items.Add(b.Nombre + " " + b.Apellidos);
                }
                else if (lst_TiposEmpleados.SelectedItem != null && lst_TiposEmpleados.SelectedItem.Equals("Cualificado"))
                {
                    Cualificados c = new Cualificados(txt_Nombre.Text, txt_Apellidos.Text, Double.Parse(txt_Sueldo_Base.Text.Replace(",", ".")),
                        txt_Dni.Text, txt_aux1.Text, Double.Parse(txt_aux2.Text.Replace(",", ".")), txt_aux3.Text);
                    Form1.listaEmpleados.Add(c);

                    fPadre.View_Empleados.Items.Add(c.Nombre + " " + c.Apellidos);
                }
                else if (lst_TiposEmpleados.SelectedItem != null && lst_TiposEmpleados.SelectedItem.Equals("Jefe Cualificado"))
                {
                    JefeDepart j = new JefeDepart(txt_Nombre.Text, txt_Apellidos.Text, Double.Parse(txt_Sueldo_Base.Text.Replace(",", ".")),
                        txt_Dni.Text, txt_aux1.Text, Double.Parse(txt_aux2.Text.Replace(",", ".")), txt_aux3.Text, txt_jefe1.Text, txt_jefe2.Text);
                    Form1.listaEmpleados.Add(j);

                    fPadre.View_Empleados.Items.Add(j.Nombre + " " + j.Apellidos);
                }
                else if (lst_TiposEmpleados.SelectedItem != null && lst_TiposEmpleados.SelectedItem.Equals("Obrero"))
                {
                    Obreros o = new Obreros(txt_Nombre.Text, txt_Apellidos.Text, Double.Parse(txt_Sueldo_Base.Text.Replace(",", ".")),
                        txt_Dni.Text, Int32.Parse(txt_aux1.Text), Double.Parse(txt_aux2.Text.Replace(",", ".")), txt_aux3.Text);
                    Form1.listaEmpleados.Add(o);

                    fPadre.View_Empleados.Items.Add(o.Nombre + " " + o.Apellidos);
                }
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error + "Intente de nuevo, rellene los campos correctamente");
            }
        }

        private void limpiarCampos()
        {
            lbl_aux1.Hide();
            lbl_aux2.Hide();
            lbl_aux3.Hide();
            lbl_jefe1.Hide();
            lbl_jefe2.Hide();
            txt_aux1.Hide();
            txt_aux2.Hide();
            txt_aux3.Hide();
            txt_jefe1.Hide();
            txt_jefe2.Hide();
            txt_aux1.Text = String.Empty;
            txt_aux2.Text = String.Empty;
            txt_aux3.Text = String.Empty;
            txt_jefe1.Text = String.Empty;
            txt_jefe2.Text = String.Empty;
        }

        private void mostrarCampos(String aux1, String aux2, String aux3)
        {
            lbl_aux1.Show();
            lbl_aux2.Show();
            lbl_aux3.Show();
            lbl_aux1.Text = aux1;
            lbl_aux2.Text = aux2;
            lbl_aux3.Text = aux3;
            txt_aux1.Show();
            txt_aux2.Show();
            txt_aux3.Show();
        }
    }
}
