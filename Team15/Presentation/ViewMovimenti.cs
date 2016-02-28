using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class ViewMovimenti : UserControl
    {
        InserimentoMovimento form;
        public ViewMovimenti()
        {
            InitializeComponent();
            FillData(null, null);
            Crea.Click += new EventHandler(Crea_Click);
            Model.Azienda.GetInstance().Changed += FillData;
        }

        void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoMovimento();
            form.Show();
        }

        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Movimenti.GetMovimenti;
            dataGridView1.DataSource = bindingSource;
        }


        
    }
}
