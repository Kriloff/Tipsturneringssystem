using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Tipsturneringssystem
{
    public partial class Main : Form
    {
        public string bruger;
        public static SQLiteConnection dbconn;
        public Main()
        {
            InitializeComponent();
            //SQLiteConnection.CreateFile("Tipsdb.db");
            dbconn = new SQLiteConnection("DataSource = Tipsdb.db ;Version=3");
            dbconn.Open();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_opretBruger_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gemBruger_Click(object sender, EventArgs e)
        {
            if (txt_opretBruger.Text.Trim() != "")
            {
                bruger = txt_opretBruger.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                SQLiteCommand cmd = new SQLiteCommand(dbconn);
                cmd.CommandText = "INSERT INTO brugere(Brugernavn) values ('" + bruger + "')";
                //cmd.Parameters.AddWithValue("@bruger", txt_opretBruger.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Brugeren,"+txt_opretBruger.Text+", er blevet oprettet!");
            }
        }
        private void btn_opretBruger_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(dbconn);
            cmd.CommandText = "SELECT Brugernavn FROM brugere";
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();

            //Laver kolonnerne
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }

            //Tjekker om den kan læse videre. 
            while (reader.Read())
            {

                //Regner celler ud alt efter hvor mange kollonner der er. 
                string[] cells = new string[reader.FieldCount];

                //Udskriver databasen. 
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    cells[i] = reader[i].ToString();
                }
                //Tilføjer rækker når cellerne er fyldt ud. 
                table.Rows.Add(cells);

            }


            //DataGridView1 viser indholdet fra tabellen. 
            dataGridView_Brugernavn.DataSource = table;


            panel_main.Visible = false;
            panel_opretBruger.Visible = true;
        }
    }
}
