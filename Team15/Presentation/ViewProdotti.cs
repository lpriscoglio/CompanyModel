using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace Team15.Presentation
{
    public partial class ViewProdotti : UserControl
    {
        InserimentoProdotto form;
        public ViewProdotti()
        {
            InitializeComponent();
            FillData(null,null);
            Crea.Click += new EventHandler(Crea_Click);
            Model.Azienda.GetInstance().Changed += FillData;
        }

       

        void Crea_Click(object sender, EventArgs e)
        {
            form = new InserimentoProdotto();
            form.Show();
        }


        void FillData(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Model.Azienda.GetInstance().Prodotti.GetProdotti;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
