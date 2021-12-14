using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplCryptage
{
    public partial class apTV : Form
    {
        public apTV()
        {
            InitializeComponent();
        }


        private void BtnCryptage_Click(object sender, EventArgs e)
        {
            txtDecrypter.Text = Convert.ToBase64String(cryptNet.EncryptSym(txtCrypter.Text, cryptNet.cle, cryptNet.iv));
        }

        private void BtnDecryptage_Click(object sender, EventArgs e)
        {
            txtDecrypter.Text = cryptNet.DecryptSym(System.Convert.FromBase64String(txtCrypter.Text), cryptNet.cle, cryptNet.iv);

        }

        private void btnCleNet_Click(object sender, EventArgs e)
        {
            cryptNet.Generate_cle_iv();
        }

        private void btnCryPer_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtaCrypPer.Text);
            string key = txtCle.Text;
            CryptPers.vignereEncrypt(ref s, key);
            txtCrypPer.Text = Convert.ToString(s);

        }

        private void btnDecryPer_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtaCrypPer.Text);
            string key = txtCle.Text;
            CryptPers.VigenereDecrypt(ref s, key);
            txtDecryPers.Text = Convert.ToString(s);

        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    } 

}
