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
using System.Threading;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

          
        public string CurrentAdmin { get; set; }

        //SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=mydb.db");

      //  SQLiteCommand command;
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
            // for sing in username
           // listView1.Items.Clear();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
            SQLiteConnection scn = new SQLiteConnection(@"Data Source = mydb.db");

            scn.Open();
            // sql columns names are in small letter
            SQLiteCommand sq = new SQLiteCommand("INSERT INTO profiles (cnic,name,fatherName,contact,address) " +
                                               "values ('" + CNIC.Text + "','" + visitorName.Text + "','" + fatherName.Text + "','" + ContactNo.Text + "','" + address.Text + "')", scn);
            sq.ExecuteNonQuery();
         //   SQLiteCommand sq = new SQLiteCommand("INSERT INTO entries (cnic,entry_t,entry_date exit_time,exit_date,operator) " +
           //                                    "values ('" + CNIC.Text + "','" + fatherName.Text + "','" + ContactNo.Text + "','" + address.Text + "')", scn);
           // sq.ExecuteNonQuery();
            scn.Close();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            //scn.Open();

            //command = new SQLiteCommand(scn);


            //if (!File.Exists(DatabaseFile))
            //{

            //    SQLiteConnection.CreateFile(DatabaseFile);
            //    command.CommandText = CreateTableQuery;
            //    command.ExecuteNonQuery();

            //}
            //Entry entries = new Entry(DateTime.Now, VisitPurpose.Text);

            //command.CommandText = ;
            //command.ExecuteNonQuery();
            //conn.Close();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //command.Dispose();
            MessageBox.Show("by"+ CurrentAdmin);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Active Window";
            MessageBox.Show(CurrentAdmin);
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

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            SQLiteCommand sq_t;
            sq = new SQLiteCommand("select name,cnic from profiles", scn);
            SQLiteDataReader dr = sq.ExecuteReader();
            sq_t = new SQLiteCommand("select  entry_time from entries", scn);
            SQLiteDataReader dr_t = sq_t.ExecuteReader();

            int index = 1;
            while (dr.Read() && dr_t.Read())
            {
                String indexTab = index.ToString();
                listView1.Items.Add(new ListViewItem(new[] {
                                                            indexTab,
                                                             dr["name"].ToString(),
                                                             dr["cnic"].ToString(),
                                                            dr_t["entry_time"].ToString()
                                                             }));
                index++;


            }
            scn.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            sq.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");
            scn.Open();

            // for ID in data base 
            SQLiteCommand sq;
            sq = new SQLiteCommand("SELECT id FROM entries", scn);
            SQLiteDataReader dr = sq.ExecuteReader();
            sq = new SQLiteCommand("update entries set exit_time='" + DateTime.Now.ToShortTimeString() + "' where id='" + listView1.SelectedItems[0].Text + "'", scn);
            Console.WriteLine(listView1.SelectedItems[0].Text);
            sq.ExecuteNonQuery();
            button3.PerformClick();
        }

        private void fatherName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

