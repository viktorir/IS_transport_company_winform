using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            NpgsqlConnection pgsqlConnection;
            NpgsqlCommand pgsqlCommand;
            NpgsqlDataReader pgsqlDataReader;

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

                string getAllTablesQuery = "SELECT table_name FROM information_schema.tables WHERE table_schema='public' AND table_type='BASE TABLE';";
                pgsqlCommand = new NpgsqlCommand(getAllTablesQuery, pgsqlConnection);

                List<Button> tableButtons = new List<Button>();
                pgsqlDataReader = pgsqlCommand.ExecuteReader();
                while (pgsqlDataReader.Read())
                {
                    string tableName = pgsqlDataReader["table_name"].ToString();
                    Button tableButton = new Button();
                    tableButton.Text = tableName;

                    tableButton.Click += (s, e) => {
                        try
                        {
                            pgsqlConnection.Open();

                            string getDataQuery = "SELECT * FROM " + tableName;
                            pgsqlCommand = new NpgsqlCommand(getDataQuery, pgsqlConnection);

                            pgsqlDataReader = pgsqlCommand.ExecuteReader();
                            if (pgsqlDataReader.HasRows)
                            {
                                DataTable table = new DataTable();
                                table.Load(pgsqlDataReader);
                                tableView.DataSource = table;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        finally
                        {
                            pgsqlConnection.Close();
                        } 
                    };

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
