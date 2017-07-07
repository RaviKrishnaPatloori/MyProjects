namespace MTTLEncryptorForm
{
    partial class Encryptor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.txtbx_EncryptedPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.txtbx_DecryptedPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_DecryptPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text for encryption :";
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Location = new System.Drawing.Point(223, 82);
            this.txtbx_Password.Multiline = true;
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(233, 20);
            this.txtbx_Password.TabIndex = 1;
            // 
            // txtbx_EncryptedPwd
            // 
            this.txtbx_EncryptedPwd.Location = new System.Drawing.Point(223, 132);
            this.txtbx_EncryptedPwd.Multiline = true;
            this.txtbx_EncryptedPwd.Name = "txtbx_EncryptedPwd";
            this.txtbx_EncryptedPwd.Size = new System.Drawing.Size(233, 52);
            this.txtbx_EncryptedPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted text";
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.Location = new System.Drawing.Point(462, 80);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(87, 23);
            this.Encrypt.TabIndex = 4;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.Location = new System.Drawing.Point(462, 222);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(87, 23);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // txtbx_DecryptedPwd
            // 
            this.txtbx_DecryptedPwd.Location = new System.Drawing.Point(223, 284);
            this.txtbx_DecryptedPwd.Multiline = true;
            this.txtbx_DecryptedPwd.Name = "txtbx_DecryptedPwd";
            this.txtbx_DecryptedPwd.Size = new System.Drawing.Size(233, 57);
            this.txtbx_DecryptedPwd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted text";
            // 
            // txtbx_DecryptPwd
            // 
            this.txtbx_DecryptPwd.Location = new System.Drawing.Point(223, 222);
            this.txtbx_DecryptPwd.Multiline = true;
            this.txtbx_DecryptPwd.Name = "txtbx_DecryptPwd";
            this.txtbx_DecryptPwd.Size = new System.Drawing.Size(233, 56);
            this.txtbx_DecryptPwd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter text for decryption";
            // 
            // txtbx_key
            // 
            this.txtbx_key.Location = new System.Drawing.Point(223, 43);
            this.txtbx_key.Multiline = true;
            this.txtbx_key.Name = "txtbx_key";
            this.txtbx_key.Size = new System.Drawing.Size(233, 20);
            this.txtbx_key.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter text for Encrypt/Decrypt key:";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(132, 337);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 12;
            // 
            // Encryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 369);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtbx_key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.txtbx_DecryptedPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_DecryptPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.txtbx_EncryptedPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Encryptor";
            this.Text = "Advanced Password Encryption System";
            this.Load += new System.EventHandler(this.Encryptor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.TextBox txtbx_EncryptedPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox txtbx_DecryptedPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_DecryptPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

