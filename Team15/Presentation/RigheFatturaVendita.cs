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
    public partial class RigheFatturaVendita : Form
    {
        Model.FatturaVendita _fattura;
        public RigheFatturaVendita(Model.FatturaVendita fattura)
        {
            InitializeComponent();
            _fattura = fattura;
            FillData(null, null);
            Model.Azienda.GetInstance().Changed += FillData;
        }

        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().GetRighe(_fattura);
            dataGridView1.DataSource = bindingSource;
        }
    }
}
