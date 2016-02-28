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
    public partial class InserimentoFatturaAcquisto : Form
    {
        public InserimentoFatturaAcquisto()
        {
            InitializeComponent();
            foreach (Model.Fornitore fornitore in Model.Azienda.GetInstance().Soggetti.GetFornitori())
            {
                comboBox1.Items.Add(fornitore);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Azienda.GetInstance().Fatture.AggiungiFattura(new Model.FatturaAcquisto(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),UInt32.Parse(textBox1.Text),
                new Model.Currency(Decimal.Parse(textBox2.Text),textBox3.Text),(Model.Fornitore)comboBox1.SelectedItem));
            this.Close();
        }
    }
}
