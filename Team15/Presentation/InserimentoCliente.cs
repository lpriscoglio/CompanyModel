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
    public partial class InserimentoCliente : Form
    {
        public InserimentoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Azienda.GetInstance().Soggetti.AggiungiSoggetto(new Model.Cliente(textBox3.Text,textBox1.Text,textBox4.Text,textBox11.Text,textBox2.Text, 
            new Model.Indirizzo(textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text)));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
        
       
    }
}
