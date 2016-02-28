using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class ViewContenitoriDiDenaro : UserControl
    {
        InserimentoContoCorrenteBancario form;
        public ViewContenitoriDiDenaro()
        {
            InitializeComponent();
            inizializeComboBox();           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cassa")
                textBox1.Text = Model.Azienda.GetInstance().Cassa.Saldo().Importo.ToString();
            else
            {
                foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
                {
                    if (comboBox1.Text == deposito.ToString())
                        textBox1.Text = deposito.Saldo().Importo.ToString();
                }
            }
        }

        public void inizializeComboBox()
        {
            foreach (Model.DepositoDiDenaro deposito in Model.Azienda.GetInstance().Depositi.GetDepositi)
            {
                comboBox1.Items.Add(deposito);
            }
            comboBox1.Items.Add(Model.Azienda.GetInstance().Cassa);
        }

        public void refreshComboBox()
        {
            comboBox1.Items.Clear();
        }

        private void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoContoCorrenteBancario(this);
            form.Show();
        }       
    }
}
