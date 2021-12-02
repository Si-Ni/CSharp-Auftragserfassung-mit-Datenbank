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
    public partial class Daten : Form {
        public Daten() {
            InitializeComponent();
        }

        private void Daten_Load(object sender, EventArgs e) {
            try {
                string ConnectionInformation = "datasource=localhost;port=3306;username=root;password=123456";

                string Query = "select * from auftragserfassung.aufträge;";
                MySqlConnection DatabaseConnection = new MySqlConnection(ConnectionInformation);
                MySqlCommand DatabaseCommand = new MySqlCommand(Query, DatabaseConnection);
                DatabaseConnection.Open();

                MySqlDataAdapter DatabaseAdapter = new MySqlDataAdapter();
                DatabaseAdapter.SelectCommand = DatabaseCommand;
                DataTable dataTable = new DataTable();
                DatabaseAdapter.Fill(dataTable);
                Console.WriteLine("Test");

                this.dataGridViewAuftraege.DataSource = dataTable;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                string ConnectionInformation = "datasource=localhost;port=3306;username=root;password=123456";
                string Query = "delete from auftragserfassung.aufträge where Auftragsnummer='" + this.txtDeleteId.Text + "';";
                MySqlConnection DatabaseConnection = new MySqlConnection(ConnectionInformation);
                MySqlCommand DatabaseCommand = new MySqlCommand(Query, DatabaseConnection);
                MySqlDataReader Reader;
                DatabaseConnection.Open();
                Reader = DatabaseCommand.ExecuteReader();
                while(Reader.Read()) {
                }
                DatabaseConnection.Close();
                Daten data = new Daten();
                data.Show();
                this.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
