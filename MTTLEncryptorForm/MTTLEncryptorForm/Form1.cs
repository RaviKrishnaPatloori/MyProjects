using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using MttlEncryptor;

namespace MTTLEncryptorForm
{
    public partial class Encryptor : Form
    {
        string strEncryptionKey = string.Empty;
        public Encryptor()
        {
            InitializeComponent();
            //strEncryptionKey = System.Configuration.ConfigurationManager.AppSettings["EncryptKey"];
        }  

        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string strPwd = txtbx_Password.Text;
                string strKey = txtbx_key.Text;
                txtbx_EncryptedPwd.Text = MttlEncryptor.Encryptor.passwordEncrypt(strPwd, strKey);
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Exception Occurred. Please restart the application ";
                
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string strDecryptPwd = txtbx_DecryptPwd.Text;
                string strKey = txtbx_key.Text;
                txtbx_DecryptedPwd.Text = MttlEncryptor.Encryptor.passwordDecrypt(strDecryptPwd, strKey);
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Exception Occurred. Please restart the application ";
                
            }
        }

        private void Encryptor_Load(object sender, EventArgs e)
        {            

        }
      
    }
}
