using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            if (TextBox_Nombre.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Falta nombre", MessageBoxButtons.OK);
            }
            else if (TextBox_Correo.Text.Equals("") || TextBox_Telefono.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el telefono o correo del cliente.", "Falta contacto", MessageBoxButtons.OK);
            }
            else if (SistemasOperativos.SelectedItem==null) 
            {
                MessageBox.Show("Debe seleccionar un sistema operativo para el cliente.", "Falta sistema operativo", MessageBoxButtons.OK);
            } 
            else {
                String texto = "Cliente: " + TextBox_Nombre.Text+"\n";
                if (!TextBox_Correo.Text.Equals("")) texto += "Correo: " + TextBox_Correo.Text+"\n";
                if (!TextBox_Telefono.Text.Equals("")) texto += "Telefono: " + TextBox_Telefono.Text + "\n";
                texto += "Compra: \n";
                foreach (RadioButton one in Procesadores.Controls) {
                    if (one.Checked) {
                        texto += "Procesador: " + one.Text+"\n";
                        break;
                    }
                }
                foreach (RadioButton two in Ram.Controls) {
                    if (two.Checked) {
                        texto += "Ram: " + two.Text + "\n";
                        break;
                    }
                }
                texto += "Sistema operativo: " + SistemasOperativos.SelectedItem + "\n";
                foreach (CheckBox three in DiscoDuro.Controls) {
                    if (three.Checked) {
                        texto += "Almacenamiento: " + three.Text + "\n";
                    }
                }
                foreach (CheckBox four in Extra.Controls) {
                    if (four.Checked) {
                        texto += "Extra: " + four.Text + "\n";
                    }
                }
                Ticket.Text = texto;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir y cancelar la operacion?", "Cancelar operacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LimpiarCampos_Click_1(object sender, EventArgs e)
        {
            switch (Formulario.SelectedIndex) {
                case 0:
                    TextBox_Nombre.Clear();
                    TextBox_Correo.Clear();
                    TextBox_Telefono.Clear();
                    break;
                case 1:
                    foreach (Control a in ProcesadorMemoria.Controls) {
                        if (a is GroupBox) {
                            GroupBox b = (GroupBox)a;
                            foreach (RadioButton c in b.Controls) {
                                c.Checked = false;
                            }
                        }
                    }
                    break;
                case 2:
                    SistemasOperativos.ClearSelected();
                    foreach (CheckBox x in DiscoDuro.Controls) {
                        x.Checked = false;
                    }
                    break;
                case 3:
                    foreach (CheckBox y in Extra.Controls) {
                        y.Checked = false;
                    }
                    break;
            }
        }
    }
}
