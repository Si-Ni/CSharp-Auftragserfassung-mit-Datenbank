using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseDatabase {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e) {
            string ConnectionInformation = "datasource=localhost;port=3306;username=root;password=123456";
            string Auftragsverguetung = "";
            string Warengewicht = "";
            try {
                Auftragsverguetung = this.txtAuftragsverguetung.Text;
                Auftragsverguetung = Auftragsverguetung.Replace(",", ".");
                Warengewicht = this.txtGewicht.Text;
                Warengewicht = Warengewicht.Replace(",", ".");
            }
            catch(Exception) {

            }
            string Query = $@"insert into auftragserfassung.aufträge 
(Start_FirmaName,
Start_Ansprechpartner,
Start_Straße,
Start_Hausnummer,
Start_Stadt,
Ziel_FirmaName,
Ziel_Ansprechpartner,
Ziel_Straße,
Ziel_Hausnummer,
Ziel_Stadt,
Auftragsvergütung,
Transportgut,
Warengewicht,
Ländergrenzen) 
values('{this.txtStartFirmaName.Text}',
'{this.txtStartAnsprechpartner.Text}',
'{this.txtStartStraße.Text}',
'{this.txtStartHausnummer.Text}',
'{this.txtStartStadt.Text}',
'{this.txtZielFirmaName.Text}',
'{this.txtZielAnsprechpartner.Text}',
'{this.txtZielStraße.Text}',
'{this.txtZielHausnummer.Text}',
'{this.txtZielStadt.Text}',
'{Auftragsverguetung}',
'{this.txtTransportgut.Text}',
'{Warengewicht}',";
            if(this.radioButtonGrenzenJa.Checked) {
                Query += "'ja');";
            } else {
                Query += "'nein');";
            }
            MySqlConnection DatabaseConnection = new MySqlConnection(ConnectionInformation);
            MySqlCommand DatabaseSaveCommand = new MySqlCommand(Query, DatabaseConnection);
            MySqlDataReader Reader;
            Console.WriteLine(Query);


            try {
                DatabaseConnection.Open();
                Reader = DatabaseSaveCommand.ExecuteReader();
                while(Reader.Read()) {

                }
                MessageBox.Show("saved");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            DatabaseConnection.Close();

            btnAbbrechen.PerformClick();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e) {
            this.txtStartFirmaName.Text = "";
            this.txtStartAnsprechpartner.Text = "";
            this.txtStartStraße.Text = "";
            this.txtStartHausnummer.Text = "";
            this.txtStartStadt.Text = "";
            this.txtZielFirmaName.Text = "";
            this.txtZielAnsprechpartner.Text = "";
            this.txtZielStraße.Text = "";
            this.txtZielHausnummer.Text = "";
            this.txtZielStadt.Text = "";
            this.txtAuftragsverguetung.Text = "";
            this.txtTransportgut.Text = "";
            this.txtGewicht.Text = "";
            this.radioButtonGrenzenJa.Checked = true;
        }

        private void btnShowData_Click(object sender, EventArgs e) {
            Daten data = new Daten();
            data.Show();
        }
    }
}
