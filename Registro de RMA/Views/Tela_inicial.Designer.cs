namespace Registro_de_RMA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripSplitButton();
            this.trufixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripSplitButton();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cÇAmeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripSplitButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 76);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Registro_de_RMA.Properties.Resources.PgImg_6_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trufixToolStripMenuItem});
            this.toolStripLabel2.Image = global::Registro_de_RMA.Properties.Resources.Cabinet_icon_1;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(120, 29);
            this.toolStripLabel2.Text = "Registros";
            // 
            // trufixToolStripMenuItem
            // 
            this.trufixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRMToolStripMenuItem1});
            this.trufixToolStripMenuItem.Image = global::Registro_de_RMA.Properties.Resources.maintenance_icon_png_29;
            this.trufixToolStripMenuItem.Name = "trufixToolStripMenuItem";
            this.trufixToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.trufixToolStripMenuItem.Text = "TRUFIX";
            // 
            // aRMToolStripMenuItem1
            // 
            this.aRMToolStripMenuItem1.Image = global::Registro_de_RMA.Properties.Resources.Diagrama_da_placa;
            this.aRMToolStripMenuItem1.Name = "aRMToolStripMenuItem1";
            this.aRMToolStripMenuItem1.Size = new System.Drawing.Size(124, 30);
            this.aRMToolStripMenuItem1.Text = "ARM";
            this.aRMToolStripMenuItem1.Click += new System.EventHandler(this.aRMToolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem,
            this.cÇAmeraToolStripMenuItem});
            this.toolStripTextBox1.Image = global::Registro_de_RMA.Properties.Resources._777081;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(218, 29);
            this.toolStripTextBox1.Text = "Manutenção externa";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sensorToolStripMenuItem.Image = global::Registro_de_RMA.Properties.Resources.sensor_device_542254;
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.sensorToolStripMenuItem.Text = "SENSOR";
            this.sensorToolStripMenuItem.Click += new System.EventHandler(this.sensorToolStripMenuItem_Click);
            // 
            // cÇAmeraToolStripMenuItem
            // 
            this.cÇAmeraToolStripMenuItem.Image = global::Registro_de_RMA.Properties.Resources.Pumatronix;
            this.cÇAmeraToolStripMenuItem.Name = "cÇAmeraToolStripMenuItem";
            this.cÇAmeraToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.cÇAmeraToolStripMenuItem.Text = "CÂMERA";
            this.cÇAmeraToolStripMenuItem.Click += new System.EventHandler(this.cÇAmeraToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Registro_de_RMA.Properties.Resources.logout_icon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 29);
            this.toolStripLabel1.Text = "Sair";
            this.toolStripLabel1.ButtonClick += new System.EventHandler(this.toolStripLabel1_ButtonClick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cÇAmeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem trufixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel1;
    }
}

