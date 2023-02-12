using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace bibliotekaZavrsno
{
    public partial class PosudiKnjigu : Form
    {
        public PosudiKnjigu()
        {
            InitializeComponent();
        }

        private void buttonPosudiKnjigu_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Ime = textBoxImeKorisnika.Text;
            korisnik.Prezime = textBoxPrezimeKorisnika.Text;
            korisnik.OIB = textBoxOibKorisnika.Text;

            Knjiga knjiga = new Knjiga();
            knjiga.Naziv = textBoxNazivKnjige.Text;
            knjiga.Autor = textBoxAutorKnjige.Text;

            Posudba posudba = new Posudba();
            posudba.Korisnik = korisnik;
            posudba.Knjiga = knjiga;
            posudba.Date = DateTime.Now;
            posudba.Vracanje = posudba.Date.AddDays(15);

            XmlSerializer serializer = new XmlSerializer(typeof(Posudba));
            using (FileStream fs = new FileStream("posudba.xml", FileMode.Append))
            {
                serializer.Serialize(fs, posudba);
            }

            MessageBox.Show("Knjiga je uspješno posuđena!");
        }
    }

    public class Knjiga
    {
        public string Naziv { get; set; }
        public string Autor { get; set; }
    }

    public class Posudba
    {
        public Korisnik Korisnik { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime Date { get; set; }
        public DateTime Vracanje { get; set; }
    }}
