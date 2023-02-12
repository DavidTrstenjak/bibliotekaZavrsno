using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotekaZavrsno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrirajKorisnika_Click(object sender, EventArgs e)
        {
            RegistrirajKorisnika f2 = new RegistrirajKorisnika();
            f2.ShowDialog();
        }

        private void buttonPosudiKnjigu_Click(object sender, EventArgs e)
        {
            PosudiKnjigu f3 = new PosudiKnjigu();
            f3.ShowDialog();
        }

        private void buttonUnesiKnjigu_Click(object sender, EventArgs e)
        {
            UnesiKnjigu f4 = new UnesiKnjigu();
            f4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
