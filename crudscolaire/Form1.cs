using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace crudscolaire
{
    public partial class Form1 : Form
    {
        bdemployeeEntities1 context = new bdemployeeEntities1();

        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = context.departement.ToList();

        }

        private void btnenreg_Click(object sender, EventArgs e)
        {

            departement classe = new departement();
            
            classe.libelleDep = cmblibelle.Text;
            //classe.Etudiants = txtprenom.Text + txtnom.Text;

            context.departement.Add(classe);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dataGridView1.DataSource = context.departement.ToList();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            var context = new bdemployeeEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                departement personneToUpdate = context.departement.Find(entityId);

                if (personneToUpdate != null)
                {
                    
                    personneToUpdate.libelleDep = cmblibelle.Text;
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dataGridView1.DataSource = context.departement.ToList();
                }
                else
                {
                    MessageBox.Show("Entité à mettre à jour non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();

                // Vérifiez que la ligne a au moins 4 cellules avant d'accéder à la cellule à l'index 3
                if (row.Cells.Count >= 4)
                {
                    cmblibelle.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    // Gérer le cas où la ligne n'a pas 4 cellules
                    cmblibelle.Text = string.Empty;
                }
            }

        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
            cmblibelle.Text = "";
        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            var context = new bdemployeeEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                departement classeToDelete = context.departement.Find(entityId);

                if (classeToDelete != null)
                {
                    context.departement.Remove(classeToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dataGridView1.DataSource = context.departement.ToList();
                }
                else
                {
                    MessageBox.Show("Entité à supprimer non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
