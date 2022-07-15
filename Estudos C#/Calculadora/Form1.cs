using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double v1, v2, result;

            v1 = double.Parse(txtV1.Text);
            v2 = double.Parse(txtV2.Text);

            result = v1 + v2;
            lbResult.Text = "Resultado.: " + result.ToString();


        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Text = "";
            txtV2.Text = "";
            lbResult.Text = "Resultado.:";
        }
    }
}
