using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class ViewFornitore : UserControl
    {
        InserimentoFornitore form;
        VisualizzaRiepilogoFornitore form1;
        public ViewFornitore()
        {
            InitializeComponent();
            FillData(null, null);
            Crea.Click += new EventHandler(Crea_Click);
            Model.Azienda.GetInstance().Changed += FillData;
        }


        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Soggetti.GetFornitori();
            dataGridView1.DataSource = bindingSource;
        }

        void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoFornitore();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            form1 = new VisualizzaRiepilogoFornitore((Model.Fornitore)dataGridView1.CurrentRow.DataBoundItem);
            form1.Show();
        }
    }
}
