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
        Random rnd;
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
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

        private void populateUnitInfo()
        {
            string query = "Select * From unitTable Where Id = " + (unitListBox.SelectedItem as DataRowView)["Id"];
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                displayInfoTextBox.Text = "Rarity: "+reader["Rarity"].ToString()+"\r\n";
                displayInfoTextBox.Text += "Information: "+reader["Info"].ToString();
                reader.Close();
                connection.Close();
            }

        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            if (unitNameTxtBox.Text != "")
            {
                string query = "Insert Into unitTable Values (@Rarity, @Name, @Info)";

                using (connection = new SqlConnection(connectionString))
                using (command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Rarity", Convert.ToInt32(rarityComboBox.Text));
                    command.Parameters.AddWithValue("@Name", unitNameTxtBox.Text);
                    command.Parameters.AddWithValue("@Info", unitInfoTextBox.Text);

                    command.ExecuteNonQuery();
                }
                populateUnitList();

                unitNameTxtBox.Text = "";
                unitInfoTextBox.Text = "";
            }
        }

        private void delUnitBtn_Click(object sender, EventArgs e)
        {
            string query = "Delete From unitTable Where Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", Convert.ToInt32((unitListBox.SelectedItem as DataRowView)["Id"]));

                command.ExecuteNonQuery();
            }
            populateUnitList();
        }

        private void unitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateUnitInfo();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            int[] idArr;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From unitTable", connection))
            {
                DataTable unitTable = new DataTable();
                adapter.Fill(unitTable);

                idArr = new int[unitTable.Rows.Count];
                int i = 0;

                foreach (DataRow row in unitTable.Rows)
                {
                    idArr[i] = Convert.ToInt32(row["Id"].ToString());
                    i++;
                }
            }

            string query = "Select * From unitTable Where Id = " + idArr[rnd.Next(idArr.Length)];

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable unitTable = new DataTable();
                adapter.Fill(unitTable);

                rollListBox.DisplayMember = "Name";
                rollListBox.ValueMember = "Id";
                rollListBox.DataSource = unitTable;
            }

            populateRollUnitInfo();
        }

        private void rollListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void populateRollUnitInfo()
        {
            string query = "Select * From unitTable Where Id = " + (rollListBox.SelectedItem as DataRowView)["Id"];
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                displayInfoTextBox.Text = "Rarity: " + reader["Rarity"].ToString() + "\r\n";
                displayInfoTextBox.Text += "Information: " + reader["Info"].ToString();
                reader.Close();
                connection.Close();
            }

        }
    }
}
