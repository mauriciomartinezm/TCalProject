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
    public partial class Triángulos : Form
    {
        public Triángulos()
        {
            InitializeComponent();
        }

        private void calcularhipotenusa_Click(object sender, EventArgs e)
        {
            try
            {
                double c, b, h, angulob, anguloc, angulobradian, angulocradian;
                c = double.Parse(valorcatetoc.Text);
                b = double.Parse(valorcatetob.Text);
                angulob = double.Parse(valorangulob.Text);
                anguloc = double.Parse(valoranguloc.Text);
                angulobradian = angulob * Math.PI / 180;
                angulocradian = anguloc * Math.PI / 180;

                if (c > 0 && b > 0)
                {
                    h = Math.Sqrt((c * c) + (b * b));

                    valorhipotenusa.Text = Math.Round(h, 2).ToString();
                }
                else if (anguloc > 0 && c > 0)
                {
                    h =  c / Math.Sin(angulocradian);
                    valorhipotenusa.Text = Math.Round(h, 2).ToString();
                }
                else if (anguloc > 0 && b > 0)
                {

                    h = b / Math.Cos(angulocradian);
                    valorhipotenusa.Text = Math.Round(h, 2).ToString();
                }
                else if (angulob > 0 && b > 0)
                {
                    h = b / Math.Sin(angulobradian);
                    valorhipotenusa.Text = Math.Round(h, 2).ToString();
                }
                else if (angulob > 0 && c > 0)
                {
                    h = c / Math.Cos(angulobradian);
                    valorhipotenusa.Text = Math.Round(h, 2).ToString();
                }
                else
                {
                    MessageBox.Show("No hay suficientes valores");
                }
            }
            catch (System.FormatException x)
            {
                MessageBox.Show("Error, por favor ingrese un dato válido, información del error : " + x);
            }
        }

        private void calcularc_Click(object sender, EventArgs e)
        {
            try
            {
                double c, b, h, angulob, anguloc, angulobradian, angulocradian;
                h = double.Parse(valorhipotenusa.Text);
                b = double.Parse(valorcatetob.Text);
                angulob = double.Parse(valorangulob.Text);
                anguloc = double.Parse(valoranguloc.Text);
                angulobradian = angulob * Math.PI / 180;
                angulocradian = anguloc * Math.PI / 180;


                if (h > 0 && b > 0)
                {
                    c = Math.Sqrt((h * h) - (b * b));

                    valorcatetoc.Text = Math.Round(c, 2).ToString();
                }
                else if (anguloc > 0 && h > 0)
                {
                    c = h * Math.Sin(angulocradian);
                    valorcatetoc.Text = Math.Round(c, 2).ToString();
                }
                else if (anguloc > 0 && b > 0)
                {

                    c = b * Math.Tan(angulocradian);
                    valorcatetoc.Text = Math.Round(c, 2).ToString();
                }
                else if (angulob > 0 && h > 0)
                {
                    c = h * Math.Cos(angulobradian);
                    valorcatetoc.Text = Math.Round(c, 2).ToString();
                }
                else if (angulob > 0 && b > 0)
                {
                    c = b / Math.Tan(angulobradian);
                    valorcatetoc.Text = Math.Round(c, 2).ToString();
                }
                else
                {
                    MessageBox.Show("No hay suficientes valores");
                }

            }
            catch (System.FormatException x)
            {
                MessageBox.Show("Error, por favor ingrese un dato válido, información del error : " + x);
            }
        }

        private void calcularb_Click(object sender, EventArgs e)
        {
            try
            {
                double c, b, h, angulob, anguloc, angulobradian, angulocradian;
                angulob = double.Parse(valorangulob.Text);
                anguloc = double.Parse(valoranguloc.Text);
                h = double.Parse(valorhipotenusa.Text);
                c = double.Parse(valorcatetoc.Text);
                angulobradian = angulob * Math.PI / 180;
                angulocradian = anguloc * Math.PI / 180;

                if (h > 0 && c > 0)
                {
                    b = Math.Sqrt((h * h) - (c * c));

                    valorcatetob.Text = Math.Round(b, 2).ToString();
                }
                else if (angulob > 0 && h > 0)
                {
                    b = h * Math.Sin(angulobradian);
                    valorcatetob.Text = Math.Round(b, 2).ToString();
                }
                else if (angulob > 0 && c > 0)
                {
                    b = c * Math.Tan(angulobradian);
                    valorcatetob.Text = Math.Round(b, 2).ToString();
                }
                else if (anguloc > 0 && h > 0)
                {
                    b = h * Math.Cos(angulocradian);
                    valorcatetob.Text = Math.Round(b, 2).ToString();
                }
                else if (anguloc > 0 && c > 0)
                {
                    b = c / Math.Tan(angulocradian);
                    valorcatetob.Text = Math.Round(b, 2).ToString();
                }
                else
                {
                    MessageBox.Show("No hay suficientes valores");
                }
            }
            catch (System.FormatException x)
            {
                MessageBox.Show("Error, por favor ingrese un dato válido, información del error : " + x);
            }
        }
        private void calcularab_Click(object sender, EventArgs e)
        {
            try
            {
                double anguloa, angulob, anguloc, h, b, c;
                anguloa = double.Parse(valoranguloa.Text);
                anguloc = double.Parse(valoranguloc.Text);
                h = double.Parse(valorhipotenusa.Text);
                b = double.Parse(valorcatetob.Text);
                c = double.Parse(valorcatetoc.Text);
                if (anguloc > 0 && anguloa + anguloc < 180)
                {
                    angulob = 180 - (anguloa + anguloc);
                    valorangulob.Text = Math.Round(angulob, 2).ToString();
                }
                else if(anguloc > 89)
                {
                    MessageBox.Show("Imposible hacer la operación, la suma de los otros 2 angulos es superior o igual a 180°");
                }
                else if (b > 0 && h > 0)
                {
                    angulob = Math.Asin(b / h);
                    angulob = angulob * 180 / Math.PI;
                    valorangulob.Text = Math.Round(angulob, 2).ToString();
                }
                else if (c > 0 && h > 0)
                {
                    angulob = Math.Acos(c / h);
                    angulob = angulob * 180 / Math.PI;
                    valorangulob.Text = Math.Round(angulob, 2).ToString();
                }
                else if (c > 0 && b > 00)
                {
                    angulob = Math.Atan(b / c);
                    angulob = angulob * 180 / Math.PI;
                    valorangulob.Text = Math.Round(angulob, 2).ToString();
                }
                else
                {
                    MessageBox.Show("No hay suficientes valores");
                }
            }
            catch (System.FormatException x)
            {
                MessageBox.Show("Error, por favor ingrese un dato válido, información del error: " + x);
            }
        }

        private void calcularac_Click(object sender, EventArgs e)
        {
            try
            {
                double anguloa, angulob, anguloc, c, h, b;
                angulob = double.Parse(valorangulob.Text);
                anguloa = double.Parse(valoranguloa.Text);
                h = double.Parse(valorhipotenusa.Text);
                b = double.Parse(valorcatetob.Text);
                c = double.Parse(valorcatetoc.Text);
                if (angulob > 0 && angulob + anguloa < 180)
                {
                    anguloc = 180 - (angulob + anguloa);
                    valoranguloc.Text = Math.Round(anguloc, 2).ToString();
                }
                else if (angulob > 89)
                {
                    MessageBox.Show("Imposible hacer la operación, no colocaste el valor del otro ángulo, o la suma de los otros 2 angulos es superior o igual a 180°");
                }
                else if (c > 0 && h > 0)
                {
                    anguloc = Math.Asin(c / h);
                    anguloc = anguloc * 180 / Math.PI;
                    valoranguloc.Text = Math.Round(anguloc, 2).ToString();
                }
                else if (b > 0 && h > 0)
                {
                    anguloc = Math.Acos(b / h);
                    anguloc = anguloc * 180 / Math.PI;
                    valoranguloc.Text = Math.Round(anguloc, 2).ToString();
                }
                else if (c > 0 && b > 00)
                {
                    anguloc = Math.Atan(c / b);
                    anguloc = anguloc * 180 / Math.PI;
                    valoranguloc.Text = Math.Round(anguloc, 2).ToString();
                }
                else
                {
                    MessageBox.Show("No hay suficientes valores");
                }
            }
            catch (System.FormatException x)
            {
                MessageBox.Show("Error, por favor ingrese un dato válido, información del error: " + x);
            }
        }

        private void calculartodo_Click(object sender, EventArgs e)
        {
            double c = 0, b = 0, h = 0, A, anguloa, angulob, anguloc, angulobradian, angulocradian;
            c = double.Parse(valorcatetoc.Text);
            b = double.Parse(valorcatetob.Text);
            h = double.Parse(valorhipotenusa.Text);
            anguloa = 90;
            angulob = double.Parse(valorangulob.Text);
            anguloc = double.Parse(valoranguloc.Text);
            angulobradian = angulob * Math.PI / 180;
            angulocradian = anguloc * Math.PI / 180;
            if (c > 0 && b > 0)
            {
                h = Math.Sqrt((c * c) + (b * b));

                valorhipotenusa.Text = Math.Round(h, 2).ToString();
            }
            else if (anguloc > 0 && c > 0)
            {
                h = c / Math.Sin(angulocradian);
                valorhipotenusa.Text = Math.Round(h, 2).ToString();
            }
            else if (anguloc > 0 && b > 0)
            {

                h = b / Math.Cos(angulocradian);
                valorhipotenusa.Text = Math.Round(h, 2).ToString();
            }
            else if (angulob > 0 && b > 0)
            {
                h = b / Math.Sin(angulobradian);
                valorhipotenusa.Text = Math.Round(h, 2).ToString();
            }
            else if (angulob > 0 && c > 0)
            {
                h = c / Math.Cos(angulobradian);
                valorhipotenusa.Text = Math.Round(h, 2).ToString();
            }
            if (h > 0 && b > 0)
            {
                c = Math.Sqrt((h * h) - (b * b));

                valorcatetoc.Text = Math.Round(c, 2).ToString();
            }
            else if (anguloc > 0 && h > 0)
            {
                c = h * Math.Sin(angulocradian);
                valorcatetoc.Text = Math.Round(c, 2).ToString();
            }
            else if (anguloc > 0 && b > 0)
            {

                c = b * Math.Tan(angulocradian);
                valorcatetoc.Text = Math.Round(c, 2).ToString();
            }
            else if (angulob > 0 && h > 0)
            {
                c = h * Math.Cos(angulobradian);
                valorcatetoc.Text = Math.Round(c, 2).ToString();
            }
            else if (angulob > 0 && b > 0)
            {
                c = b / Math.Tan(angulobradian);
                valorcatetoc.Text = Math.Round(c, 2).ToString();
            }
            if (h > 0 && c > 0)
            {
                b = Math.Sqrt((h * h) - (c * c));

                valorcatetob.Text = Math.Round(b, 2).ToString();
            }
            else if (angulob > 0 && h > 0)
            {
                b = h * Math.Sin(angulobradian);
                valorcatetob.Text = Math.Round(b, 2).ToString();
            }
            else if (angulob > 0 && c > 0)
            {
                b = c * Math.Tan(angulobradian);
                valorcatetob.Text = Math.Round(b, 2).ToString();
            }
            else if (anguloc > 0 && h > 0)
            {
                b = h * Math.Cos(angulocradian);
                valorcatetob.Text = Math.Round(b, 2).ToString();
            }
            else if (anguloc > 0 && c > 0)
            {
                b = c / Math.Tan(angulocradian);
                valorcatetob.Text = Math.Round(b, 2).ToString();
            }
            if (anguloc > 0 && anguloa + anguloc < 180)
            {
                angulob = 180 - (anguloa + anguloc);
                valorangulob.Text = Math.Round(angulob, 2).ToString();
            }
            else if (anguloc > 89)
            {
                MessageBox.Show("Imposible hacer la operación, la suma de los otros 2 angulos es superior o igual a 180°");
            }
            else if (b > 0 && h > 0)
            {
                angulob = Math.Asin(b / h);
                angulob = angulob * 180 / Math.PI;
                valorangulob.Text = Math.Round(angulob, 2).ToString();
            }
            else if (c > 0 && h > 0)
            {
                angulob = Math.Acos(c / h);
                angulob = angulob * 180 / Math.PI;
                valorangulob.Text = Math.Round(angulob, 2).ToString();
            }
            else if (c > 0 && b > 00)
            {
                angulob = Math.Atan(b / c);
                angulob = angulob * 180 / Math.PI;
                valorangulob.Text = Math.Round(angulob, 2).ToString();
            }
            if (angulob > 0 && angulob + anguloa < 180)
            {
                anguloc = 180 - (angulob + anguloa);
                valoranguloc.Text = Math.Round(anguloc, 2).ToString();
            }
            else if (angulob > 89)
            {
                MessageBox.Show("Imposible hacer la operación, no colocaste el valor del otro ángulo, o la suma de los otros 2 angulos es superior o igual a 180°");
            }
            else if (c > 0 && h > 0)
            {
                anguloc = Math.Asin(c / h);
                anguloc = anguloc * 180 / Math.PI;
                valoranguloc.Text = Math.Round(anguloc, 2).ToString();
            }
            else if (b > 0 && h > 0)
            {
                anguloc = Math.Acos(b / h);
                anguloc = anguloc * 180 / Math.PI;
                valoranguloc.Text = Math.Round(anguloc, 2).ToString();
            }
            else if (c > 0 && b > 00)
            {
                anguloc = Math.Atan(c / b);
                anguloc = anguloc * 180 / Math.PI;
                valoranguloc.Text = Math.Round(anguloc, 2).ToString();
            }
            A = (b * c) / 2;
            valorarea.Text = Math.Round(A, 2).ToString();

        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            double c = 0, b =0, h= 0, A=0, angulob=0, anguloc=0;
            valorcatetob.Text = b.ToString();
            valorcatetoc.Text = c.ToString();
            valorhipotenusa.Text = h.ToString();
            valorangulob.Text = angulob.ToString();
            valoranguloc.Text = anguloc.ToString();
            valorarea.Text = A.ToString();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void calculararea_Click(object sender, EventArgs e)
        {
            double A, b, c;
            c = double.Parse(valorcatetoc.Text);
            b = double.Parse(valorcatetob.Text);
            A = (b * c) / 2;
            valorarea.Text = Math.Round(A, 2).ToString();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Triángulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formulario1 = new Inicio();
            formulario1.Show();
            this.Hide();    
        }
    }
}