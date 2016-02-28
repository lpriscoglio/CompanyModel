using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class ViewFattureAcquisto : UserControl
    {
        InserimentoFatturaAcquisto form;
        public ViewFattureAcquisto()
        {
            InitializeComponent();
            FillData(null, null);
            Crea.Click += new EventHandler(Crea_Click);
            Model.Azienda.GetInstance().Changed += FillData;
        }

        void FillData(object sender, EventArgs e)
        {            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Fatture.GetFattureAcquisto();
            dataGridView1.DataSource = bindingSource;
        }

        
        private void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoFatturaAcquisto();
            form.Show();
        }

    }
}
