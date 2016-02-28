using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class VisualizzaRiepilogoCliente : Form
    {
        public VisualizzaRiepilogoCliente(Model.Cliente cliente)
        {
            InitializeComponent();
            Model.RiepilogoCliente riepilogo = new Model.RiepilogoCliente(cliente);
            textBox1.Text = riepilogo.GetImportiDaPagare().ToString();
            textBox2.Text = riepilogo.GetImportiPagati().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
