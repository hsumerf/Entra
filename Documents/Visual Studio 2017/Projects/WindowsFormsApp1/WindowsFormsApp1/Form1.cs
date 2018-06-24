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
using System.IO;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {


        public string admin;
   
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
        SQLiteCommand command;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SQLiteCommand(conn);

            //if (!File.Exists(DatabaseFile))
            //{

            //    SQLiteConnection.CreateFile(DatabaseFile);
            //    command.CommandText = CreateTableQuery;
            //    command.ExecuteNonQuery();

            //}
            //Entry entries = new Entry(DateTime.Now, VisitPurpose.Text);
            //Profile profileUser = new Profile(visitorName.Text, FatherName.Text, CNIC.Text, ContactNo.Text, Address.Text, entries);
            //List<Profile> profilesList = new List<Profile>();
           // profilesList.Add(profileUser);

            command.CommandText = "INSERT INTO table1 (Name,CNIC,Contactno,purpose,entry_t,exit_t,date,admin) " +
                                               "values ('"+ visitorName.Text + "','"+CNIC.Text+"','"+ContactNo.Text+ "','"+VisitPurpose.Text+"','"
                                               + DateTime.Now.ToShortTimeString().ToString() + "','" + "-" + "','" + dateTimePicker3.Text + "','" + admin + "')";
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Entry submitted");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "6565";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
