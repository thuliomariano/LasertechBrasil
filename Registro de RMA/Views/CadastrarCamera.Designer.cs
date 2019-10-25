namespace Registro_de_RMA.Views
{
    partial class CadastrarCamera
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMac = new System.Windows.Forms.MaskedTextBox();
            this.txtFornecedor = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtObservacaoCamera = new System.Windows.Forms.TextBox();
            this.txtPatrimonioCamera = new System.Windows.Forms.TextBox();
            this.lblPatrimonio = new System.Windows.Forms.Label();
            this.txtApontamento = new System.Windows.Forms.TextBox();
            this.lblApontamento = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.txtAcessório = new System.Windows.Forms.TextBox();
            this.lblRecebimento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMac);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.txtObservacaoCamera);
            this.groupBox1.Controls.Add(this.txtPatrimonioCamera);
            this.groupBox1.Controls.Add(this.lblPatrimonio);
            this.groupBox1.Controls.Add(this.txtApontamento);
            this.groupBox1.Controls.Add(this.lblApontamento);
            this.groupBox1.Controls.Add(this.lblOs);
            this.groupBox1.Controls.Add(this.txtAcessório);
            this.groupBox1.Controls.Add(this.lblRecebimento);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblNumeroDeSerie);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // txtMac
            // 
            this.txtMac.BackColor = System.Drawing.SystemColors.Info;
            this.txtMac.Location = new System.Drawing.Point(79, 64);
            this.txtMac.Mask = "CC-CC-CC-CC-CC-CC";
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(202, 20);
            this.txtMac.TabIndex = 2;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtFornecedor.FormattingEnabled = true;
            this.txtFornecedor.Location = new System.Drawing.Point(79, 11);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(202, 21);
            this.txtFornecedor.TabIndex = 0;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Info;
            this.txtProduto.FormattingEnabled = true;
            this.txtProduto.Location = new System.Drawing.Point(79, 38);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(121, 21);
            this.txtProduto.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Registro_de_RMA.Properties.Resources.wipe_97583_960_720;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(303, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 46);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtObservacaoCamera
            // 
            this.txtObservacaoCamera.BackColor = System.Drawing.SystemColors.Info;
            this.txtObservacaoCamera.Location = new System.Drawing.Point(79, 173);
            this.txtObservacaoCamera.Multiline = true;
            this.txtObservacaoCamera.Name = "txtObservacaoCamera";
            this.txtObservacaoCamera.Size = new System.Drawing.Size(275, 45);
            this.txtObservacaoCamera.TabIndex = 5;
            // 
            // txtPatrimonioCamera
            // 
            this.txtPatrimonioCamera.BackColor = System.Drawing.SystemColors.Info;
            this.txtPatrimonioCamera.Location = new System.Drawing.Point(79, 90);
            this.txtPatrimonioCamera.Name = "txtPatrimonioCamera";
            this.txtPatrimonioCamera.Size = new System.Drawing.Size(121, 20);
            this.txtPatrimonioCamera.TabIndex = 3;
            // 
            // lblPatrimonio
            // 
            this.lblPatrimonio.AutoSize = true;
            this.lblPatrimonio.Location = new System.Drawing.Point(6, 93);
            this.lblPatrimonio.Name = "lblPatrimonio";
            this.lblPatrimonio.Size = new System.Drawing.Size(56, 13);
            this.lblPatrimonio.TabIndex = 17;
            this.lblPatrimonio.Text = "Patrimônio";
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
            this.lblApontamento.Location = new System.Drawing.Point(8, 176);
            this.lblApontamento.Name = "lblApontamento";
            this.lblApontamento.Size = new System.Drawing.Size(65, 13);
            this.lblApontamento.TabIndex = 14;
            this.lblApontamento.Text = "Observação";
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Location = new System.Drawing.Point(5, 120);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(53, 13);
            this.lblOs.TabIndex = 12;
            this.lblOs.Text = "Acessório";
            // 
            // txtAcessório
            // 
            this.txtAcessório.BackColor = System.Drawing.SystemColors.Info;
            this.txtAcessório.Location = new System.Drawing.Point(79, 117);
            this.txtAcessório.Multiline = true;
            this.txtAcessório.Name = "txtAcessório";
            this.txtAcessório.Size = new System.Drawing.Size(275, 50);
            this.txtAcessório.TabIndex = 4;
            // 
            // lblRecebimento
            // 
            this.lblRecebimento.AutoSize = true;
            this.lblRecebimento.Location = new System.Drawing.Point(5, 16);
            this.lblRecebimento.Name = "lblRecebimento";
            this.lblRecebimento.Size = new System.Drawing.Size(61, 13);
            this.lblRecebimento.TabIndex = 10;
            this.lblRecebimento.Text = "Fornecedor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(4, 68);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(30, 13);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "MAC";
            // 
            // lblNumeroDeSerie
            // 
            this.lblNumeroDeSerie.AutoSize = true;
            this.lblNumeroDeSerie.Location = new System.Drawing.Point(5, 42);
            this.lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            this.lblNumeroDeSerie.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroDeSerie.TabIndex = 5;
            this.lblNumeroDeSerie.Text = "Produto";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(293, 314);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 38);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 76);
            this.panel1.TabIndex = 6;
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
            // CadastrarCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastrarCamera";
            this.Text = "CadastrarCamera";
            this.Load += new System.EventHandler(this.CadastrarCamera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtObservacaoCamera;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPatrimonioCamera;
        private System.Windows.Forms.TextBox txtApontamento;
        private System.Windows.Forms.Label lblApontamento;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.TextBox txtAcessório;
        private System.Windows.Forms.Label lblRecebimento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPatrimonio;
        private System.Windows.Forms.ComboBox txtProduto;
        private System.Windows.Forms.ComboBox txtFornecedor;
        private System.Windows.Forms.MaskedTextBox txtMac;
    }
}