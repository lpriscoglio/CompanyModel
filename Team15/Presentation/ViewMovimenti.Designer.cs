namespace Team15.Presentation
{
    partial class ViewMovimenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMovimenti));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSorgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDestinazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dipendenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimentoDiDenaroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crea = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiDenaroBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.causaleDataGridViewTextBoxColumn,
            this.nomeSorgenteDataGridViewTextBoxColumn,
            this.nomeDestinazioneDataGridViewTextBoxColumn,
            this.dipendenteDataGridViewTextBoxColumn,
            this.importoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movimentoDiDenaroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // causaleDataGridViewTextBoxColumn
            // 
            this.causaleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.causaleDataGridViewTextBoxColumn.DataPropertyName = "Causale";
            this.causaleDataGridViewTextBoxColumn.HeaderText = "Causale";
            this.causaleDataGridViewTextBoxColumn.Name = "causaleDataGridViewTextBoxColumn";
            this.causaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeSorgenteDataGridViewTextBoxColumn
            // 
            this.nomeSorgenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeSorgenteDataGridViewTextBoxColumn.DataPropertyName = "NomeSorgente";
            this.nomeSorgenteDataGridViewTextBoxColumn.HeaderText = "Sorgente";
            this.nomeSorgenteDataGridViewTextBoxColumn.Name = "nomeSorgenteDataGridViewTextBoxColumn";
            this.nomeSorgenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDestinazioneDataGridViewTextBoxColumn
            // 
            this.nomeDestinazioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDestinazioneDataGridViewTextBoxColumn.DataPropertyName = "NomeDestinazione";
            this.nomeDestinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione";
            this.nomeDestinazioneDataGridViewTextBoxColumn.Name = "nomeDestinazioneDataGridViewTextBoxColumn";
            this.nomeDestinazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dipendenteDataGridViewTextBoxColumn
            // 
            this.dipendenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dipendenteDataGridViewTextBoxColumn.DataPropertyName = "Dipendente";
            this.dipendenteDataGridViewTextBoxColumn.HeaderText = "Dipendente";
            this.dipendenteDataGridViewTextBoxColumn.Name = "dipendenteDataGridViewTextBoxColumn";
            this.dipendenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importoDataGridViewTextBoxColumn
            // 
            this.importoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            this.importoDataGridViewTextBoxColumn.HeaderText = "Importo";
            this.importoDataGridViewTextBoxColumn.Name = "importoDataGridViewTextBoxColumn";
            this.importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimentoDiDenaroBindingSource
            // 
            this.movimentoDiDenaroBindingSource.DataSource = typeof(Team15.Model.MovimentoDiDenaro);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sorgente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sorgente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Destinazione";
            this.dataGridViewTextBoxColumn2.HeaderText = "Destinazione";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Crea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(416, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ViewMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ViewMovimenti";
            this.Size = new System.Drawing.Size(416, 431);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiDenaroBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton Crea;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSorgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDestinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dipendenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movimentoDiDenaroBindingSource;
    }
}
