using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudscolaire
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        

        private void listerLesEmployéesParDepartementCrystalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ab = new Form6();
            ab.Show();
        }

        private void diagrammeNombreDemployéesParFonctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 av = new Form7();
            av.Show();
        }

        private void reportingDeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ac = new Form8();
            ac.Show();
        }

        private void listerLesEmployéesDunDepartementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }
    }
}
