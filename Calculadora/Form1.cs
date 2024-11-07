using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario;
            double bono = 0;
            double retencion = 0;
            double total = 0;
            double porcentajeBono = 0;

            salario = Convert.ToDouble(textBox2.Text);

            if (radioButton1.Checked)
            {
                porcentajeBono = 0.10;
            }
            else if (radioButton2.Checked)
            {
                porcentajeBono = 0.20;
            }
            else if (radioButton3.Checked)
            {
                porcentajeBono = 0.35;
            }

            bono = salario * porcentajeBono;

            if (salario >= 10000)
            {
                retencion = salario * 0.05;
            }

            total = salario + bono - retencion;
            textBox3.Text = bono.ToString();
            textBox4.Text = retencion.ToString();
            textBox5.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = "Yader Vicente Garcia Bravo";
            string fecha = "07/11/2024";
            MessageBox.Show(string.Format("Nombre: {0} \nFecha: {1}", nombre, fecha), "Salir");
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
