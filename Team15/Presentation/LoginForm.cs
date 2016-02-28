using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team15.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            this.FormClosed +=new FormClosedEventHandler(LoginForm_FormClosed);
        }

       private void button1_Click(object sender, EventArgs e)
        {
            if (Model.Autenticazione.AutenticaDipendente(textBox1.Text, textBox2.Text) != null ) // test
            {
                this.Hide();
                MainForm form = new MainForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Username o password errati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

       private void LoginForm_FormClosed(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == (char)13)
           {
               button1_Click(sender,e);
           }
       }

    }
}
