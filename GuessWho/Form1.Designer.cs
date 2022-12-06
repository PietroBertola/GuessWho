namespace GuessWho
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblStatoServer = new System.Windows.Forms.Label();
            this.btnIni = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(735, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIp.Location = new System.Drawing.Point(318, 393);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(174, 20);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "XXXXXXXXXXXXXXX";
            this.lblIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatoServer
            // 
            this.lblStatoServer.AutoSize = true;
            this.lblStatoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStatoServer.Location = new System.Drawing.Point(368, 361);
            this.lblStatoServer.Name = "lblStatoServer";
            this.lblStatoServer.Size = new System.Drawing.Size(74, 17);
            this.lblStatoServer.TabIndex = 3;
            this.lblStatoServer.Text = "STOPPED";
            this.lblStatoServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIni
            // 
            this.btnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnIni.Location = new System.Drawing.Point(344, 314);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(125, 33);
            this.btnIni.TabIndex = 5;
            this.btnIni.Text = "CONNETTI";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(310, 261);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(200, 22);
            this.txtIp.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lblStatoServer);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblStatoServer;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.TextBox txtIp;
    }
}

