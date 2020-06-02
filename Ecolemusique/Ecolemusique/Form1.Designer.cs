namespace Ecolemusique
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
            this.btnValidezAjoutsI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidezModifI = new System.Windows.Forms.Button();
            this.txbmodificationI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIstrument = new System.Windows.Forms.ComboBox();
            this.txbNomI = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxsuprimerI = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.txbNomI.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidezAjoutsI
            // 
            this.btnValidezAjoutsI.Location = new System.Drawing.Point(72, 340);
            this.btnValidezAjoutsI.Name = "btnValidezAjoutsI";
            this.btnValidezAjoutsI.Size = new System.Drawing.Size(261, 72);
            this.btnValidezAjoutsI.TabIndex = 0;
            this.btnValidezAjoutsI.Text = "Ajoutez un instrument";
            this.btnValidezAjoutsI.UseVisualStyleBackColor = true;
            this.btnValidezAjoutsI.Click += new System.EventHandler(this.btnValidezAjoutsI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnValidezModifI);
            this.groupBox1.Controls.Add(this.txbmodificationI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxIstrument);
            this.groupBox1.Location = new System.Drawing.Point(70, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification d\'un instrument";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnValidezModifI
            // 
            this.btnValidezModifI.Location = new System.Drawing.Point(64, 334);
            this.btnValidezModifI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidezModifI.Name = "btnValidezModifI";
            this.btnValidezModifI.Size = new System.Drawing.Size(258, 72);
            this.btnValidezModifI.TabIndex = 4;
            this.btnValidezModifI.Text = "Validez la modification";
            this.btnValidezModifI.UseVisualStyleBackColor = true;
            this.btnValidezModifI.Click += new System.EventHandler(this.btnValidezModifI_Click);
            // 
            // txbmodificationI
            // 
            this.txbmodificationI.Location = new System.Drawing.Point(64, 244);
            this.txbmodificationI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbmodificationI.Name = "txbmodificationI";
            this.txbmodificationI.Size = new System.Drawing.Size(258, 26);
            this.txbmodificationI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selectionnez l\'instrument à modifier :";
            // 
            // cbxIstrument
            // 
            this.cbxIstrument.FormattingEnabled = true;
            this.cbxIstrument.Location = new System.Drawing.Point(64, 121);
            this.cbxIstrument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIstrument.Name = "cbxIstrument";
            this.cbxIstrument.Size = new System.Drawing.Size(258, 28);
            this.cbxIstrument.TabIndex = 0;
            // 
            // txbNomI
            // 
            this.txbNomI.Controls.Add(this.label2);
            this.txbNomI.Controls.Add(this.textBox1);
            this.txbNomI.Controls.Add(this.btnValidezAjoutsI);
            this.txbNomI.Location = new System.Drawing.Point(544, 74);
            this.txbNomI.Name = "txbNomI";
            this.txbNomI.Size = new System.Drawing.Size(416, 478);
            this.txbNomI.TabIndex = 3;
            this.txbNomI.TabStop = false;
            this.txbNomI.Text = "Ajouts d\'un instrument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rentrez l\'instruments :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 194);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 26);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbxsuprimerI);
            this.groupBox3.Controls.Add(this.btnSupprimer);
            this.groupBox3.Location = new System.Drawing.Point(1002, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(376, 477);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suppresion d\'un instrument";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectionnez un instruments :";
            // 
            // cbxsuprimerI
            // 
            this.cbxsuprimerI.FormattingEnabled = true;
            this.cbxsuprimerI.Location = new System.Drawing.Point(69, 177);
            this.cbxsuprimerI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxsuprimerI.Name = "cbxsuprimerI";
            this.cbxsuprimerI.Size = new System.Drawing.Size(234, 28);
            this.cbxsuprimerI.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(69, 325);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(236, 72);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer cet instrument";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enregistrer la modification :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txbNomI);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txbNomI.ResumeLayout(false);
            this.txbNomI.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidezAjoutsI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox txbNomI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxsuprimerI;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxIstrument;
        private System.Windows.Forms.Button btnValidezModifI;
        private System.Windows.Forms.TextBox txbmodificationI;
        private System.Windows.Forms.Label label4;
    }
}

