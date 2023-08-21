namespace ServerAndClientApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnAyril = new System.Windows.Forms.Button();
            this.txtGelenMesaj = new System.Windows.Forms.TextBox();
            this.txtGonderilenMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(58, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(151, 22);
            this.txtIP.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(283, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(151, 22);
            this.txtPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(453, 12);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(101, 35);
            this.btnBaglan.TabIndex = 5;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnAyril
            // 
            this.btnAyril.Location = new System.Drawing.Point(560, 12);
            this.btnAyril.Name = "btnAyril";
            this.btnAyril.Size = new System.Drawing.Size(101, 35);
            this.btnAyril.TabIndex = 6;
            this.btnAyril.Text = "Ayrıl";
            this.btnAyril.UseVisualStyleBackColor = true;
            this.btnAyril.Click += new System.EventHandler(this.btnAyril_Click);
            // 
            // txtGelenMesaj
            // 
            this.txtGelenMesaj.Location = new System.Drawing.Point(24, 53);
            this.txtGelenMesaj.Multiline = true;
            this.txtGelenMesaj.Name = "txtGelenMesaj";
            this.txtGelenMesaj.Size = new System.Drawing.Size(637, 176);
            this.txtGelenMesaj.TabIndex = 7;
            // 
            // txtGonderilenMesaj
            // 
            this.txtGonderilenMesaj.Location = new System.Drawing.Point(24, 235);
            this.txtGonderilenMesaj.Multiline = true;
            this.txtGonderilenMesaj.Name = "txtGonderilenMesaj";
            this.txtGonderilenMesaj.Size = new System.Drawing.Size(530, 35);
            this.txtGonderilenMesaj.TabIndex = 8;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(560, 235);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(101, 35);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 282);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtGonderilenMesaj);
            this.Controls.Add(this.txtGelenMesaj);
            this.Controls.Add(this.btnAyril);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnAyril;
        private System.Windows.Forms.TextBox txtGelenMesaj;
        private System.Windows.Forms.TextBox txtGonderilenMesaj;
        private System.Windows.Forms.Button btnGonder;
    }
}

