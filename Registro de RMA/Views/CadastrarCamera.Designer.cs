﻿namespace Registro_de_RMA.Views
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtObservacaoCamera = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPatrimonioCamera = new System.Windows.Forms.TextBox();
            this.lblPatrimonio = new System.Windows.Forms.Label();
            this.txtApontamento = new System.Windows.Forms.TextBox();
            this.lblApontamento = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.txtAcessório = new System.Windows.Forms.TextBox();
            this.lblRecebimento = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.txtObservacaoCamera);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtPatrimonioCamera);
            this.groupBox1.Controls.Add(this.lblPatrimonio);
            this.groupBox1.Controls.Add(this.txtApontamento);
            this.groupBox1.Controls.Add(this.lblApontamento);
            this.groupBox1.Controls.Add(this.lblOs);
            this.groupBox1.Controls.Add(this.txtAcessório);
            this.groupBox1.Controls.Add(this.lblRecebimento);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtMac);
            this.groupBox1.Controls.Add(this.lblNumeroDeSerie);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Location = new System.Drawing.Point(37, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Registro_de_RMA.Properties.Resources.wipe_97583_960_720;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(316, 19);
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
            this.txtObservacaoCamera.Location = new System.Drawing.Point(92, 180);
            this.txtObservacaoCamera.Multiline = true;
            this.txtObservacaoCamera.Name = "txtObservacaoCamera";
            this.txtObservacaoCamera.Size = new System.Drawing.Size(275, 45);
            this.txtObservacaoCamera.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(288, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 38);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPatrimonioCamera
            // 
            this.txtPatrimonioCamera.BackColor = System.Drawing.SystemColors.Info;
            this.txtPatrimonioCamera.Location = new System.Drawing.Point(92, 97);
            this.txtPatrimonioCamera.Name = "txtPatrimonioCamera";
            this.txtPatrimonioCamera.Size = new System.Drawing.Size(121, 20);
            this.txtPatrimonioCamera.TabIndex = 3;
            // 
            // lblPatrimonio
            // 
            this.lblPatrimonio.AutoSize = true;
            this.lblPatrimonio.Location = new System.Drawing.Point(21, 100);
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
            this.lblApontamento.Location = new System.Drawing.Point(21, 183);
            this.lblApontamento.Name = "lblApontamento";
            this.lblApontamento.Size = new System.Drawing.Size(65, 13);
            this.lblApontamento.TabIndex = 14;
            this.lblApontamento.Text = "Observação";
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Location = new System.Drawing.Point(18, 127);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(53, 13);
            this.lblOs.TabIndex = 12;
            this.lblOs.Text = "Acessório";
            // 
            // txtAcessório
            // 
            this.txtAcessório.BackColor = System.Drawing.SystemColors.Info;
            this.txtAcessório.Location = new System.Drawing.Point(92, 124);
            this.txtAcessório.Multiline = true;
            this.txtAcessório.Name = "txtAcessório";
            this.txtAcessório.Size = new System.Drawing.Size(275, 50);
            this.txtAcessório.TabIndex = 4;
            // 
            // lblRecebimento
            // 
            this.lblRecebimento.AutoSize = true;
            this.lblRecebimento.Location = new System.Drawing.Point(18, 23);
            this.lblRecebimento.Name = "lblRecebimento";
            this.lblRecebimento.Size = new System.Drawing.Size(61, 13);
            this.lblRecebimento.TabIndex = 10;
            this.lblRecebimento.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtFornecedor.Location = new System.Drawing.Point(92, 20);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(202, 20);
            this.txtFornecedor.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 75);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(30, 13);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "MAC";
            // 
            // txtMac
            // 
            this.txtMac.BackColor = System.Drawing.SystemColors.Info;
            this.txtMac.Location = new System.Drawing.Point(92, 72);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(202, 20);
            this.txtMac.TabIndex = 2;
            // 
            // lblNumeroDeSerie
            // 
            this.lblNumeroDeSerie.AutoSize = true;
            this.lblNumeroDeSerie.Location = new System.Drawing.Point(18, 49);
            this.lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            this.lblNumeroDeSerie.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroDeSerie.TabIndex = 5;
            this.lblNumeroDeSerie.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Info;
            this.txtProduto.Location = new System.Drawing.Point(92, 46);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(121, 20);
            this.txtProduto.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(469, 76);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(297, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cadastrar câmera";
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
            this.ClientSize = new System.Drawing.Size(469, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarCamera";
            this.Text = "CadastrarCamera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPatrimonio;
    }
}