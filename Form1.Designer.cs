namespace CheckDNs___Conta_Corrente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTxt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.lblDuplicados = new System.Windows.Forms.Label();
            this.colDNTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDnCsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantCsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCsv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad7 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.AutoSize = true;
            this.btnTxt.Location = new System.Drawing.Point(287, 6);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(119, 23);
            this.btnTxt.TabIndex = 0;
            this.btnTxt.Text = "Selecionar TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDNTxt,
            this.colQuantTxt,
            this.colDnCsv,
            this.colQuantCsv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(283, 861);
            this.dataGridView1.TabIndex = 1;
            // 
            // opFile
            // 
            this.opFile.FileName = "openFileDialog1";
            // 
            // lblDuplicados
            // 
            this.lblDuplicados.AutoSize = true;
            this.lblDuplicados.ForeColor = System.Drawing.Color.Red;
            this.lblDuplicados.Location = new System.Drawing.Point(292, 141);
            this.lblDuplicados.Name = "lblDuplicados";
            this.lblDuplicados.Size = new System.Drawing.Size(0, 13);
            this.lblDuplicados.TabIndex = 2;
            // 
            // colDNTxt
            // 
            this.colDNTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDNTxt.HeaderText = "DN (txt)";
            this.colDNTxt.Name = "colDNTxt";
            this.colDNTxt.ReadOnly = true;
            this.colDNTxt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDNTxt.Width = 60;
            // 
            // colQuantTxt
            // 
            this.colQuantTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantTxt.HeaderText = "# (txt)";
            this.colQuantTxt.Name = "colQuantTxt";
            this.colQuantTxt.ReadOnly = true;
            this.colQuantTxt.Width = 60;
            // 
            // colDnCsv
            // 
            this.colDnCsv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDnCsv.HeaderText = "DN (csv)";
            this.colDnCsv.Name = "colDnCsv";
            this.colDnCsv.ReadOnly = true;
            this.colDnCsv.Width = 60;
            // 
            // colQuantCsv
            // 
            this.colQuantCsv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantCsv.HeaderText = "# (csv)";
            this.colQuantCsv.Name = "colQuantCsv";
            this.colQuantCsv.ReadOnly = true;
            this.colQuantCsv.Width = 60;
            // 
            // btnCsv
            // 
            this.btnCsv.AutoSize = true;
            this.btnCsv.Location = new System.Drawing.Point(412, 6);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(119, 23);
            this.btnCsv.TabIndex = 3;
            this.btnCsv.Text = "Selecionar CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad7);
            this.groupBox1.Location = new System.Drawing.Point(289, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface";
            // 
            // rad7
            // 
            this.rad7.AutoSize = true;
            this.rad7.Location = new System.Drawing.Point(6, 19);
            this.rad7.Name = "rad7";
            this.rad7.Size = new System.Drawing.Size(69, 17);
            this.rad7.TabIndex = 0;
            this.rad7.TabStop = true;
            this.rad7.Text = "IOAR007";
            this.rad7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 861);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.lblDuplicados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTxt);
            this.Name = "Form1";
            this.Text = "CheckDNs - Conta Corrente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.Label lblDuplicados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDnCsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantCsv;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad7;
    }
}

