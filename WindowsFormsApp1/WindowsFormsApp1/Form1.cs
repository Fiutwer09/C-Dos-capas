using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;
            string condicion;

            nota_1 = double.Parse(txtnota1.Text);
            nota_2 = double.Parse(txtnota2.Text);
            nota_3 = double.Parse(txtnota3.Text);

            promedio=(nota_1+nota_2+nota_3)/3;

            if (promedio < 3)
            {
                condicion = "DESAPROBADO";
                txtpromedio.Text = promedio .ToString("N1");
                txtcondicion.Text = condicion ;
            }else if (promedio >= 3 && promedio<= 5) 
            {
                condicion = "APROBADO";
                txtpromedio.Text = promedio.ToString("N1");
                txtcondicion.Text = condicion;
            }

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtpromedio.Clear();
            txtcondicion.Clear();
            txtnota1.Focus();
        }
    }
}
