using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crudscolaire
{
    public partial class Form2 : Form
    {
        bdemployeeEntities1 context = new bdemployeeEntities1();

        public Form2()
        {
            InitializeComponent();
            /*cmbclasse.DataSource = context.Classe.ToList();
            //cmbclasse.DataSource = context.Classe.ToList();
            cmbclasse.DisplayMember = "libelle";
            cmbclasse.ValueMember = "id";
            dataGridView1.DataSource = context.Etudiants.ToList();*/
            // Assurez-vous que le contrôle ComboBox est correctement lié à la source de données (contexte)
            cmbdepartement.DataSource = context.departement.ToList();

            // Définir la propriété DisplayMember pour afficher le libellé de la classe
            cmbdepartement.DisplayMember = "libelle";

            // Définir la propriété ValueMember pour récupérer l'ID de la classe
            cmbdepartement.ValueMember = "id";

            // Mettre à jour la source de données du DataGridView (dans votre cas, context.Etudiants)
            dataGridView1.DataSource = context.employee.ToList();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            employee employee= new employee();
            employee.prenom = txtprenom.Text;
            employee.nom = txtnom.Text;
            employee.fonction = txtfonction.Text;
            if (int.TryParse(txtsalaire.Text, out int salaire))
            {
                employee.salaire = salaire.ToString(); // Convertir l'int en string pour correspondre à la base de données
            }
            else
            {
                MessageBox.Show("Veuillez entrer un salaire valide.");
                return;
            }
            employee.idDep = Convert.ToInt32(cmbdepartement.SelectedValue);
            context.employee.Add(employee);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dataGridView1.DataSource = context.employee.ToList();
            effacer();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtprenom.Text = row.Cells[1].Value.ToString();
                txtnom.Text = row.Cells[2].Value.ToString();
                txtfonction.Text = row.Cells[3].Value.ToString();
                txtsalaire.Text = row.Cells[4].Value.ToString();
                cmbdepartement.Text = row.Cells[6].Value.ToString();

            }
        }

        void effacer()
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtfonction.Text = "";
            txtsalaire.Text = "";
            
            cmbdepartement.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            var context = new bdemployeeEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                employee personneToUpdate = context.employee.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.prenom = txtprenom.Text;
                    personneToUpdate.nom = txtnom.Text;
                    personneToUpdate.fonction = txtfonction.Text;
                    personneToUpdate.salaire = txtsalaire.Text;
                    personneToUpdate.idDep = Convert.ToInt32(cmbdepartement.SelectedValue);
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dataGridView1.DataSource = context.employee.ToList();
                    effacer();
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

        private void btnsuprimer_Click(object sender, EventArgs e)
        {

            var context = new bdemployeeEntities1();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                employee etudiantToDelete = context.employee.Find(entityId);

                if (etudiantToDelete != null)
                {
                    context.employee.Remove(etudiantToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dataGridView1.DataSource = context.employee.ToList();
                    effacer();
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

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            /*var context = new schoolEntities();
            string searchTerm = txtrechercher.Text.Trim();
            int selectedClasseId = Convert.ToInt32(cmbclasse.SelectedValue);
            var result = context.Etudiants
                                .Where(c => (c.anneescolaire.Contains(searchTerm) || c.prenom.Contains(searchTerm) || c.nom.Contains(searchTerm))
                                            && c.idclasse == selectedClasseId)
                                .ToList();

            dataGridView1.DataSource = result;*/
            string searchText = txtrechercher.Text.Trim();
            string libelleDep = cmbdepartement.Text.Trim();

            var employees = context.employee.AsQueryable();

            if (!string.IsNullOrEmpty(libelleDep))
            {
                employees = employees.Where(etudiant => etudiant.departement.libelleDep.Contains(libelleDep));
            }

            dataGridView1.DataSource = employees.ToList();


        }

        private void cmbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
