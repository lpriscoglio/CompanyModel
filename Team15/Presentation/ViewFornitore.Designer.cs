﻿namespace Team15.Presentation
{
    partial class ViewFornitore
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFornitore));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denominazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partitaIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornitoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Crea = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denominazioneDataGridViewTextBoxColumn,
            this.partitaIvaDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornitoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // denominazioneDataGridViewTextBoxColumn
            // 
            this.denominazioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.denominazioneDataGridViewTextBoxColumn.DataPropertyName = "Denominazione";
            this.denominazioneDataGridViewTextBoxColumn.HeaderText = "Denominazione";
            this.denominazioneDataGridViewTextBoxColumn.Name = "denominazioneDataGridViewTextBoxColumn";
            this.denominazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partitaIvaDataGridViewTextBoxColumn
            // 
            this.partitaIvaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partitaIvaDataGridViewTextBoxColumn.DataPropertyName = "PartitaIva";
            this.partitaIvaDataGridViewTextBoxColumn.HeaderText = "PartitaIva";
            this.partitaIvaDataGridViewTextBoxColumn.Name = "partitaIvaDataGridViewTextBoxColumn";
            this.partitaIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fornitoreBindingSource
            // 
            this.fornitoreBindingSource.DataSource = typeof(Team15.Model.Fornitore);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Crea,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(412, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Crea
            // 
            this.Crea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Crea.Image = ((System.Drawing.Image)(resources.GetObject("Crea.Image")));
            this.Crea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Crea.Name = "Crea";
            this.Crea.Size = new System.Drawing.Size(47, 22);
            this.Crea.Text = "Nuovo";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton1.Text = "Visualizza Riepilogo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ViewFornitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ViewFornitore";
            this.Size = new System.Drawing.Size(412, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Crea;
        private System.Windows.Forms.BindingSource fornitoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partitaIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
