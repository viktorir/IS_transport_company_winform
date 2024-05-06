using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace IS_transport_company
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection pgsqlConnection;
        private NpgsqlCommand pgsqlCommand;
        private NpgsqlDataReader pgsqlDataReader;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=qweqwe123;Database=transport_company;";
            pgsqlConnection = new NpgsqlConnection(connectionString);            

            tablesPanel.ColumnCount = 1;
            tablesPanel.RowCount = 1;
            try
            {
                MessageBox.Show("Информационная система\n'Транспортная компания'\n\nРазработчик: Свердюков Виктор\nСтудент группы БД-21-1\n\nПодключение к базе данных...");

                pgsqlConnection.Open();
                MessageBox.Show("Подключение успешно!");            

                pgsqlCommand = new NpgsqlCommand(
                    "SELECT table_name FROM information_schema.tables WHERE table_schema='public' AND table_type='BASE TABLE';", 
                    pgsqlConnection
                );

                List<Button> tableButtons = new List<Button>();
                pgsqlDataReader = pgsqlCommand.ExecuteReader();
                while (pgsqlDataReader.Read())
                {
                    string tableName = pgsqlDataReader["table_name"].ToString();
                    Button tableButton = new Button();
                    tableButton.Text = tableName;

                    tableButton.Click += tableButton_Click;

                    tableButtons.Add(tableButton);
                    tablesPanel.Controls.Add(tableButton);
                    tablesPanel.RowCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally {
                pgsqlConnection.Close();
            }
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            try
            {
                pgsqlConnection.Open();

                pgsqlCommand = new NpgsqlCommand("SELECT * FROM " + tableName, pgsqlConnection);
                pgsqlDataReader = pgsqlCommand.ExecuteReader();
                if (pgsqlDataReader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(pgsqlDataReader);
                    tableView.DataSource = table;
                }

                tableInteractiveButtonPanel.Controls.Clear();

                Button addButton = new Button();
                addButton.Text = "Добавить";
                addButton.AddListener().Execute(addButton);
                tableInteractiveButtonPanel.Controls.Add(addButton);

                Button editButton = new Button();
                editButton.Text = "Изменить";
                tableInteractiveButtonPanel.Controls.Add(editButton);


                Button deleteButton = new Button();
                deleteButton.Text = "Удалить";
                tableInteractiveButtonPanel.Controls.Add(deleteButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
