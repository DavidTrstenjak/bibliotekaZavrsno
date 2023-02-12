using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace bibliotekaZavrsno
{
    public partial class UnesiKnjigu : Form
    {
        public UnesiKnjigu()
        {
            InitializeComponent();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Knjiga1 knjiga = new Knjiga1();
            knjiga.Naziv = textBoxNazivKnjige.Text;
            knjiga.Autor = textBoxUnesiAutora.Text;

            XmlSerializer serializer = new XmlSerializer(typeof(Knjiga1));
            using (FileStream fs = new FileStream("knjiga.xml", FileMode.Append))
            {
                serializer.Serialize(fs, knjiga);
            }
            MessageBox.Show("Knjiga je uspješno unesena");
        }
    }

    public class Knjiga1
    {
        public string Naziv { get; set; }
        public string Autor { get; set; }
    }
}
