using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewProfile : Form
    {
        //SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=mydb.db");

        SQLiteCommand command;
        public NewProfile()
        {
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SQLiteCommand(conn);
            command.CommandText = "INSERT INTO users (Name,password) " +
                                               "values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            command.ExecuteNonQuery();
            conn.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            command.Dispose();
            MessageBox.Show("Entry submitted");
        }
    }
}
