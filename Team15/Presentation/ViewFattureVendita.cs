using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class ViewFattureVendita : UserControl
    {
        InserimentoFatturaVendita form1;
        RigheFatturaVendita form;
        public ViewFattureVendita()
        {
            InitializeComponent();
            FillData(null, null);
            Model.Azienda.GetInstance().Changed += FillData;
        }


        void FillData(object sender, EventArgs e)
        {
           
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Fatture.GetFattureVendita();
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            BindingSource list = (BindingSource)dataGridView1.DataSource;
            Model.FatturaVendita f=(Model.FatturaVendita)list[e.RowIndex];
            form = new RigheFatturaVendita(f);
            form.Show();
        }

        private void Crea_Click_1(object sender, EventArgs e)
        {
            form1 = new InserimentoFatturaVendita();
            form1.Show();
        }
        

    }
}
