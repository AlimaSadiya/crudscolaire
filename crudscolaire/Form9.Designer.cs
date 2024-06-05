namespace crudscolaire
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrecheche = new System.Windows.Forms.Button();
            this.cmblibelle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnrecheche
            // 
            this.btnrecheche.Location = new System.Drawing.Point(74, 46);
            this.btnrecheche.Name = "btnrecheche";
            this.btnrecheche.Size = new System.Drawing.Size(75, 23);
            this.btnrecheche.TabIndex = 3;
            this.btnrecheche.Text = "Rechercher";
            this.btnrecheche.UseVisualStyleBackColor = true;
            this.btnrecheche.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmblibelle
            // 
            this.cmblibelle.FormattingEnabled = true;
            this.cmblibelle.Items.AddRange(new object[] {
            "Informatique",
            "Gestion",
            "Reseau",
            "Comptabilite",
            "BAFA",
            "MULTIMEDIA"});
            this.cmblibelle.Location = new System.Drawing.Point(183, 48);
            this.cmblibelle.Margin = new System.Windows.Forms.Padding(2);
            this.cmblibelle.Name = "cmblibelle";
            this.cmblibelle.Size = new System.Drawing.Size(92, 21);
            this.cmblibelle.TabIndex = 4;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmblibelle);
            this.Controls.Add(this.btnrecheche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrecheche;
        private System.Windows.Forms.ComboBox cmblibelle;
    }
}