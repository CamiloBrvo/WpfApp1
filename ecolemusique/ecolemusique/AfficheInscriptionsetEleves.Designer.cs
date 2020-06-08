namespace ecolemusique
{
    partial class AfficheInscriptionsetEleves
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
            this.btnValiderInscriptionByCours = new System.Windows.Forms.Button();
            this.cbByCours = new System.Windows.Forms.ComboBox();
            this.btnRechargerTabInscriptions = new System.Windows.Forms.Button();
            this.dgvInscriptions = new System.Windows.Forms.DataGridView();
            this.inscriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTrierByResponsables = new System.Windows.Forms.Button();
            this.cbResponsables = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrierByAgePetit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrierByAgeGrand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRechargerTabEleves = new System.Windows.Forms.Button();
            this.dgvEleves = new System.Windows.Forms.DataGridView();
            this.eleves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResponsables2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResponsables2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResponsables2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbResponsables2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnValiderInscriptionByCours);
            this.groupBox1.Controls.Add(this.cbByCours);
            this.groupBox1.Controls.Add(this.btnRechargerTabInscriptions);
            this.groupBox1.Controls.Add(this.dgvInscriptions);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage Inscriptions";
            // 
            // btnValiderInscriptionByCours
            // 
            this.btnValiderInscriptionByCours.Location = new System.Drawing.Point(6, 91);
            this.btnValiderInscriptionByCours.Name = "btnValiderInscriptionByCours";
            this.btnValiderInscriptionByCours.Size = new System.Drawing.Size(121, 32);
            this.btnValiderInscriptionByCours.TabIndex = 4;
            this.btnValiderInscriptionByCours.Text = "Valider";
            this.btnValiderInscriptionByCours.UseVisualStyleBackColor = true;
            this.btnValiderInscriptionByCours.Click += new System.EventHandler(this.btnValiderInscriptionByCours_Click);
            // 
            // cbByCours
            // 
            this.cbByCours.FormattingEnabled = true;
            this.cbByCours.Location = new System.Drawing.Point(6, 53);
            this.cbByCours.Name = "cbByCours";
            this.cbByCours.Size = new System.Drawing.Size(121, 21);
            this.cbByCours.TabIndex = 3;
            // 
            // btnRechargerTabInscriptions
            // 
            this.btnRechargerTabInscriptions.Location = new System.Drawing.Point(164, 304);
            this.btnRechargerTabInscriptions.Name = "btnRechargerTabInscriptions";
            this.btnRechargerTabInscriptions.Size = new System.Drawing.Size(144, 34);
            this.btnRechargerTabInscriptions.TabIndex = 2;
            this.btnRechargerTabInscriptions.Text = "Recharger";
            this.btnRechargerTabInscriptions.UseVisualStyleBackColor = true;
            this.btnRechargerTabInscriptions.Click += new System.EventHandler(this.btnRechargerTabInscriptions_Click);
            // 
            // dgvInscriptions
            // 
            this.dgvInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscriptions});
            this.dgvInscriptions.Location = new System.Drawing.Point(164, 29);
            this.dgvInscriptions.Name = "dgvInscriptions";
            this.dgvInscriptions.Size = new System.Drawing.Size(144, 268);
            this.dgvInscriptions.TabIndex = 1;
            this.dgvInscriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscriptions_CellContentClick);
            // 
            // inscriptions
            // 
            this.inscriptions.HeaderText = "Inscriptions";
            this.inscriptions.Name = "inscriptions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTrierByResponsables);
            this.groupBox2.Controls.Add(this.cbResponsables);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnTrierByAgePetit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTrierByAgeGrand);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRechargerTabEleves);
            this.groupBox2.Controls.Add(this.dgvEleves);
            this.groupBox2.Location = new System.Drawing.Point(447, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage élèves";
            // 
            // btnTrierByResponsables
            // 
            this.btnTrierByResponsables.Location = new System.Drawing.Point(14, 91);
            this.btnTrierByResponsables.Name = "btnTrierByResponsables";
            this.btnTrierByResponsables.Size = new System.Drawing.Size(127, 32);
            this.btnTrierByResponsables.TabIndex = 8;
            this.btnTrierByResponsables.Text = "Valider";
            this.btnTrierByResponsables.UseVisualStyleBackColor = true;
            this.btnTrierByResponsables.Click += new System.EventHandler(this.btnTrierByResponsables_Click);
            // 
            // cbResponsables
            // 
            this.cbResponsables.FormattingEnabled = true;
            this.cbResponsables.Location = new System.Drawing.Point(14, 53);
            this.cbResponsables.Name = "cbResponsables";
            this.cbResponsables.Size = new System.Drawing.Size(127, 21);
            this.cbResponsables.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trier par Responsables :";
            // 
            // btnTrierByAgePetit
            // 
            this.btnTrierByAgePetit.Location = new System.Drawing.Point(12, 263);
            this.btnTrierByAgePetit.Name = "btnTrierByAgePetit";
            this.btnTrierByAgePetit.Size = new System.Drawing.Size(129, 34);
            this.btnTrierByAgePetit.TabIndex = 5;
            this.btnTrierByAgePetit.Text = "Valider";
            this.btnTrierByAgePetit.UseVisualStyleBackColor = true;
            this.btnTrierByAgePetit.Click += new System.EventHandler(this.btnTrierByAgePetit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trier par age le plus Petit :";
            // 
            // btnTrierByAgeGrand
            // 
            this.btnTrierByAgeGrand.Location = new System.Drawing.Point(14, 184);
            this.btnTrierByAgeGrand.Name = "btnTrierByAgeGrand";
            this.btnTrierByAgeGrand.Size = new System.Drawing.Size(129, 31);
            this.btnTrierByAgeGrand.TabIndex = 3;
            this.btnTrierByAgeGrand.Text = "Valider";
            this.btnTrierByAgeGrand.UseVisualStyleBackColor = true;
            this.btnTrierByAgeGrand.Click += new System.EventHandler(this.btnTrierByAgeGrand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trier par age le plus Grand :";
            // 
            // btnRechargerTabEleves
            // 
            this.btnRechargerTabEleves.Location = new System.Drawing.Point(164, 304);
            this.btnRechargerTabEleves.Name = "btnRechargerTabEleves";
            this.btnRechargerTabEleves.Size = new System.Drawing.Size(144, 34);
            this.btnRechargerTabEleves.TabIndex = 1;
            this.btnRechargerTabEleves.Text = "Recharger";
            this.btnRechargerTabEleves.UseVisualStyleBackColor = true;
            this.btnRechargerTabEleves.Click += new System.EventHandler(this.btnRechargerTabEleves_Click);
            // 
            // dgvEleves
            // 
            this.dgvEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleves});
            this.dgvEleves.Location = new System.Drawing.Point(164, 29);
            this.dgvEleves.Name = "dgvEleves";
            this.dgvEleves.Size = new System.Drawing.Size(144, 268);
            this.dgvEleves.TabIndex = 0;
            this.dgvEleves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEleves_CellContentClick);
            // 
            // eleves
            // 
            this.eleves.HeaderText = "élèves";
            this.eleves.Name = "eleves";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPagePrincipale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trier par Cours :";
            // 
            // cbResponsables2
            // 
            this.cbResponsables2.FormattingEnabled = true;
            this.cbResponsables2.Location = new System.Drawing.Point(9, 184);
            this.cbResponsables2.Name = "cbResponsables2";
            this.cbResponsables2.Size = new System.Drawing.Size(118, 21);
            this.cbResponsables2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trier par Responsables :";
            // 
            // btnResponsables2
            // 
            this.btnResponsables2.Location = new System.Drawing.Point(9, 225);
            this.btnResponsables2.Name = "btnResponsables2";
            this.btnResponsables2.Size = new System.Drawing.Size(118, 29);
            this.btnResponsables2.TabIndex = 8;
            this.btnResponsables2.Text = "Valider";
            this.btnResponsables2.UseVisualStyleBackColor = true;
            this.btnResponsables2.Click += new System.EventHandler(this.btnResponsables2_Click);
            // 
            // AfficheInscriptionsetEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AfficheInscriptionsetEleves";
            this.Text = "Ecole de Musique";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEleves;
        private System.Windows.Forms.Button btnRechargerTabInscriptions;
        private System.Windows.Forms.DataGridView dgvInscriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscriptions;
        private System.Windows.Forms.Button btnRechargerTabEleves;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValiderInscriptionByCours;
        private System.Windows.Forms.ComboBox cbByCours;
        private System.Windows.Forms.Button btnTrierByResponsables;
        private System.Windows.Forms.ComboBox cbResponsables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrierByAgePetit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrierByAgeGrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResponsables2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResponsables2;
        private System.Windows.Forms.Label label1;
    }
}