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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPatrimonio = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtApontamento = new System.Windows.Forms.TextBox();
            this.lblApontamento = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.txtOrdemDeServico = new System.Windows.Forms.TextBox();
            this.lblRecebimento = new System.Windows.Forms.Label();
            this.txtRecebimento = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtRma = new System.Windows.Forms.TextBox();
            this.lblRma = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnConsultarSerie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnDeletarSerie = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnEntregue = new System.Windows.Forms.Button();
            this.btnRecebido = new System.Windows.Forms.Button();
            this.btnEncaminhar = new System.Windows.Forms.Button();
            this.lblDataDeEntrada = new System.Windows.Forms.Label();
            this.lblDataDeSaida = new System.Windows.Forms.Label();
            this.radNumerDeSerie = new System.Windows.Forms.RadioButton();
            this.radData = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConsultarData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 309);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nº de série";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cliente";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RMA";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rec.";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "O.S";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "AP";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data de entrada";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data de saída";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 76);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Registro_de_RMA.Properties.Resources.LTI_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 63);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.txtPatrimonio);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblPatrimonio);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtApontamento);
            this.groupBox1.Controls.Add(this.lblApontamento);
            this.groupBox1.Controls.Add(this.lblOs);
            this.groupBox1.Controls.Add(this.txtOrdemDeServico);
            this.groupBox1.Controls.Add(this.lblRecebimento);
            this.groupBox1.Controls.Add(this.txtRecebimento);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtRma);
            this.groupBox1.Controls.Add(this.lblRma);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblNumeroDeSerie);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.Info;
            this.txtObservacao.Location = new System.Drawing.Point(16, 121);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(772, 61);
            this.txtObservacao.TabIndex = 20;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.BackColor = System.Drawing.SystemColors.Info;
            this.txtPatrimonio.Location = new System.Drawing.Point(654, 21);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(134, 20);
            this.txtPatrimonio.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Observação";
            // 
            // lblPatrimonio
            // 
            this.lblPatrimonio.AutoSize = true;
            this.lblPatrimonio.Location = new System.Drawing.Point(592, 28);
            this.lblPatrimonio.Name = "lblPatrimonio";
            this.lblPatrimonio.Size = new System.Drawing.Size(56, 13);
            this.lblPatrimonio.TabIndex = 17;
            this.lblPatrimonio.Text = "Patrimônio";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(711, 80);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtApontamento
            // 
            this.txtApontamento.BackColor = System.Drawing.SystemColors.Info;
            this.txtApontamento.Location = new System.Drawing.Point(787, 320);
            this.txtApontamento.Name = "txtApontamento";
            this.txtApontamento.Size = new System.Drawing.Size(134, 20);
            this.txtApontamento.TabIndex = 15;
            // 
            // lblApontamento
            // 
            this.lblApontamento.AutoSize = true;
            this.lblApontamento.Location = new System.Drawing.Point(290, 79);
            this.lblApontamento.Name = "lblApontamento";
            this.lblApontamento.Size = new System.Drawing.Size(70, 13);
            this.lblApontamento.TabIndex = 14;
            this.lblApontamento.Text = "Apontamento";
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Location = new System.Drawing.Point(287, 54);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(92, 13);
            this.lblOs.TabIndex = 12;
            this.lblOs.Text = "Ordem de Serviço";
            // 
            // txtOrdemDeServico
            // 
            this.txtOrdemDeServico.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrdemDeServico.Location = new System.Drawing.Point(385, 47);
            this.txtOrdemDeServico.Name = "txtOrdemDeServico";
            this.txtOrdemDeServico.Size = new System.Drawing.Size(202, 20);
            this.txtOrdemDeServico.TabIndex = 13;
            // 
            // lblRecebimento
            // 
            this.lblRecebimento.AutoSize = true;
            this.lblRecebimento.Location = new System.Drawing.Point(287, 28);
            this.lblRecebimento.Name = "lblRecebimento";
            this.lblRecebimento.Size = new System.Drawing.Size(70, 13);
            this.lblRecebimento.TabIndex = 10;
            this.lblRecebimento.Text = "Recebimento";
            // 
            // txtRecebimento
            // 
            this.txtRecebimento.BackColor = System.Drawing.SystemColors.Info;
            this.txtRecebimento.Location = new System.Drawing.Point(385, 21);
            this.txtRecebimento.Name = "txtRecebimento";
            this.txtRecebimento.Size = new System.Drawing.Size(202, 20);
            this.txtRecebimento.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(603, 80);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtRma
            // 
            this.txtRma.BackColor = System.Drawing.SystemColors.Info;
            this.txtRma.Location = new System.Drawing.Point(77, 76);
            this.txtRma.Name = "txtRma";
            this.txtRma.Size = new System.Drawing.Size(134, 20);
            this.txtRma.TabIndex = 9;
            // 
            // lblRma
            // 
            this.lblRma.AutoSize = true;
            this.lblRma.Location = new System.Drawing.Point(16, 79);
            this.lblRma.Name = "lblRma";
            this.lblRma.Size = new System.Drawing.Size(31, 13);
            this.lblRma.TabIndex = 8;
            this.lblRma.Text = "RMA";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 54);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCliente.Location = new System.Drawing.Point(77, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(202, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // lblNumeroDeSerie
            // 
            this.lblNumeroDeSerie.AutoSize = true;
            this.lblNumeroDeSerie.Location = new System.Drawing.Point(13, 28);
            this.lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            this.lblNumeroDeSerie.Size = new System.Drawing.Size(59, 13);
            this.lblNumeroDeSerie.TabIndex = 5;
            this.lblNumeroDeSerie.Text = "Nº de série";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.Info;
            this.txtSerie.Location = new System.Drawing.Point(77, 21);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(202, 20);
            this.txtSerie.TabIndex = 5;
            // 
            // btnConsultarSerie
            // 
            this.btnConsultarSerie.Location = new System.Drawing.Point(142, 33);
            this.btnConsultarSerie.Name = "btnConsultarSerie";
            this.btnConsultarSerie.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarSerie.TabIndex = 1;
            this.btnConsultarSerie.Text = "Consultar";
            this.btnConsultarSerie.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 20);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(59, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Nº de série";
            // 
            // btnDeletarSerie
            // 
            this.btnDeletarSerie.Location = new System.Drawing.Point(224, 33);
            this.btnDeletarSerie.Name = "btnDeletarSerie";
            this.btnDeletarSerie.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarSerie.TabIndex = 5;
            this.btnDeletarSerie.Text = "Deletar";
            this.btnDeletarSerie.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPausa);
            this.groupBox2.Controls.Add(this.btnEntregue);
            this.groupBox2.Controls.Add(this.btnRecebido);
            this.groupBox2.Controls.Add(this.btnEncaminhar);
            this.groupBox2.Location = new System.Drawing.Point(878, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // btnPausa
            // 
            this.btnPausa.Location = new System.Drawing.Point(22, 99);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(114, 26);
            this.btnPausa.TabIndex = 10;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            // 
            // btnEntregue
            // 
            this.btnEntregue.Location = new System.Drawing.Point(22, 131);
            this.btnEntregue.Name = "btnEntregue";
            this.btnEntregue.Size = new System.Drawing.Size(115, 26);
            this.btnEntregue.TabIndex = 9;
            this.btnEntregue.Text = "Entregue";
            this.btnEntregue.UseVisualStyleBackColor = true;
            // 
            // btnRecebido
            // 
            this.btnRecebido.Location = new System.Drawing.Point(22, 64);
            this.btnRecebido.Name = "btnRecebido";
            this.btnRecebido.Size = new System.Drawing.Size(115, 26);
            this.btnRecebido.TabIndex = 8;
            this.btnRecebido.Text = "Recebido";
            this.btnRecebido.UseVisualStyleBackColor = true;
            // 
            // btnEncaminhar
            // 
            this.btnEncaminhar.Location = new System.Drawing.Point(22, 29);
            this.btnEncaminhar.Name = "btnEncaminhar";
            this.btnEncaminhar.Size = new System.Drawing.Size(115, 26);
            this.btnEncaminhar.TabIndex = 7;
            this.btnEncaminhar.Text = "Encaminhar";
            this.btnEncaminhar.UseVisualStyleBackColor = true;
            // 
            // lblDataDeEntrada
            // 
            this.lblDataDeEntrada.AutoSize = true;
            this.lblDataDeEntrada.Location = new System.Drawing.Point(3, 15);
            this.lblDataDeEntrada.Name = "lblDataDeEntrada";
            this.lblDataDeEntrada.Size = new System.Drawing.Size(84, 13);
            this.lblDataDeEntrada.TabIndex = 7;
            this.lblDataDeEntrada.Text = "Data de entrada";
            // 
            // lblDataDeSaida
            // 
            this.lblDataDeSaida.AutoSize = true;
            this.lblDataDeSaida.Location = new System.Drawing.Point(3, 78);
            this.lblDataDeSaida.Name = "lblDataDeSaida";
            this.lblDataDeSaida.Size = new System.Drawing.Size(81, 13);
            this.lblDataDeSaida.TabIndex = 8;
            this.lblDataDeSaida.Text = "Data de retorno";
            // 
            // radNumerDeSerie
            // 
            this.radNumerDeSerie.AutoSize = true;
            this.radNumerDeSerie.Location = new System.Drawing.Point(6, 19);
            this.radNumerDeSerie.Name = "radNumerDeSerie";
            this.radNumerDeSerie.Size = new System.Drawing.Size(77, 17);
            this.radNumerDeSerie.TabIndex = 9;
            this.radNumerDeSerie.TabStop = true;
            this.radNumerDeSerie.Text = "Nº de série";
            this.radNumerDeSerie.UseVisualStyleBackColor = true;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(103, 19);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(48, 17);
            this.radData.TabIndex = 10;
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radData);
            this.groupBox3.Controls.Add(this.radNumerDeSerie);
            this.groupBox3.Location = new System.Drawing.Point(736, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 49);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de consulta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.btnConsultarSerie);
            this.groupBox4.Controls.Add(this.lblNumber);
            this.groupBox4.Controls.Add(this.btnDeletarSerie);
            this.groupBox4.Location = new System.Drawing.Point(736, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 68);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta por DS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConsultarData);
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Controls.Add(this.lblDataDeEntrada);
            this.groupBox5.Controls.Add(this.lblDataDeSaida);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Location = new System.Drawing.Point(736, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 175);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consulta por data";
            // 
            // btnConsultarData
            // 
            this.btnConsultarData.Location = new System.Drawing.Point(142, 131);
            this.btnConsultarData.Name = "btnConsultarData";
            this.btnConsultarData.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarData.TabIndex = 6;
            this.btnConsultarData.Text = "Consultar";
            this.btnConsultarData.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 631);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPatrimonio;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtApontamento;
        private System.Windows.Forms.Label lblApontamento;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.TextBox txtOrdemDeServico;
        private System.Windows.Forms.Label lblRecebimento;
        private System.Windows.Forms.TextBox txtRecebimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtRma;
        private System.Windows.Forms.Label lblRma;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnConsultarSerie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnDeletarSerie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnEntregue;
        private System.Windows.Forms.Button btnRecebido;
        private System.Windows.Forms.Button btnEncaminhar;
        private System.Windows.Forms.Label lblDataDeEntrada;
        private System.Windows.Forms.Label lblDataDeSaida;
        private System.Windows.Forms.RadioButton radNumerDeSerie;
        private System.Windows.Forms.RadioButton radData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConsultarData;
    }
}