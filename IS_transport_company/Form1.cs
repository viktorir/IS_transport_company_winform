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
using static System.Net.Mime.MediaTypeNames;

namespace IS_transport_company
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection pgsqlConnection;
        private NpgsqlCommand pgsqlCommand;
        private NpgsqlDataReader pgsqlDataReader;

        List<TextBox> inputColumns = new List<TextBox>();
        List<Button> tableButtons = new List<Button>();

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

                tableButtons = new List<Button>();
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
                MessageBox.Show($"Error Form1: {ex.Message}");
            }
            finally {
                pgsqlConnection.Close();
            }
        }

        private void updateTableView(string tableName)
        {
            pgsqlCommand = new NpgsqlCommand("SELECT * FROM " + tableName, pgsqlConnection);
            pgsqlDataReader = pgsqlCommand.ExecuteReader();
            if (pgsqlDataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(pgsqlDataReader);
                tableView.DataSource = table;

                tableInteractivePanel.ColumnCount = 2;
                tableInteractivePanel.RowCount = table.Rows.Count;

                inputColumns = new List<TextBox>();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    Label columnName = new Label();
                    columnName.Text = table.Columns[i].ToString() + ": ";
                    this.tableInteractivePanel.Controls.Add(columnName, 0, i);

                    TextBox inputColumn = new TextBox();
                    inputColumn.Tag = table.Columns[i].ToString();
                    inputColumn.Text = "";
                    inputColumns.Add(inputColumn);
                    this.tableInteractivePanel.Controls.Add(inputColumn, 1, i);
                }

                tableView.SelectionChanged += tableView_SelectionChanged;
            }
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            tableView.SelectionChanged -= tableView_SelectionChanged;
            try
            {
                Button button = (Button)sender;

                tableInteractiveButtonPanel.Controls.Clear();
                tableInteractivePanel.Controls.Clear();

                pgsqlConnection.Open();

                updateTableView(button.Text);

                Button addButton = new Button();
                addButton.Text = "Добавить";
                addButton.Tag = button.Text;
                addButton.Click += addButton_Click;
                tableInteractiveButtonPanel.Controls.Add(addButton);

                Button editButton = new Button();
                editButton.Tag = button.Text;
                editButton.Text = "Изменить";
                tableInteractiveButtonPanel.Controls.Add(editButton);


                Button deleteButton = new Button();
                deleteButton.Tag = button.Text;
                deleteButton.Text = "Удалить";
                deleteButton.Click += deleteButton_Click;
                tableInteractiveButtonPanel.Controls.Add(deleteButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error tableButton_Click: {ex.Message}");
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        private void tableView_SelectionChanged(object sender, EventArgs e)
        {
            if (tableView.ColumnCount != inputColumns.Count)
            {
                MessageBox.Show("wtf");
            }

            for (int i = 0; i < tableView.ColumnCount; i++)
            {
                inputColumns[i].Text = tableView.SelectedRows[0].Cells[i].Value.ToString();
            }     
        }
        private void addButton_Click( object sender, EventArgs e )
        {
            try
            {
                Button button = (Button)sender;

                pgsqlConnection.Open();
                string insertQuery = "INSERT INTO " + button.Tag + " VALUES (";
                inputColumns.ForEach(inputColumn =>
                {
                    insertQuery += "'" + inputColumn.Text.Replace(',', '.') + "',";
                });
                insertQuery = insertQuery.Remove(insertQuery.Length - 1);
                insertQuery += ");";
                

                pgsqlCommand = new NpgsqlCommand(insertQuery, pgsqlConnection);
                pgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("Информация добавлена! Обновите таблицу, нажав на неё ещё раз!");
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Error addButton_Click: {ex.Message}");
            }
            finally { 
                pgsqlConnection.Close(); 
            }
        }

        private void deleteButton_Click( object sender, EventArgs e )
        {
            try
            {
                Button button = (Button)sender;

                if (inputColumns[0].Text == "")
                {
                    MessageBox.Show("Для удаления введите id или выбирете строку из таблицы!");
                    return;
                }

                pgsqlConnection.Open();
                Console.WriteLine("DELETE FROM " + button.Tag + " WHERE '" + inputColumns[0].Tag + "'='" + inputColumns[0].Text + "';");

                pgsqlCommand = new NpgsqlCommand("DELETE FROM " + button.Tag + " WHERE " + inputColumns[0].Tag + "=" + inputColumns[0].Text + ";", pgsqlConnection);
                pgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("Информация удалена! Обновите таблицу, нажав на неё ещё раз!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error addButton_Click: {ex.Message}");
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        private void tableView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tableView.ClearSelection();
        }
    }
}
