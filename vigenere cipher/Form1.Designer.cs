namespace vigenere_cipher
{
    partial class vigenerecipher
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
            this.encryptpanel = new System.Windows.Forms.Panel();
            this.decryptb = new System.Windows.Forms.Button();
            this.encryptb = new System.Windows.Forms.Button();
            this.keytb = new System.Windows.Forms.TextBox();
            this.keyl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.encryptpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptpanel
            // 
            this.encryptpanel.Controls.Add(this.decryptb);
            this.encryptpanel.Controls.Add(this.encryptb);
            this.encryptpanel.Controls.Add(this.keytb);
            this.encryptpanel.Controls.Add(this.keyl);
            this.encryptpanel.Location = new System.Drawing.Point(12, 12);
            this.encryptpanel.Name = "encryptpanel";
            this.encryptpanel.Size = new System.Drawing.Size(363, 86);
            this.encryptpanel.TabIndex = 0;
            // 
            // decryptb
            // 
            this.decryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptb.Location = new System.Drawing.Point(254, 46);
            this.decryptb.Name = "decryptb";
            this.decryptb.Size = new System.Drawing.Size(87, 22);
            this.decryptb.TabIndex = 7;
            this.decryptb.Text = "decrypt";
            this.decryptb.UseVisualStyleBackColor = true;
            this.decryptb.Click += new System.EventHandler(this.decryptb_Click);
            // 
            // encryptb
            // 
            this.encryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptb.Location = new System.Drawing.Point(254, 15);
            this.encryptb.Name = "encryptb";
            this.encryptb.Size = new System.Drawing.Size(87, 25);
            this.encryptb.TabIndex = 2;
            this.encryptb.Text = "encrypt";
            this.encryptb.UseVisualStyleBackColor = true;
            this.encryptb.Click += new System.EventHandler(this.encryptb_Click);
            // 
            // keytb
            // 
            this.keytb.Location = new System.Drawing.Point(57, 32);
            this.keytb.Name = "keytb";
            this.keytb.Size = new System.Drawing.Size(191, 20);
            this.keytb.TabIndex = 3;
            this.keytb.TextChanged += new System.EventHandler(this.keytb_TextChanged);
            // 
            // keyl
            // 
            this.keyl.AutoSize = true;
            this.keyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyl.Location = new System.Drawing.Point(18, 32);
            this.keyl.Name = "keyl";
            this.keyl.Size = new System.Drawing.Size(33, 20);
            this.keyl.TabIndex = 2;
            this.keyl.Text = "key";
            this.keyl.Click += new System.EventHandler(this.keyl_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // vigenerecipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 112);
            this.Controls.Add(this.encryptpanel);
            this.Name = "vigenerecipher";
            this.Text = "vigenere cipher";
            this.Load += new System.EventHandler(this.vigenerecipher_Load);
            this.encryptpanel.ResumeLayout(false);
            this.encryptpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encryptpanel;
        private System.Windows.Forms.TextBox keytb;
        private System.Windows.Forms.Label keyl;
        private System.Windows.Forms.Button decryptb;
        private System.Windows.Forms.Button encryptb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

