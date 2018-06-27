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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            //sq = new SQLiteCommand("select name,cnic,entry_t,exit_t from table1 WHERE exit_t !='-'", scn);
            sq = new SQLiteCommand("select name,password from users WHERE name ='ali'", scn);

            SQLiteDataReader dr = sq.ExecuteReader();
            dr.Read();
            Console.WriteLine(dr["name"]);
            Console.WriteLine(dr["password"]);

             if (userNameBox.Text.ToString().Equals(dr["name"]) && passwordTextbox.Text.ToString().Equals(dr["password"]))
            //if(true)
            {
                scn.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                sq.Dispose();


                Form1 frm = new Form1();
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("sorry");
                scn.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
               
        }
    }
}
