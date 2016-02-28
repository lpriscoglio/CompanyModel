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
    public partial class InserimentoFatturaVendita : Form
    {
        private List<Model.RigaFatturaVendita> righe;
        public InserimentoFatturaVendita()
        {
            InitializeComponent();
            righe = new List<Model.RigaFatturaVendita>(); 
            foreach (Model.Cliente cliente in Model.Azienda.GetInstance().Soggetti.GetClienti())
            {
                comboBox1.Items.Add(cliente);
            }

            foreach (Model.Prodotto prodotto in Model.Azienda.GetInstance().Prodotti.GetProdotti)
            {
                comboBox2.Items.Add(prodotto);
            }
            dataGridView1.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridView1_RowsAdded);
        }

        void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Model.Currency importo=new Model.Currency(0m);
            foreach (Model.RigaFatturaVendita riga in righe)
            {
                importo.Importo += (((decimal)riga.Quantità) * riga.Prodotto.Prezzo.Importo);
            }
            textBox2.Text = importo.ToString();
        }

        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.righe;
            dataGridView1.DataSource = bindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Model.RigaFatturaVendita result=null;

            foreach (Model.RigaFatturaVendita riga in righe)
            {
                if (((Model.Prodotto)comboBox2.SelectedItem).CodiceProdotto == riga.Prodotto.CodiceProdotto)
                {
                    result = riga;
                }
            }

            if (result != null)
            {
                righe.Remove(result);
                righe.Add(new Model.RigaFatturaVendita(Double.Parse(textBox1.Text) + result.Quantità, ((Model.Prodotto)comboBox2.SelectedItem)));
            }
            else
            {
                righe.Add(new Model.RigaFatturaVendita(Double.Parse(textBox1.Text), ((Model.Prodotto)comboBox2.SelectedItem)));
            }
            this.FillData(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model.RigaFatturaVendita result=null;

            foreach (Model.RigaFatturaVendita riga in righe)
            {
                if (((Model.Prodotto)comboBox2.SelectedItem).CodiceProdotto == riga.Prodotto.CodiceProdotto)
                {
                    result = riga;
                }
            }
            if (result != null)
            {
                if (result.Quantità >= Double.Parse(textBox1.Text))
                {
                    righe.Remove(result);
                    righe.Add(new Model.RigaFatturaVendita(result.Quantità - Double.Parse(textBox1.Text),
                        ((Model.Prodotto)comboBox2.SelectedItem)));
                }
                else
                    MessageBox.Show("Quantità da eliminare maggiore della quantità in fattura", "Errore", MessageBoxButtons.OK);
            }
            this.FillData(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Azienda.GetInstance().Fatture.AggiungiFattura(new Model.FatturaVendita(righe,((Model.Cliente)comboBox1.SelectedItem)));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
