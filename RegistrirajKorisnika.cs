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
    public partial class RegistrirajKorisnika : Form
    {
        
        public RegistrirajKorisnika()
        {
            InitializeComponent();
        }

        private void buttonUnesiKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik korisnici = new Korisnik();
            korisnici.Ime = textBoxImeKorisnika.Text;
            korisnici.Prezime = textBoxPrezimeKorisnika.Text;
            korisnici.OIB = textBoxOibKorisnika.Text;

            XmlSerializer serializer = new XmlSerializer(typeof(Korisnik));
            using (FileStream fs = new FileStream("korisnici.xml", FileMode.Append))
            {
                serializer.Serialize(fs, korisnici);
            }
            MessageBox.Show("Korisnik je uspješno registriran");
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {

        }
    }

    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set;}
        public string OIB { get; set;}

    }
}
