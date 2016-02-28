using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class InserimentoProdotto : Form
    {
        
        public InserimentoProdotto()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Model.Azienda.GetInstance().Prodotti.AggiungiProdotto(new Model.Prodotto(textBox1.Text, richTextBox1.Text, new Model.Currency(Decimal.Parse(textBox2.Text), textBox3.Text)));
            this.Close();
        }
    }
}
