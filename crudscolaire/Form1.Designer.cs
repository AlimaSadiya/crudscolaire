namespace crudscolaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmblibelle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenreg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btneffacer = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Departement";
            // 
            // cmblibelle
            // 
            this.cmblibelle.FormattingEnabled = true;
            this.cmblibelle.Items.AddRange(new object[] {
            "Informatique",
            "Gestion",
            "Reseau"});
            this.cmblibelle.Location = new System.Drawing.Point(106, 130);
            this.cmblibelle.Margin = new System.Windows.Forms.Padding(2);
            this.cmblibelle.Name = "cmblibelle";
            this.cmblibelle.Size = new System.Drawing.Size(92, 21);
            this.cmblibelle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "libelle";
            // 
            // btnenreg
            // 
            this.btnenreg.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnenreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenreg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnenreg.Location = new System.Drawing.Point(12, 262);
            this.btnenreg.Margin = new System.Windows.Forms.Padding(2);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(58, 28);
            this.btnenreg.TabIndex = 5;
            this.btnenreg.Text = "Enreg";
            this.btnenreg.UseVisualStyleBackColor = false;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 245);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifier.Location = new System.Drawing.Point(116, 262);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(80, 28);
            this.btnmodifier.TabIndex = 24;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnsuprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsuprimer.Location = new System.Drawing.Point(116, 312);
            this.btnsuprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(80, 28);
            this.btnsuprimer.TabIndex = 23;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = false;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btneffacer
            // 
            this.btneffacer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btneffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneffacer.Location = new System.Drawing.Point(9, 312);
            this.btneffacer.Margin = new System.Windows.Forms.Padding(2);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(62, 28);
            this.btneffacer.TabIndex = 22;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = false;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(64, 75);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 20);
            this.txtid.TabIndex = 25;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(652, 405);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnenreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmblibelle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmblibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.TextBox txtid;
    }
}

