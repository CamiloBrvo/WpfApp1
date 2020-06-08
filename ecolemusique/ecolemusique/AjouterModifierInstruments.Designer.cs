namespace ecolemusique
{
    partial class AjouterModifierInstruments
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
            this.gbMofification = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModifierInstrument = new System.Windows.Forms.ComboBox();
            this.txbModifierInstrument = new System.Windows.Forms.TextBox();
            this.btnModifierInstrument = new System.Windows.Forms.Button();
            this.gbAjouts = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAjoutInstrument = new System.Windows.Forms.TextBox();
            this.btnAjoutInstrument = new System.Windows.Forms.Button();
            this.gbSuppresion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupprimerInstrument = new System.Windows.Forms.ComboBox();
            this.btnSupprimerInstrument = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMofification.SuspendLayout();
            this.gbAjouts.SuspendLayout();
            this.gbSuppresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMofification
            // 
            this.gbMofification.Controls.Add(this.label4);
            this.gbMofification.Controls.Add(this.label3);
            this.gbMofification.Controls.Add(this.cbModifierInstrument);
            this.gbMofification.Controls.Add(this.txbModifierInstrument);
            this.gbMofification.Controls.Add(this.btnModifierInstrument);
            this.gbMofification.Location = new System.Drawing.Point(12, 48);
            this.gbMofification.Name = "gbMofification";
            this.gbMofification.Size = new System.Drawing.Size(207, 271);
            this.gbMofification.TabIndex = 0;
            this.gbMofification.TabStop = false;
            this.gbMofification.Text = "Modification d\'un Instrument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selectionnez un instrument :";
            // 
            // cbModifierInstrument
            // 
            this.cbModifierInstrument.FormattingEnabled = true;
            this.cbModifierInstrument.Location = new System.Drawing.Point(25, 73);
            this.cbModifierInstrument.Name = "cbModifierInstrument";
            this.cbModifierInstrument.Size = new System.Drawing.Size(145, 21);
            this.cbModifierInstrument.TabIndex = 3;
            // 
            // txbModifierInstrument
            // 
            this.txbModifierInstrument.Location = new System.Drawing.Point(25, 139);
            this.txbModifierInstrument.Name = "txbModifierInstrument";
            this.txbModifierInstrument.Size = new System.Drawing.Size(145, 20);
            this.txbModifierInstrument.TabIndex = 2;
            // 
            // btnModifierInstrument
            // 
            this.btnModifierInstrument.Location = new System.Drawing.Point(25, 197);
            this.btnModifierInstrument.Name = "btnModifierInstrument";
            this.btnModifierInstrument.Size = new System.Drawing.Size(145, 41);
            this.btnModifierInstrument.TabIndex = 1;
            this.btnModifierInstrument.Text = "Valider la modification";
            this.btnModifierInstrument.UseVisualStyleBackColor = true;
            this.btnModifierInstrument.Click += new System.EventHandler(this.btnModifierInstrument_Click);
            // 
            // gbAjouts
            // 
            this.gbAjouts.Controls.Add(this.label1);
            this.gbAjouts.Controls.Add(this.txbAjoutInstrument);
            this.gbAjouts.Controls.Add(this.btnAjoutInstrument);
            this.gbAjouts.Location = new System.Drawing.Point(262, 48);
            this.gbAjouts.Name = "gbAjouts";
            this.gbAjouts.Size = new System.Drawing.Size(207, 271);
            this.gbAjouts.TabIndex = 1;
            this.gbAjouts.TabStop = false;
            this.gbAjouts.Text = "Ajouts d\'un Instrument";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rentrez l\'instrument :";
            // 
            // txbAjoutInstrument
            // 
            this.txbAjoutInstrument.Location = new System.Drawing.Point(31, 107);
            this.txbAjoutInstrument.Name = "txbAjoutInstrument";
            this.txbAjoutInstrument.Size = new System.Drawing.Size(145, 20);
            this.txbAjoutInstrument.TabIndex = 1;
            // 
            // btnAjoutInstrument
            // 
            this.btnAjoutInstrument.Location = new System.Drawing.Point(31, 197);
            this.btnAjoutInstrument.Name = "btnAjoutInstrument";
            this.btnAjoutInstrument.Size = new System.Drawing.Size(145, 41);
            this.btnAjoutInstrument.TabIndex = 0;
            this.btnAjoutInstrument.Text = "Ajouter un instrument";
            this.btnAjoutInstrument.UseVisualStyleBackColor = true;
            this.btnAjoutInstrument.Click += new System.EventHandler(this.btnAjoutInstrument_Click);
            // 
            // gbSuppresion
            // 
            this.gbSuppresion.Controls.Add(this.label2);
            this.gbSuppresion.Controls.Add(this.cbSupprimerInstrument);
            this.gbSuppresion.Controls.Add(this.btnSupprimerInstrument);
            this.gbSuppresion.Location = new System.Drawing.Point(512, 48);
            this.gbSuppresion.Name = "gbSuppresion";
            this.gbSuppresion.Size = new System.Drawing.Size(212, 271);
            this.gbSuppresion.TabIndex = 2;
            this.gbSuppresion.TabStop = false;
            this.gbSuppresion.Text = "Suppresion d\'un Instrument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selectionnez un instrument :";
            // 
            // cbSupprimerInstrument
            // 
            this.cbSupprimerInstrument.FormattingEnabled = true;
            this.cbSupprimerInstrument.Location = new System.Drawing.Point(38, 106);
            this.cbSupprimerInstrument.Name = "cbSupprimerInstrument";
            this.cbSupprimerInstrument.Size = new System.Drawing.Size(145, 21);
            this.cbSupprimerInstrument.TabIndex = 1;
            // 
            // btnSupprimerInstrument
            // 
            this.btnSupprimerInstrument.Location = new System.Drawing.Point(38, 197);
            this.btnSupprimerInstrument.Name = "btnSupprimerInstrument";
            this.btnSupprimerInstrument.Size = new System.Drawing.Size(145, 41);
            this.btnSupprimerInstrument.TabIndex = 0;
            this.btnSupprimerInstrument.Text = "Supprimer un instrument";
            this.btnSupprimerInstrument.UseVisualStyleBackColor = true;
            this.btnSupprimerInstrument.Click += new System.EventHandler(this.btnSupprimerInstrument_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(312, 340);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 30);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enregistrer la modification :";
            // 
            // AjouterModifierInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 382);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.gbSuppresion);
            this.Controls.Add(this.gbAjouts);
            this.Controls.Add(this.gbMofification);
            this.Name = "AjouterModifierInstruments";
            this.Text = "Ecole de Musique";
            this.gbMofification.ResumeLayout(false);
            this.gbMofification.PerformLayout();
            this.gbAjouts.ResumeLayout(false);
            this.gbAjouts.PerformLayout();
            this.gbSuppresion.ResumeLayout(false);
            this.gbSuppresion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMofification;
        private System.Windows.Forms.GroupBox gbAjouts;
        private System.Windows.Forms.Button btnAjoutInstrument;
        private System.Windows.Forms.GroupBox gbSuppresion;
        private System.Windows.Forms.Button btnSupprimerInstrument;
        private System.Windows.Forms.Button btnModifierInstrument;
        private System.Windows.Forms.TextBox txbModifierInstrument;
        private System.Windows.Forms.TextBox txbAjoutInstrument;
        private System.Windows.Forms.ComboBox cbModifierInstrument;
        private System.Windows.Forms.ComboBox cbSupprimerInstrument;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}