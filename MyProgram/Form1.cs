using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
        

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(connectionString);
            da = new SqlDataAdapter("Select * from Branch", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Branch");

            bindingSource1.DataSource = ds.Tables["Branch"];
            dGVStateBranch.DataSource = bindingSource1;

        }

        private void add_Click(object sender, EventArgs e)
        {
             bool b = true;
            FormAdd formAdd = new FormAdd();
            
           
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                DataRow newRow = /*bindingSource1.AddNew() as DataRow*/ds.Tables["Branch"].NewRow();

                newRow["id"] = 1;
                newRow["name"] = formAdd.textBoxName.Text;
                newRow["address"] = formAdd.textBoxCountry.Text;
                newRow["fio"] = formAdd.textBoxSubname.Text;
                newRow["email"] = formAdd.textBoxMail.Text;
                newRow["state"] = "Activ";

                ds.Tables["Branch"].Rows.Add(newRow);
                //ds.Tables["Branch"].
               // bindingSource1.EndEdit();
            }
           // bindingSource1.EndEdit();
            bindingSource1.ResetBindings(b);
            
        }
        
    }
}
