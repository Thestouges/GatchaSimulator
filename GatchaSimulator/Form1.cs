using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace GatchaSimulator
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GatchaSimulator.Properties.Settings.unitDatabaseConnectionString"].ConnectionString;
            rarityComboBox.SelectedIndex = 0;
            populateUnitList();
        }

        private void populateUnitList()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From unitTable",connection))
            {
                DataTable unitTable = new DataTable();
                adapter.Fill(unitTable);

                unitListBox.DisplayMember = "Name";
                unitListBox.ValueMember = "Id";
                unitListBox.DataSource = unitTable;
            }
        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            string query = "Insert Into unitTable Values (@Rarity, @Name)";

            using (connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Rarity",Convert.ToInt32(rarityComboBox.Text));
                command.Parameters.AddWithValue("@Name", unitNameTxtBox.Text);

                command.ExecuteNonQuery();
            }
            populateUnitList();
        }

        private void delUnitBtn_Click(object sender, EventArgs e)
        {
            string query = "Delete From unitTable Where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", Convert.ToInt32((unitListBox.SelectedItem as DataRowView)["Id"]));

                command.ExecuteNonQuery();
            }
            populateUnitList();
        }
    }
}
