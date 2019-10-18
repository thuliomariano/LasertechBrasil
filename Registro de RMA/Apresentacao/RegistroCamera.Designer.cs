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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lasertechbrasilDataSet1 = new Registro_de_RMA.lasertechbrasilDataSet1();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraTableAdapter = new Registro_de_RMA.lasertechbrasilDataSet1TableAdapters.cameraTableAdapter();
            this.idCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultarSerie = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Registros de sensores";
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
            this.dataGridView1.DataSource = this.cameraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 342);
            this.dataGridView1.TabIndex = 3;
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
            // lasertechbrasilDataSet1
            // 
            this.lasertechbrasilDataSet1.DataSetName = "lasertechbrasilDataSet1";
            this.lasertechbrasilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "camera";
            this.cameraBindingSource.DataSource = this.lasertechbrasilDataSet1;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
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
            this.macDataGridViewTextBoxColumn.HeaderText = "Mac";
            this.macDataGridViewTextBoxColumn.Name = "macDataGridViewTextBoxColumn";
            this.macDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acessorioDataGridViewTextBoxColumn
            // 
            this.acessorioDataGridViewTextBoxColumn.DataPropertyName = "acessorio";
            this.acessorioDataGridViewTextBoxColumn.HeaderText = "Acessório";
            this.acessorioDataGridViewTextBoxColumn.Name = "acessorioDataGridViewTextBoxColumn";
            this.acessorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblItem);
            this.groupBox4.Controls.Add(this.txtConsulta);
            this.groupBox4.Controls.Add(this.btnConsultarSerie);
            this.groupBox4.Location = new System.Drawing.Point(12, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 69);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta por DS";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(6, 17);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(59, 13);
            this.lblItem.TabIndex = 29;
            this.lblItem.Text = "Nº de série";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(6, 36);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(306, 20);
            this.txtConsulta.TabIndex = 3;
            // 
            // btnConsultarSerie
            // 
            this.btnConsultarSerie.Location = new System.Drawing.Point(318, 34);
            this.btnConsultarSerie.Name = "btnConsultarSerie";
            this.btnConsultarSerie.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarSerie.TabIndex = 1;
            this.btnConsultarSerie.Text = "Consultar";
            this.btnConsultarSerie.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::Registro_de_RMA.Properties.Resources.kisspng_computer_icons_plus_sign_clip_art_plus_sign_5b4bfbdff0b3a7_2950963015317063359859;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel3.Text = "Cadastrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Registro_de_RMA.Properties.Resources.kisspng_computer_icons_button_update_clip_art_alexis_snchez_5b516c3b6d9af0_831798481532062779449;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel1.Text = "Atualizar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RegistroCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 566);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultarSerie;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}