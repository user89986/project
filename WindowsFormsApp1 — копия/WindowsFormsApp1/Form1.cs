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
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        private DatabaseHelper dbHelper;
        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("DataBase.db");
            Load();

        }
        public void Load()
        {
            {
                string BDpath = @"DataBase.db";
                using (var connection = new SqliteConnection($"Data Source={BDpath}"))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    string sql = "SELECT * FROM Sklad";
                    using (var command = new SqliteCommand(sql, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                        dataGridView1.DataSource= dataTable;

                    }

                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int screws = Convert.ToInt32(Screws.Text);
            int bigDoors = Convert.ToInt32(LargeDoor.Text);
            int smallDoors = Convert.ToInt32(TableDoor.Text);
            int shelves = Convert.ToInt32(Shelf.Text);
            (int cabinets, int workbenches) = CalculateProducts(screws, bigDoors, smallDoors, shelves);
            MessageBox.Show($"Шкафов: {cabinets}, Верстаков: {workbenches}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int maxScrews = dbHelper.GetMaterialsCount("Screws");
            int maxShelves = dbHelper.GetMaterialsCount("Shelf");
            (int cabinets, int workbenches) = CalculateProducts(maxScrews, int.MaxValue, int.MaxValue, maxShelves);
            string message = "";
            if (cabinets == 0 && workbenches == 0)
            {
                int missingScrewsForCabinet = Math.Max(0, 20 - maxScrews);
                int missingShelvesForCabinet = Math.Max(0, 5 - maxShelves);
                int missingScrewsForWorkbench = Math.Max(0, 10 - maxScrews);
                int missingShelvesForWorkbench = Math.Max(0, 2 - maxShelves);
                message = $"Недостаточно ресурсов для изготовления шкафов или верстаков.\n" +
                          $"Для шкафа не хватает: {missingScrewsForCabinet} саморезов, {missingShelvesForCabinet} полок.\n" +
                          $"Для верстака не хватает: {missingScrewsForWorkbench} саморезов, {missingShelvesForWorkbench} полок.";
            }
            else
            {
                if (cabinets == 0)
                {
                    int missingScrews = Math.Max(0, 20 - maxScrews);
                    int missingShelves = Math.Max(0, 5 - maxShelves);
                    message += $"Для шкафа не хватает: {missingScrews} саморезов, {missingShelves} полок.\n";
                }
                if (workbenches == 0)
                {
                    int missingScrews = Math.Max(0, 10 - maxScrews);
                    int missingShelves = Math.Max(0, 2 - maxShelves);
                    message += $"Для верстака не хватает: {missingScrews} саморезов, {missingShelves} полок.";
                }
            }
            MessageBox.Show(message);
        }
        private (int cabinets, int workbenches) CalculateProducts(int screws, int bigDoors, int smallDoors, int shelves)
        {
            int cabinets = Math.Min(screws / 20, Math.Min(bigDoors / 2, shelves / 5));
            screws -= cabinets * 20;
            bigDoors -= cabinets * 2;
            shelves -= cabinets * 5;

            int workbenches = Math.Min(screws / 10, Math.Min(smallDoors / 2, shelves / 2));

            return (cabinets, workbenches);
        }
        
    }


}



public class DatabaseHelper
{
    private string connection;
    public DatabaseHelper(string DBpath)
    {
        string BDpath = @"DataBase";
    }
    public int GetMaterialsCount(string materialName)
    {
        string BDpath = @"DataBase";
        using (var connection = new SqliteConnection(BDpath))
        {
            connection.Open();
            string query = $"SELECT Count FROM Sklad WHERE Name = '{materialName}'";
            using (var command = new SqliteCommand(query, connection))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

    }
}



