using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTriangulo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Triángulos();
            formulario2.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En proceso");
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formulario2 = new Triángulos();
            formulario2.Close();
            Application.Exit();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
