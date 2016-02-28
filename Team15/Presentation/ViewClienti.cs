using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    
    public partial class ViewClienti : UserControl
    {
        VisualizzaRiepilogoCliente form1;
        InserimentoCliente form;
        public ViewClienti()
        {
            InitializeComponent();
            FillData(null,null);
            Crea.Click += new EventHandler(Crea_Click);
            Model.Azienda.GetInstance().Changed += FillData;
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }

        void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
        }

        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Soggetti.GetClienti();
            dataGridView1.DataSource = bindingSource;
        }

        void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoCliente();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            form1 = new VisualizzaRiepilogoCliente((Model.Cliente)dataGridView1.CurrentRow.DataBoundItem);
            form1.Show();
        }       
    }
}
