namespace Registro_de_RMA.Apresentacao
{
    partial class RegistroCamera
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lasertechbrasilDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lasertechbrasilDataSet3 = new Registro_de_RMA.lasertechbrasilDataSet3();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lasertechbrasilDataSet1 = new Registro_de_RMA.lasertechbrasilDataSet1();
            this.cameraTableAdapter = new Registro_de_RMA.lasertechbrasilDataSet1TableAdapters.cameraTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnConsultarSerie = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cameraTableAdapter1 = new Registro_de_RMA.lasertechbrasilDataSet3TableAdapters.cameraTableAdapter();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripSplitButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 76);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(308, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Registros de câmera";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCameraDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.cameraDataGridViewTextBoxColumn,
            this.macDataGridViewTextBoxColumn,
            this.acessorioDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dataDeEntradaDataGridViewTextBoxColumn,
            this.dataDeSaidaDataGridViewTextBoxColumn,
            this.statusCameraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cameraBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 342);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCameraDataGridViewTextBoxColumn
            // 
            this.idCameraDataGridViewTextBoxColumn.DataPropertyName = "idCamera";
            this.idCameraDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCameraDataGridViewTextBoxColumn.Name = "idCameraDataGridViewTextBoxColumn";
            this.idCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraDataGridViewTextBoxColumn
            // 
            this.cameraDataGridViewTextBoxColumn.DataPropertyName = "camera";
            this.cameraDataGridViewTextBoxColumn.HeaderText = "Câmera";
            this.cameraDataGridViewTextBoxColumn.Name = "cameraDataGridViewTextBoxColumn";
            this.cameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macDataGridViewTextBoxColumn
            // 
            this.macDataGridViewTextBoxColumn.DataPropertyName = "mac";
            this.macDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.macDataGridViewTextBoxColumn.Name = "macDataGridViewTextBoxColumn";
            this.macDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acessorioDataGridViewTextBoxColumn
            // 
            this.acessorioDataGridViewTextBoxColumn.DataPropertyName = "acessorio";
            this.acessorioDataGridViewTextBoxColumn.HeaderText = "Acessório(s)";
            this.acessorioDataGridViewTextBoxColumn.Name = "acessorioDataGridViewTextBoxColumn";
            this.acessorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeEntradaDataGridViewTextBoxColumn
            // 
            this.dataDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "dataDeEntrada";
            this.dataDeEntradaDataGridViewTextBoxColumn.HeaderText = "Data de entrada";
            this.dataDeEntradaDataGridViewTextBoxColumn.Name = "dataDeEntradaDataGridViewTextBoxColumn";
            this.dataDeEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeSaidaDataGridViewTextBoxColumn
            // 
            this.dataDeSaidaDataGridViewTextBoxColumn.DataPropertyName = "dataDeSaida";
            this.dataDeSaidaDataGridViewTextBoxColumn.HeaderText = "Data de saída";
            this.dataDeSaidaDataGridViewTextBoxColumn.Name = "dataDeSaidaDataGridViewTextBoxColumn";
            this.dataDeSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusCameraDataGridViewTextBoxColumn
            // 
            this.statusCameraDataGridViewTextBoxColumn.DataPropertyName = "statusCamera";
            this.statusCameraDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusCameraDataGridViewTextBoxColumn.Name = "statusCameraDataGridViewTextBoxColumn";
            this.statusCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraBindingSource1
            // 
            this.cameraBindingSource1.DataMember = "camera";
            this.cameraBindingSource1.DataSource = this.lasertechbrasilDataSet3BindingSource;
            // 
            // lasertechbrasilDataSet3BindingSource
            // 
            this.lasertechbrasilDataSet3BindingSource.DataSource = this.lasertechbrasilDataSet3;
            this.lasertechbrasilDataSet3BindingSource.Position = 0;
            // 
            // lasertechbrasilDataSet3
            // 
            this.lasertechbrasilDataSet3.DataSetName = "lasertechbrasilDataSet3";
            this.lasertechbrasilDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "camera";
            this.cameraBindingSource.DataSource = this.lasertechbrasilDataSet1;
            // 
            // lasertechbrasilDataSet1
            // 
            this.lasertechbrasilDataSet1.DataSetName = "lasertechbrasilDataSet1";
            this.lasertechbrasilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtConsulta);
            this.groupBox4.Controls.Add(this.lblItem);
            this.groupBox4.Controls.Add(this.btnConsultarSerie);
            this.groupBox4.Location = new System.Drawing.Point(12, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 69);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta por MAC";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.SystemColors.Info;
            this.txtConsulta.Location = new System.Drawing.Point(9, 36);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(292, 20);
            this.txtConsulta.TabIndex = 30;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(6, 17);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 29;
            this.lblItem.Text = "MAC";
            // 
            // btnConsultarSerie
            // 
            this.btnConsultarSerie.Location = new System.Drawing.Point(318, 34);
            this.btnConsultarSerie.Name = "btnConsultarSerie";
            this.btnConsultarSerie.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarSerie.TabIndex = 1;
            this.btnConsultarSerie.Text = "Consultar";
            this.btnConsultarSerie.UseVisualStyleBackColor = true;
            this.btnConsultarSerie.Click += new System.EventHandler(this.btnConsultarSerie_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 32);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(434, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 69);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status da OS";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(9, 33);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 33;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Listar tudo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cameraTableAdapter1
            // 
            this.cameraTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::Registro_de_RMA.Properties.Resources._2080887;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(109, 25);
            this.toolStripLabel3.Text = "Cadastrar";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Registro_de_RMA.Properties.Resources.reload_97640_960_720;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 25);
            this.toolStripLabel1.Text = "Atualizar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Registro_de_RMA.Properties.Resources.LTI_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Image = global::Registro_de_RMA.Properties.Resources.exit_97636_960_720;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(76, 29);
            this.toolStripTextBox1.Text = "Sair";
            // 
            // RegistroCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(989, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroCamera";
            this.Text = "RegistroCamera";
            this.Load += new System.EventHandler(this.RegistroCamera_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lasertechbrasilDataSet1 lasertechbrasilDataSet1;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private lasertechbrasilDataSet1TableAdapters.cameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnConsultarSerie;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource lasertechbrasilDataSet3BindingSource;
        private lasertechbrasilDataSet3 lasertechbrasilDataSet3;
        private System.Windows.Forms.BindingSource cameraBindingSource1;
        private lasertechbrasilDataSet3TableAdapters.cameraTableAdapter cameraTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.ToolStripSplitButton toolStripTextBox1;
    }
}