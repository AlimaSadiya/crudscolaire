using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudscolaire
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public class YourDbContext : DbContext
        {
            public DbSet<departement> departement { get; set; }
            public DbSet<employee> employee { get; set; }
            // Autres DbSet et configurations
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialiser le contexte
            using (var context = new YourDbContext())
            {
                string nomemployee = Convert.ToString(btnrecheche.Text);
                int id = context.departement
                                 .Where(cl => cl.libelleDep == nomemployee)
                                 .Select(cl => cl.id)
                                 .FirstOrDefault();

                if (id != 0)
                {
                    // MessageBox.Show("id est "+id);
                    var etus = context.employee.Where(et => et.idDep == id).ToList();
                    dataGridView1.DataSource = etus.ToList();
                }
            }
        }

    }
}
