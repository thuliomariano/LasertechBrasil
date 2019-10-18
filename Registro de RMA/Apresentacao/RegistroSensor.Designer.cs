namespace Registro_de_RMA.Apresentacao
{
    partial class Registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarSerie = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrimonioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apontamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDaOsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lasertechbrasilDataSet = new Registro_de_RMA.lasertechbrasilDataSet();
            this.sensorTableAdapter = new Registro_de_RMA.lasertechbrasilDataSetTableAdapters.SensorTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1271, 76);
            this.panel1.TabIndex = 1;
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
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(6, 36);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(306, 20);
            this.txtConsulta.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblItem);
            this.groupBox4.Controls.Add(this.txtConsulta);
            this.groupBox4.Controls.Add(this.btnConsultarSerie);
            this.groupBox4.Location = new System.Drawing.Point(12, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 69);
            this.groupBox4.TabIndex = 14;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1157, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listar tudo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.numeroDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.rmaDataGridViewTextBoxColumn,
            this.patrimonioDataGridViewTextBoxColumn,
            this.recebimentoDataGridViewTextBoxColumn,
            this.osDataGridViewTextBoxColumn,
            this.apontamentoDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dataDeEntradaDataGridViewTextBoxColumn,
            this.dataDeSaidaDataGridViewTextBoxColumn,
            this.statusDaOsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensorBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 430);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idSensor";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Historico";
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
            this.toolStrip1.Size = new System.Drawing.Size(1271, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::Registro_de_RMA.Properties.Resources.kisspng_computer_icons_plus_sign_clip_art_plus_sign_5b4bfbdff0b3a7_2950963015317063359859;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel3.Text = "Cadastrar";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Registro_de_RMA.Properties.Resources.kisspng_computer_icons_button_update_clip_art_alexis_snchez_5b516c3b6d9af0_831798481532062779449;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel1.Text = "Atualizar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Registro_de_RMA.Properties.Resources.exit_97636_960_720;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1174, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Nº de série";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rmaDataGridViewTextBoxColumn
            // 
            this.rmaDataGridViewTextBoxColumn.DataPropertyName = "rma";
            this.rmaDataGridViewTextBoxColumn.HeaderText = "RMA";
            this.rmaDataGridViewTextBoxColumn.Name = "rmaDataGridViewTextBoxColumn";
            this.rmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patrimonioDataGridViewTextBoxColumn
            // 
            this.patrimonioDataGridViewTextBoxColumn.DataPropertyName = "patrimonio";
            this.patrimonioDataGridViewTextBoxColumn.HeaderText = "Patrimonio";
            this.patrimonioDataGridViewTextBoxColumn.Name = "patrimonioDataGridViewTextBoxColumn";
            this.patrimonioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recebimentoDataGridViewTextBoxColumn
            // 
            this.recebimentoDataGridViewTextBoxColumn.DataPropertyName = "recebimento";
            this.recebimentoDataGridViewTextBoxColumn.HeaderText = "Recebimento";
            this.recebimentoDataGridViewTextBoxColumn.Name = "recebimentoDataGridViewTextBoxColumn";
            this.recebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osDataGridViewTextBoxColumn
            // 
            this.osDataGridViewTextBoxColumn.DataPropertyName = "os";
            this.osDataGridViewTextBoxColumn.HeaderText = "O.S";
            this.osDataGridViewTextBoxColumn.Name = "osDataGridViewTextBoxColumn";
            this.osDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apontamentoDataGridViewTextBoxColumn
            // 
            this.apontamentoDataGridViewTextBoxColumn.DataPropertyName = "apontamento";
            this.apontamentoDataGridViewTextBoxColumn.HeaderText = "Apontamento";
            this.apontamentoDataGridViewTextBoxColumn.Name = "apontamentoDataGridViewTextBoxColumn";
            this.apontamentoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // statusDaOsDataGridViewTextBoxColumn
            // 
            this.statusDaOsDataGridViewTextBoxColumn.DataPropertyName = "statusDaOs";
            this.statusDaOsDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDaOsDataGridViewTextBoxColumn.Name = "statusDaOsDataGridViewTextBoxColumn";
            this.statusDaOsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorBindingSource
            // 
            this.sensorBindingSource.DataMember = "Sensor";
            this.sensorBindingSource.DataSource = this.lasertechbrasilDataSet;
            // 
            // lasertechbrasilDataSet
            // 
            this.lasertechbrasilDataSet.DataSetName = "lasertechbrasilDataSet";
            this.lasertechbrasilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorTableAdapter
            // 
            this.sensorTableAdapter.ClearBeforeFill = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 717);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Registro";
            this.Text = "Consulta avançada";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasertechbrasilDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConsultarSerie;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lasertechbrasilDataSet lasertechbrasilDataSet;
        private System.Windows.Forms.BindingSource sensorBindingSource;
        private lasertechbrasilDataSetTableAdapters.SensorTableAdapter sensorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSensorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patrimonioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apontamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDaOsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label4;
    }
}