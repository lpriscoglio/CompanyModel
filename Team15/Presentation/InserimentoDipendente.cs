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
    public partial class InserimentoDipendente : Form
    {
       public InserimentoDipendente()
        {
            InitializeComponent();
            comboBox1.Items.Add(Model.Ruolo.Utente);
            comboBox1.Items.Add(Model.Ruolo.Amministratore);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Azienda.GetInstance().Dipendenti.AggiungiDipendente(new Model.Dipendente(textBox2.Text, textBox3.Text, textBox1.Text, textBox4.Text,(Model.Ruolo)comboBox1.SelectedItem));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
