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
    public partial class InserimentoContoCorrenteBancario : Form
    {
        ViewContenitoriDiDenaro _cont;
        public InserimentoContoCorrenteBancario(ViewContenitoriDiDenaro cont)
        {
            InitializeComponent();
            _cont = cont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Model.Azienda.GetInstance().Depositi.AggiungiDeposito(Model.DepositoDiDenaroFactory.CreateContoCorrenteBancario
               (new Model.Currency(Decimal.Parse(textBox2.Text),textBox3.Text),textBox1.Text));
           _cont.refreshComboBox();
           _cont.inizializeComboBox();
            this.Close();
        }
    }
}
