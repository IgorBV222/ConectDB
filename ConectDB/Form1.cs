using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;


namespace ConectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "create table tmp(id int, tt varchar(20))";
            cmd.ExecuteNonQuery();
            conn.Close();





        }
    }
}
