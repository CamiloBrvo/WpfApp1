namespace ecolemusique
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouterModifierInstrument = new System.Windows.Forms.Button();
            this.btnModifierAjouterQF = new System.Windows.Forms.Button();
            this.btnSaisieCouts = new System.Windows.Forms.Button();
            this.btnModifierAjouterCours = new System.Windows.Forms.Button();
            this.btnAffichageInscriptionsetEleves = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnAffichageInscriptionsetEleves);
            this.groupBox1.Controls.Add(this.btnModifierAjouterCours);
            this.groupBox1.Controls.Add(this.btnSaisieCouts);
            this.groupBox1.Controls.Add(this.btnModifierAjouterQF);
            this.groupBox1.Controls.Add(this.btnAjouterModifierInstrument);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Home";
            // 
            // btnAjouterModifierInstrument
            // 
            this.btnAjouterModifierInstrument.Location = new System.Drawing.Point(21, 60);
            this.btnAjouterModifierInstrument.Name = "btnAjouterModifierInstrument";
            this.btnAjouterModifierInstrument.Size = new System.Drawing.Size(187, 41);
            this.btnAjouterModifierInstrument.TabIndex = 0;
            this.btnAjouterModifierInstrument.Text = "Modifier / Ajouter un instrument";
            this.btnAjouterModifierInstrument.UseVisualStyleBackColor = true;
            this.btnAjouterModifierInstrument.Click += new System.EventHandler(this.btnAjouterModifierInstrument_Click);
            // 
            // btnModifierAjouterQF
            // 
            this.btnModifierAjouterQF.Location = new System.Drawing.Point(21, 124);
            this.btnModifierAjouterQF.Name = "btnModifierAjouterQF";
            this.btnModifierAjouterQF.Size = new System.Drawing.Size(187, 41);
            this.btnModifierAjouterQF.TabIndex = 1;
            this.btnModifierAjouterQF.Text = "Modifier / Ajouter un Quotien Familial";
            this.btnModifierAjouterQF.UseVisualStyleBackColor = true;
            this.btnModifierAjouterQF.Click += new System.EventHandler(this.btnModifierAjouterQF_Click);
            // 
            // btnSaisieCouts
            // 
            this.btnSaisieCouts.Location = new System.Drawing.Point(223, 60);
            this.btnSaisieCouts.Name = "btnSaisieCouts";
            this.btnSaisieCouts.Size = new System.Drawing.Size(187, 41);
            this.btnSaisieCouts.TabIndex = 2;
            this.btnSaisieCouts.Text = "Saisie Coûts";
            this.btnSaisieCouts.UseVisualStyleBackColor = true;
            this.btnSaisieCouts.Click += new System.EventHandler(this.btnSaisieCouts_Click);
            // 
            // btnModifierAjouterCours
            // 
            this.btnModifierAjouterCours.Location = new System.Drawing.Point(223, 124);
            this.btnModifierAjouterCours.Name = "btnModifierAjouterCours";
            this.btnModifierAjouterCours.Size = new System.Drawing.Size(187, 41);
            this.btnModifierAjouterCours.TabIndex = 3;
            this.btnModifierAjouterCours.Text = "Modifier / Ajouter un cours";
            this.btnModifierAjouterCours.UseVisualStyleBackColor = true;
            this.btnModifierAjouterCours.Click += new System.EventHandler(this.btnModifierAjouterCours_Click);
            // 
            // btnAffichageInscriptionsetEleves
            // 
            this.btnAffichageInscriptionsetEleves.Location = new System.Drawing.Point(120, 186);
            this.btnAffichageInscriptionsetEleves.Name = "btnAffichageInscriptionsetEleves";
            this.btnAffichageInscriptionsetEleves.Size = new System.Drawing.Size(187, 41);
            this.btnAffichageInscriptionsetEleves.TabIndex = 4;
            this.btnAffichageInscriptionsetEleves.Text = "Affichage des Inscriptions et des élèves";
            this.btnAffichageInscriptionsetEleves.UseVisualStyleBackColor = true;
            this.btnAffichageInscriptionsetEleves.Click += new System.EventHandler(this.btnAffichageInscriptionsetEleves_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(177, 247);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAffichageInscriptionsetEleves;
        private System.Windows.Forms.Button btnModifierAjouterCours;
        private System.Windows.Forms.Button btnSaisieCouts;
        private System.Windows.Forms.Button btnModifierAjouterQF;
        private System.Windows.Forms.Button btnAjouterModifierInstrument;
    }
}