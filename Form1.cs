using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasConArreglos
{
    public partial class Form1 : Form
    {

        Carro n = new Carro();
        CarroIniciar a;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new CarroIniciar();
            a.placa_1 = txtPlaca1.Text;
            a.marca_1 = txtMarca1.Text;
            a.modelo_1 = txtModelo.Text;
            a.telefono_1 = txtTelefono.Text;
            a.ano_1 = txtaño.Text;
            n.agregar(a);
            if (n.i < n.t)
            {
                MessageBox.Show("Agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el limite de registros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtPlaca1.Clear();
            txtMarca1.Clear();
            txtModelo.Clear();
            txtTelefono.Clear();
            txtaño.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtResultado.Text = n.listar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            a.placa_1 = txtPlaca1.Text;
            a.marca_1 = txtMarca1.Text;
            a.modelo_1 = txtModelo.Text;
            a.telefono_1 = txtTelefono.Text;
            a.ano_1 = txtaño.Text;
            MessageBox.Show("Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

     

        private void txtano_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.placa_1 = txtBPlaca.Text;
            if (n.buscar(a.placa_1) == null)
            {
              

                

                MessageBox.Show("No encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtResultado.Text = n.buscar(a.placa_1).placa_1 + " " + n.buscar(a.placa_1).modelo_1 + " " + n.buscar(a.placa_1).marca_1 + " " + n.buscar(a.placa_1).telefono_1 + " " + n.buscar(a.placa_1).ano_1;

                MessageBox.Show("Encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
