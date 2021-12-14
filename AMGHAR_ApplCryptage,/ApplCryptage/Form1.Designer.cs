
namespace ApplCryptage
{
    partial class apTV
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecrypter = new System.Windows.Forms.TextBox();
            this.txtCrypter = new System.Windows.Forms.TextBox();
            this.BtnCryptage = new System.Windows.Forms.Button();
            this.BtnDecryptage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaCrypPer = new System.Windows.Forms.TextBox();
            this.txtCrypPer = new System.Windows.Forms.TextBox();
            this.txtDecryPers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCryPer = new System.Windows.Forms.Button();
            this.btnDecryPer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCleNet = new System.Windows.Forms.Button();
            this.btnExite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texte Décrypter";
            // 
            // txtDecrypter
            // 
            this.txtDecrypter.Location = new System.Drawing.Point(91, 294);
            this.txtDecrypter.Multiline = true;
            this.txtDecrypter.Name = "txtDecrypter";
            this.txtDecrypter.Size = new System.Drawing.Size(405, 61);
            this.txtDecrypter.TabIndex = 2;
            // 
            // txtCrypter
            // 
            this.txtCrypter.Location = new System.Drawing.Point(91, 162);
            this.txtCrypter.Multiline = true;
            this.txtCrypter.Name = "txtCrypter";
            this.txtCrypter.Size = new System.Drawing.Size(405, 63);
            this.txtCrypter.TabIndex = 3;
            // 
            // BtnCryptage
            // 
            this.BtnCryptage.Font = new System.Drawing.Font("Baskerville Old Face", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCryptage.Location = new System.Drawing.Point(91, 33);
            this.BtnCryptage.Name = "BtnCryptage";
            this.BtnCryptage.Size = new System.Drawing.Size(193, 75);
            this.BtnCryptage.TabIndex = 4;
            this.BtnCryptage.Text = "Cyptage .Net";
            this.BtnCryptage.UseVisualStyleBackColor = true;
            this.BtnCryptage.Click += new System.EventHandler(this.BtnCryptage_Click);
            // 
            // BtnDecryptage
            // 
            this.BtnDecryptage.Font = new System.Drawing.Font("Baskerville Old Face", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecryptage.Location = new System.Drawing.Point(303, 32);
            this.BtnDecryptage.Name = "BtnDecryptage";
            this.BtnDecryptage.Size = new System.Drawing.Size(193, 76);
            this.BtnDecryptage.TabIndex = 5;
            this.BtnDecryptage.Text = "Décryptage .Net";
            this.BtnDecryptage.UseVisualStyleBackColor = true;
            this.BtnDecryptage.Click += new System.EventHandler(this.BtnDecryptage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Texte Crypter";
            // 
            // txtCle
            // 
            this.txtCle.Location = new System.Drawing.Point(806, 352);
            this.txtCle.Name = "txtCle";
            this.txtCle.Size = new System.Drawing.Size(147, 26);
            this.txtCle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(713, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clé";
            // 
            // txtaCrypPer
            // 
            this.txtaCrypPer.Location = new System.Drawing.Point(806, 33);
            this.txtaCrypPer.Multiline = true;
            this.txtaCrypPer.Name = "txtaCrypPer";
            this.txtaCrypPer.Size = new System.Drawing.Size(405, 54);
            this.txtaCrypPer.TabIndex = 10;
            // 
            // txtCrypPer
            // 
            this.txtCrypPer.Location = new System.Drawing.Point(806, 218);
            this.txtCrypPer.Multiline = true;
            this.txtCrypPer.Name = "txtCrypPer";
            this.txtCrypPer.Size = new System.Drawing.Size(405, 49);
            this.txtCrypPer.TabIndex = 11;
            // 
            // txtDecryPers
            // 
            this.txtDecryPers.Location = new System.Drawing.Point(806, 284);
            this.txtDecryPers.Multiline = true;
            this.txtDecryPers.Name = "txtDecryPers";
            this.txtDecryPers.Size = new System.Drawing.Size(405, 47);
            this.txtDecryPers.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(600, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Texte à crypter";
            // 
            // btnCryPer
            // 
            this.btnCryPer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCryPer.Font = new System.Drawing.Font("Baskerville Old Face", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCryPer.Location = new System.Drawing.Point(806, 122);
            this.btnCryPer.Name = "btnCryPer";
            this.btnCryPer.Size = new System.Drawing.Size(193, 75);
            this.btnCryPer.TabIndex = 14;
            this.btnCryPer.Text = "Cyptage personnel";
            this.btnCryPer.UseVisualStyleBackColor = false;
            this.btnCryPer.Click += new System.EventHandler(this.btnCryPer_Click);
            // 
            // btnDecryPer
            // 
            this.btnDecryPer.Font = new System.Drawing.Font("Baskerville Old Face", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryPer.Location = new System.Drawing.Point(1018, 122);
            this.btnDecryPer.Name = "btnDecryPer";
            this.btnDecryPer.Size = new System.Drawing.Size(193, 75);
            this.btnDecryPer.TabIndex = 15;
            this.btnDecryPer.Text = "Décyptage personnel";
            this.btnDecryPer.UseVisualStyleBackColor = true;
            this.btnDecryPer.Click += new System.EventHandler(this.btnDecryPer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Texte Crypter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Texte Décrypter";
            // 
            // btnCleNet
            // 
            this.btnCleNet.Font = new System.Drawing.Font("Baskerville Old Face", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleNet.Location = new System.Drawing.Point(91, 379);
            this.btnCleNet.Name = "btnCleNet";
            this.btnCleNet.Size = new System.Drawing.Size(405, 56);
            this.btnCleNet.TabIndex = 18;
            this.btnCleNet.Text = "Génerer la clé et initialiser";
            this.btnCleNet.UseVisualStyleBackColor = true;
            this.btnCleNet.Click += new System.EventHandler(this.btnCleNet_Click);
            // 
            // btnExite
            // 
            this.btnExite.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExite.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExite.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExite.Location = new System.Drawing.Point(1074, 387);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(137, 48);
            this.btnExite.TabIndex = 19;
            this.btnExite.Text = "Exite";
            this.btnExite.UseVisualStyleBackColor = false;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // apTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1404, 460);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnCleNet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecryPer);
            this.Controls.Add(this.btnCryPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecryPers);
            this.Controls.Add(this.txtCrypPer);
            this.Controls.Add(this.txtaCrypPer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDecryptage);
            this.Controls.Add(this.BtnCryptage);
            this.Controls.Add(this.txtCrypter);
            this.Controls.Add(this.txtDecrypter);
            this.Controls.Add(this.label2);
            this.Name = "apTV";
            this.Text = "AppCryptage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecrypter;
        private System.Windows.Forms.TextBox txtCrypter;
        private System.Windows.Forms.Button BtnCryptage;
        private System.Windows.Forms.Button BtnDecryptage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaCrypPer;
        private System.Windows.Forms.TextBox txtCrypPer;
        private System.Windows.Forms.TextBox txtDecryPers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCryPer;
        private System.Windows.Forms.Button btnDecryPer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCleNet;
        private System.Windows.Forms.Button btnExite;
    }
}

