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
            this.btnRechargerTabInscriptions = new System.Windows.Forms.Button();
            this.dgvInscriptions = new System.Windows.Forms.DataGridView();
            this.inscriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRechargerTabEleves = new System.Windows.Forms.Button();
            this.dgvEleves = new System.Windows.Forms.DataGridView();
            this.eleves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRechargerTabInscriptions);
            this.groupBox1.Controls.Add(this.dgvInscriptions);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage Inscriptions";
            // 
            // btnRechargerTabInscriptions
            // 
            this.btnRechargerTabInscriptions.Location = new System.Drawing.Point(149, 304);
            this.btnRechargerTabInscriptions.Name = "btnRechargerTabInscriptions";
            this.btnRechargerTabInscriptions.Size = new System.Drawing.Size(159, 34);
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
            this.dgvInscriptions.Location = new System.Drawing.Point(149, 29);
            this.dgvInscriptions.Name = "dgvInscriptions";
            this.dgvInscriptions.Size = new System.Drawing.Size(159, 268);
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
            this.groupBox2.Controls.Add(this.btnRechargerTabEleves);
            this.groupBox2.Controls.Add(this.dgvEleves);
            this.groupBox2.Location = new System.Drawing.Point(447, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage élèves";
            // 
            // btnRechargerTabEleves
            // 
            this.btnRechargerTabEleves.Location = new System.Drawing.Point(149, 304);
            this.btnRechargerTabEleves.Name = "btnRechargerTabEleves";
            this.btnRechargerTabEleves.Size = new System.Drawing.Size(159, 34);
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
            this.dgvEleves.Location = new System.Drawing.Point(149, 29);
            this.dgvEleves.Name = "dgvEleves";
            this.dgvEleves.Size = new System.Drawing.Size(159, 268);
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
            this.button1.Text = "Page Principale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPagePrincipale_Click);
            // 
            // AfficheInscriptionsetEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AfficheInscriptionsetEleves";
            this.Text = "AfficheInscriptionsetEleves";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
    }
}