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
            this.encryptb = new System.Windows.Forms.Button();
            this.ciphertb = new System.Windows.Forms.TextBox();
            this.cipherl = new System.Windows.Forms.Label();
            this.keytb = new System.Windows.Forms.TextBox();
            this.keyl = new System.Windows.Forms.Label();
            this.plaintextl = new System.Windows.Forms.Label();
            this.encrypttb = new System.Windows.Forms.TextBox();
            this.decryptb = new System.Windows.Forms.Button();
            this.plaintexttb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptpanel
            // 
            this.encryptpanel.Controls.Add(this.decryptb);
            this.encryptpanel.Controls.Add(this.encryptb);
            this.encryptpanel.Controls.Add(this.plaintexttb);
            this.encryptpanel.Controls.Add(this.ciphertb);
            this.encryptpanel.Controls.Add(this.cipherl);
            this.encryptpanel.Controls.Add(this.label4);
            this.encryptpanel.Controls.Add(this.keytb);
            this.encryptpanel.Controls.Add(this.keyl);
            this.encryptpanel.Controls.Add(this.plaintextl);
            this.encryptpanel.Controls.Add(this.encrypttb);
            this.encryptpanel.Location = new System.Drawing.Point(12, 12);
            this.encryptpanel.Name = "encryptpanel";
            this.encryptpanel.Size = new System.Drawing.Size(375, 231);
            this.encryptpanel.TabIndex = 0;
            // 
            // encryptb
            // 
            this.encryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptb.Location = new System.Drawing.Point(22, 82);
            this.encryptb.Name = "encryptb";
            this.encryptb.Size = new System.Drawing.Size(165, 41);
            this.encryptb.TabIndex = 2;
            this.encryptb.Text = "encrypt";
            this.encryptb.UseVisualStyleBackColor = true;
            this.encryptb.Click += new System.EventHandler(this.encryptb_Click);
            // 
            // ciphertb
            // 
            this.ciphertb.Location = new System.Drawing.Point(101, 148);
            this.ciphertb.Name = "ciphertb";
            this.ciphertb.Size = new System.Drawing.Size(255, 20);
            this.ciphertb.TabIndex = 5;
            // 
            // cipherl
            // 
            this.cipherl.AutoSize = true;
            this.cipherl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherl.Location = new System.Drawing.Point(18, 146);
            this.cipherl.Name = "cipherl";
            this.cipherl.Size = new System.Drawing.Size(78, 20);
            this.cipherl.TabIndex = 4;
            this.cipherl.Text = "ciphertext";
            // 
            // keytb
            // 
            this.keytb.Location = new System.Drawing.Point(101, 44);
            this.keytb.Name = "keytb";
            this.keytb.Size = new System.Drawing.Size(255, 20);
            this.keytb.TabIndex = 3;
            // 
            // keyl
            // 
            this.keyl.AutoSize = true;
            this.keyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyl.Location = new System.Drawing.Point(18, 44);
            this.keyl.Name = "keyl";
            this.keyl.Size = new System.Drawing.Size(33, 20);
            this.keyl.TabIndex = 2;
            this.keyl.Text = "key";
            // 
            // plaintextl
            // 
            this.plaintextl.AutoSize = true;
            this.plaintextl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintextl.Location = new System.Drawing.Point(18, 16);
            this.plaintextl.Name = "plaintextl";
            this.plaintextl.Size = new System.Drawing.Size(68, 20);
            this.plaintextl.TabIndex = 1;
            this.plaintextl.Text = "plaintext";
            // 
            // encrypttb
            // 
            this.encrypttb.Location = new System.Drawing.Point(101, 18);
            this.encrypttb.Name = "encrypttb";
            this.encrypttb.Size = new System.Drawing.Size(255, 20);
            this.encrypttb.TabIndex = 0;
            // 
            // decryptb
            // 
            this.decryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptb.Location = new System.Drawing.Point(193, 82);
            this.decryptb.Name = "decryptb";
            this.decryptb.Size = new System.Drawing.Size(163, 41);
            this.decryptb.TabIndex = 7;
            this.decryptb.Text = "decrypt";
            this.decryptb.UseVisualStyleBackColor = true;
            this.decryptb.Click += new System.EventHandler(this.decryptb_Click);
            // 
            // plaintexttb
            // 
            this.plaintexttb.Location = new System.Drawing.Point(101, 174);
            this.plaintexttb.Name = "plaintexttb";
            this.plaintexttb.Size = new System.Drawing.Size(255, 20);
            this.plaintexttb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "plaintext";
            // 
            // vigenerecipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 252);
            this.Controls.Add(this.encryptpanel);
            this.Name = "vigenerecipher";
            this.Text = "vigenere cipher";
            this.encryptpanel.ResumeLayout(false);
            this.encryptpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encryptpanel;
        private System.Windows.Forms.TextBox ciphertb;
        private System.Windows.Forms.Label cipherl;
        private System.Windows.Forms.TextBox keytb;
        private System.Windows.Forms.Label keyl;
        private System.Windows.Forms.Label plaintextl;
        private System.Windows.Forms.TextBox encrypttb;
        private System.Windows.Forms.TextBox plaintexttb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encryptb;
        private System.Windows.Forms.Button decryptb;
    }
}

