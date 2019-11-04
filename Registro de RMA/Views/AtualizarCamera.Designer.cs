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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatusCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacaoCamera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApontamento = new System.Windows.Forms.TextBox();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.txtIdCamera = new System.Windows.Forms.TextBox();
            this.btnAtualizarCamera = new System.Windows.Forms.Button();
            this.btnLimparCamera = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.cbStatusCamera.TabIndex = 1;
            this.cbStatusCamera.SelectedIndexChanged += new System.EventHandler(this.cbStatusCamera_SelectedIndexChanged);
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
            this.txtObservacaoCamera.TabIndex = 2;
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
            this.txtIdCamera.TabIndex = 0;
            // 
            // btnAtualizarCamera
            // 
            this.btnAtualizarCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarCamera.Location = new System.Drawing.Point(297, 169);
            this.btnAtualizarCamera.Name = "btnAtualizarCamera";
            this.btnAtualizarCamera.Size = new System.Drawing.Size(78, 31);
            this.btnAtualizarCamera.TabIndex = 3;
            this.btnAtualizarCamera.Text = "Atualizar";
            this.btnAtualizarCamera.UseVisualStyleBackColor = true;
            this.btnAtualizarCamera.Click += new System.EventHandler(this.btnAtualizarCamera_Click);
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
            this.btnLimparCamera.TabIndex = 4;
            this.btnLimparCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCamera.UseVisualStyleBackColor = true;
            this.btnLimparCamera.Click += new System.EventHandler(this.btnLimparCamera_Click);
            // 
            // AtualizarCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(387, 210);
            this.Controls.Add(this.btnAtualizarCamera);
            this.Controls.Add(this.groupBox1);
            this.Name = "AtualizarCamera";
            this.Text = "AtualizarCamera";
            this.Load += new System.EventHandler(this.AtualizarCamera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbStatusCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparCamera;
        private System.Windows.Forms.TextBox txtObservacaoCamera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApontamento;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.TextBox txtIdCamera;
        private System.Windows.Forms.Button btnAtualizarCamera;
    }
}