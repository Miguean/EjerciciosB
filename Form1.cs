using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosB
{
    public partial class E1 : Form
    {
        public E1()
        {
            InitializeComponent();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbxHoras.Text != "" && tbxSalario.Text != "")
            {
                double Horas = Convert.ToDouble(tbxHoras.Text);
                double Salario = Convert.ToDouble(tbxSalario.Text);
                double Bono = 0;
                if (tbxBono.Text != "")
                {
                    Bono = Convert.ToDouble(tbxBono.Text);
                }
                
                tbxResultado.Text = "$" + (Horas * Salario + Bono).ToString();
            }
            
        }

        private void tbxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxHoras.Clear();
            tbxSalario.Clear();
            tbxBono.Clear();
            tbxResultado.Clear();
            tbxHoras.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
