namespace ecolemusique
{
    partial class Form1
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
            this.txbIdentifiant = new System.Windows.Forms.TextBox();
            this.txbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbIdentifiant
            // 
            this.txbIdentifiant.Location = new System.Drawing.Point(103, 52);
            this.txbIdentifiant.Name = "txbIdentifiant";
            this.txbIdentifiant.Size = new System.Drawing.Size(124, 20);
            this.txbIdentifiant.TabIndex = 1;
            this.txbIdentifiant.TextChanged += new System.EventHandler(this.txbIdentifiant_TextChanged);
            // 
            // txbMotDePasse
            // 
            this.txbMotDePasse.Location = new System.Drawing.Point(103, 104);
            this.txbMotDePasse.Name = "txbMotDePasse";
            this.txbMotDePasse.Size = new System.Drawing.Size(124, 20);
            this.txbMotDePasse.TabIndex = 2;
            this.txbMotDePasse.TextChanged += new System.EventHandler(this.txbMotDePasse_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(22, 164);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(205, 28);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblMotDePasse);
            this.gbLogin.Controls.Add(this.lblIdentifiant);
            this.gbLogin.Controls.Add(this.txbIdentifiant);
            this.gbLogin.Controls.Add(this.btnValider);
            this.gbLogin.Controls.Add(this.txbMotDePasse);
            this.gbLogin.Location = new System.Drawing.Point(61, 45);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(243, 216);
            this.gbLogin.TabIndex = 4;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(19, 52);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 4;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(19, 107);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(78, 13);
            this.lblMotDePasse.TabIndex = 5;
            this.lblMotDePasse.Text = "Mot de Passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(admin@admin.com | admin )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.Text = "Ecole de Musique";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIdentifiant;
        private System.Windows.Forms.TextBox txbMotDePasse;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label label1;
    }
}

