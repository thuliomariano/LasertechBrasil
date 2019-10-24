namespace Registro_de_RMA.Views
{
    partial class AtualizarCamera
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatusCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacaoCamera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApontamento = new System.Windows.Forms.TextBox();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.txtIdCamera = new System.Windows.Forms.TextBox();
            this.btnLimparCamera = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarCamera = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(387, 76);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(298, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Editar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatusCamera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimparCamera);
            this.groupBox1.Controls.Add(this.txtObservacaoCamera);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtApontamento);
            this.groupBox1.Controls.Add(this.lblNumeroDeSerie);
            this.groupBox1.Controls.Add(this.txtIdCamera);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbStatusCamera
            // 
            this.cbStatusCamera.BackColor = System.Drawing.SystemColors.Info;
            this.cbStatusCamera.FormattingEnabled = true;
            this.cbStatusCamera.Location = new System.Drawing.Point(58, 39);
            this.cbStatusCamera.Name = "cbStatusCamera";
            this.cbStatusCamera.Size = new System.Drawing.Size(121, 21);
            this.cbStatusCamera.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Status";
            // 
            // txtObservacaoCamera
            // 
            this.txtObservacaoCamera.BackColor = System.Drawing.SystemColors.Info;
            this.txtObservacaoCamera.Location = new System.Drawing.Point(18, 88);
            this.txtObservacaoCamera.Multiline = true;
            this.txtObservacaoCamera.Name = "txtObservacaoCamera";
            this.txtObservacaoCamera.Size = new System.Drawing.Size(332, 43);
            this.txtObservacaoCamera.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Obs:";
            // 
            // txtApontamento
            // 
            this.txtApontamento.BackColor = System.Drawing.SystemColors.Info;
            this.txtApontamento.Location = new System.Drawing.Point(787, 320);
            this.txtApontamento.Name = "txtApontamento";
            this.txtApontamento.Size = new System.Drawing.Size(134, 20);
            this.txtApontamento.TabIndex = 15;
            // 
            // lblNumeroDeSerie
            // 
            this.lblNumeroDeSerie.AutoSize = true;
            this.lblNumeroDeSerie.Location = new System.Drawing.Point(15, 22);
            this.lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            this.lblNumeroDeSerie.Size = new System.Drawing.Size(18, 13);
            this.lblNumeroDeSerie.TabIndex = 5;
            this.lblNumeroDeSerie.Text = "ID";
            // 
            // txtIdCamera
            // 
            this.txtIdCamera.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdCamera.Location = new System.Drawing.Point(58, 15);
            this.txtIdCamera.Name = "txtIdCamera";
            this.txtIdCamera.Size = new System.Drawing.Size(121, 20);
            this.txtIdCamera.TabIndex = 5;
            // 
            // btnLimparCamera
            // 
            this.btnLimparCamera.BackgroundImage = global::Registro_de_RMA.Properties.Resources.wipe_97583_960_720;
            this.btnLimparCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCamera.Location = new System.Drawing.Point(299, 19);
            this.btnLimparCamera.Name = "btnLimparCamera";
            this.btnLimparCamera.Size = new System.Drawing.Size(51, 46);
            this.btnLimparCamera.TabIndex = 26;
            this.btnLimparCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCamera.UseVisualStyleBackColor = true;
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
            // btnCadastrarCamera
            // 
            this.btnCadastrarCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCamera.Location = new System.Drawing.Point(296, 239);
            this.btnCadastrarCamera.Name = "btnCadastrarCamera";
            this.btnCadastrarCamera.Size = new System.Drawing.Size(78, 31);
            this.btnCadastrarCamera.TabIndex = 8;
            this.btnCadastrarCamera.Text = "Atualizar";
            this.btnCadastrarCamera.UseVisualStyleBackColor = true;
            // 
            // AtualizarCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 278);
            this.Controls.Add(this.btnCadastrarCamera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AtualizarCamera";
            this.Text = "AtualizarCamera";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbStatusCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparCamera;
        private System.Windows.Forms.TextBox txtObservacaoCamera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApontamento;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.TextBox txtIdCamera;
        private System.Windows.Forms.Button btnCadastrarCamera;
    }
}