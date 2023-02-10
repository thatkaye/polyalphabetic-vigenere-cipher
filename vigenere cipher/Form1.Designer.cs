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
            this.decryptpanel = new System.Windows.Forms.Panel();
            this.encrypttb = new System.Windows.Forms.TextBox();
            this.plaintextl = new System.Windows.Forms.Label();
            this.keyl = new System.Windows.Forms.Label();
            this.keytb = new System.Windows.Forms.TextBox();
            this.cipherl = new System.Windows.Forms.Label();
            this.ciphertb = new System.Windows.Forms.TextBox();
            this.encryptl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plaintexttb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keydtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ciphertexttb = new System.Windows.Forms.TextBox();
            this.encryptb = new System.Windows.Forms.Button();
            this.decryptb = new System.Windows.Forms.Button();
            this.encryptpanel.SuspendLayout();
            this.decryptpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptpanel
            // 
            this.encryptpanel.Controls.Add(this.encryptb);
            this.encryptpanel.Controls.Add(this.encryptl);
            this.encryptpanel.Controls.Add(this.ciphertb);
            this.encryptpanel.Controls.Add(this.cipherl);
            this.encryptpanel.Controls.Add(this.keytb);
            this.encryptpanel.Controls.Add(this.keyl);
            this.encryptpanel.Controls.Add(this.plaintextl);
            this.encryptpanel.Controls.Add(this.encrypttb);
            this.encryptpanel.Location = new System.Drawing.Point(12, 12);
            this.encryptpanel.Name = "encryptpanel";
            this.encryptpanel.Size = new System.Drawing.Size(375, 231);
            this.encryptpanel.TabIndex = 0;
            // 
            // decryptpanel
            // 
            this.decryptpanel.Controls.Add(this.decryptb);
            this.decryptpanel.Controls.Add(this.label1);
            this.decryptpanel.Controls.Add(this.plaintexttb);
            this.decryptpanel.Controls.Add(this.ciphertexttb);
            this.decryptpanel.Controls.Add(this.label2);
            this.decryptpanel.Controls.Add(this.label4);
            this.decryptpanel.Controls.Add(this.keydtb);
            this.decryptpanel.Controls.Add(this.label3);
            this.decryptpanel.Location = new System.Drawing.Point(393, 12);
            this.decryptpanel.Name = "decryptpanel";
            this.decryptpanel.Size = new System.Drawing.Size(375, 231);
            this.decryptpanel.TabIndex = 1;
            // 
            // encrypttb
            // 
            this.encrypttb.Location = new System.Drawing.Point(101, 63);
            this.encrypttb.Name = "encrypttb";
            this.encrypttb.Size = new System.Drawing.Size(255, 20);
            this.encrypttb.TabIndex = 0;
            // 
            // plaintextl
            // 
            this.plaintextl.AutoSize = true;
            this.plaintextl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintextl.Location = new System.Drawing.Point(18, 61);
            this.plaintextl.Name = "plaintextl";
            this.plaintextl.Size = new System.Drawing.Size(68, 20);
            this.plaintextl.TabIndex = 1;
            this.plaintextl.Text = "plaintext";
            // 
            // keyl
            // 
            this.keyl.AutoSize = true;
            this.keyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyl.Location = new System.Drawing.Point(18, 98);
            this.keyl.Name = "keyl";
            this.keyl.Size = new System.Drawing.Size(33, 20);
            this.keyl.TabIndex = 2;
            this.keyl.Text = "key";
            // 
            // keytb
            // 
            this.keytb.Location = new System.Drawing.Point(101, 98);
            this.keytb.Name = "keytb";
            this.keytb.Size = new System.Drawing.Size(255, 20);
            this.keytb.TabIndex = 3;
            // 
            // cipherl
            // 
            this.cipherl.AutoSize = true;
            this.cipherl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherl.Location = new System.Drawing.Point(18, 132);
            this.cipherl.Name = "cipherl";
            this.cipherl.Size = new System.Drawing.Size(78, 20);
            this.cipherl.TabIndex = 4;
            this.cipherl.Text = "ciphertext";
            // 
            // ciphertb
            // 
            this.ciphertb.Location = new System.Drawing.Point(101, 134);
            this.ciphertb.Name = "ciphertb";
            this.ciphertb.Size = new System.Drawing.Size(255, 20);
            this.ciphertb.TabIndex = 5;
            // 
            // encryptl
            // 
            this.encryptl.AutoSize = true;
            this.encryptl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptl.Location = new System.Drawing.Point(146, 17);
            this.encryptl.Name = "encryptl";
            this.encryptl.Size = new System.Drawing.Size(91, 29);
            this.encryptl.TabIndex = 6;
            this.encryptl.Text = "encrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "decrypt";
            // 
            // plaintexttb
            // 
            this.plaintexttb.Location = new System.Drawing.Point(105, 134);
            this.plaintexttb.Name = "plaintexttb";
            this.plaintexttb.Size = new System.Drawing.Size(255, 20);
            this.plaintexttb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ciphertext";
            // 
            // keydtb
            // 
            this.keydtb.Location = new System.Drawing.Point(105, 98);
            this.keydtb.Name = "keydtb";
            this.keydtb.Size = new System.Drawing.Size(255, 20);
            this.keydtb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "plaintext";
            // 
            // ciphertexttb
            // 
            this.ciphertexttb.Location = new System.Drawing.Point(105, 63);
            this.ciphertexttb.Name = "ciphertexttb";
            this.ciphertexttb.Size = new System.Drawing.Size(255, 20);
            this.ciphertexttb.TabIndex = 7;
            // 
            // encryptb
            // 
            this.encryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptb.Location = new System.Drawing.Point(151, 172);
            this.encryptb.Name = "encryptb";
            this.encryptb.Size = new System.Drawing.Size(86, 41);
            this.encryptb.TabIndex = 2;
            this.encryptb.Text = "encrypt";
            this.encryptb.UseVisualStyleBackColor = true;
            this.encryptb.Click += new System.EventHandler(this.encryptb_Click);
            // 
            // decryptb
            // 
            this.decryptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptb.Location = new System.Drawing.Point(155, 172);
            this.decryptb.Name = "decryptb";
            this.decryptb.Size = new System.Drawing.Size(87, 41);
            this.decryptb.TabIndex = 7;
            this.decryptb.Text = "decrypt";
            this.decryptb.UseVisualStyleBackColor = true;
            this.decryptb.Click += new System.EventHandler(this.decryptb_Click);
            // 
            // vigenerecipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 264);
            this.Controls.Add(this.decryptpanel);
            this.Controls.Add(this.encryptpanel);
            this.Name = "vigenerecipher";
            this.Text = "vigenere cipher";
            this.encryptpanel.ResumeLayout(false);
            this.encryptpanel.PerformLayout();
            this.decryptpanel.ResumeLayout(false);
            this.decryptpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encryptpanel;
        private System.Windows.Forms.Panel decryptpanel;
        private System.Windows.Forms.Label encryptl;
        private System.Windows.Forms.TextBox ciphertb;
        private System.Windows.Forms.Label cipherl;
        private System.Windows.Forms.TextBox keytb;
        private System.Windows.Forms.Label keyl;
        private System.Windows.Forms.Label plaintextl;
        private System.Windows.Forms.TextBox encrypttb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plaintexttb;
        private System.Windows.Forms.TextBox ciphertexttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keydtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encryptb;
        private System.Windows.Forms.Button decryptb;
    }
}

