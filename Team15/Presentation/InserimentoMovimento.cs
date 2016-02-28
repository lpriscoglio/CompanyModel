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
    public partial class InserimentoMovimento : Form
    {
        public InserimentoMovimento()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pagamento Acquisto");
            comboBox1.Items.Add("Incasso Vendita");
            comboBox1.Items.Add("Prelievo");
            comboBox1.Items.Add("Spostamento");
            comboBox1.Items.Add("Versamento");
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            if (comboBox1.Text == "Pagamento Acquisto")
            {
                foreach (Model.FatturaAcquisto fattura in Model.Azienda.GetInstance().Fatture.GetFattureAcquistoDaPagare())
                {
                    comboBox3.Items.Add((object)fattura);
                }
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    comboBox2.Items.Add((object)deposito);
                }
                comboBox2.Items.Add((object)Model.Azienda.GetInstance().Cassa);
                textBox2.Enabled = false;
            }
            if (comboBox1.Text == "Incasso Vendita")
            {
                foreach (Model.FatturaVendita fattura in Model.Azienda.GetInstance().Fatture.GetFattureVenditaDaPagare())
                {
                    comboBox2.Items.Add((object)fattura);
                }
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    comboBox3.Items.Add((object)deposito);
                }
                comboBox3.Items.Add((object)Model.Azienda.GetInstance().Cassa);
                textBox2.Enabled = false;
            }
            if (comboBox1.Text == "Prelievo")
            {
                comboBox3.Items.Add((object)Model.Azienda.GetInstance().Cassa);
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    comboBox2.Items.Add((object)deposito);
                }
            }
            if (comboBox1.Text == "Versamento")
            {
                comboBox2.Items.Add((object)Model.Azienda.GetInstance().Cassa);
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    comboBox3.Items.Add((object)deposito);
                }
             }
            if (comboBox1.Text == "Spostamento")
            {
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    comboBox3.Items.Add((object)deposito);
                    comboBox2.Items.Add((object)deposito);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pagamento Acquisto")
            {
                Model.Azienda.GetInstance().Movimenti.AggiungiMovimento(new Model.PagamentoAcquisto(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),textBox1.Text,Model.Autenticazione.Utente.Dipendente,
                    (Model.ISorgente)comboBox2.SelectedItem,(Model.IDestinazione)comboBox3.SelectedItem));
            }
            if (comboBox1.Text == "Incasso Vendita")
            {
                Model.Azienda.GetInstance().Movimenti.AggiungiMovimento(new Model.IncassoVendita((Model.IDestinazione)comboBox3.SelectedItem,(Model.ISorgente)comboBox2.SelectedItem,DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),
                    textBox1.Text, Model.Autenticazione.Utente.Dipendente));
            }
            if (comboBox1.Text == "Prelievo")
            {
                Model.Azienda.GetInstance().Movimenti.AggiungiMovimento(Model.MovimentoInternoFactory.CreatePrelievo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),textBox1.Text,Model.Autenticazione.Utente.Dipendente,new Model.Currency(Decimal.Parse(textBox2.Text)),
                    (Model.DepositoDiDenaro)comboBox2.SelectedItem,(Model.Cassa)comboBox3.SelectedItem));                   
            }
            if (comboBox1.Text == "Versamento")
            {
                Model.Azienda.GetInstance().Movimenti.AggiungiMovimento(Model.MovimentoInternoFactory.CreateVersamento(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()), textBox1.Text, Model.Autenticazione.Utente.Dipendente, new Model.Currency(Decimal.Parse(textBox2.Text)),
                    (Model.Cassa)comboBox2.SelectedItem, (Model.DepositoDiDenaro)comboBox3.SelectedItem));
            }
            if (comboBox1.Text == "Spostamento")
            {
                Model.Azienda.GetInstance().Movimenti.AggiungiMovimento(Model.MovimentoInternoFactory.CreateSpostamento(DateTime.Parse(dateTimePicker1.Value.ToShortDateString()), textBox1.Text, Model.Autenticazione.Utente.Dipendente, new Model.Currency(Decimal.Parse(textBox2.Text)),
                    (Model.DepositoDiDenaro)comboBox2.SelectedItem, (Model.DepositoDiDenaro)comboBox3.SelectedItem));              
            }
            this.Close();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Incasso Vendita")
            {
                textBox2.Text = ((Model.FatturaVendita)comboBox2.SelectedItem).Importo.Importo.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pagamento Acquisto")
            {
                textBox2.Text = ((Model.FatturaAcquisto)comboBox3.SelectedItem).Importo.Importo.ToString();
            }
        }
    }
}
