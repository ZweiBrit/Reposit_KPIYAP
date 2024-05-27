using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class Form1 : Form
    {
        DataSet ds;
        BindingSource bs1;
        BindingSource bs2;

        public Form1()
        {
            InitializeComponent();
            SetupBindings();
            FetchData();
            ApplyDataBindings();
        }

        private void SetupBindings()
        {
            bs1 = new BindingSource();
            bs2 = new BindingSource();
            dataGridView1.DataSource = bs1;
            dataGridView2.DataSource = bs2;
            bindingNavigator1.BindingSource = bs1;
        }

        private void FetchData()
        {
            string connString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                ds = new DataSet();

                string[] tables = { "Туристы", "Туры" };

                foreach (string table in tables)
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"SELECT * FROM {table}", conn);
                    dataAdapter.Fill(ds, table);
                }
            }
        }

        private void ApplyDataBindings()
        {
            bs1.DataSource = ds.Tables[0];
            bs2.DataSource = ds.Tables[1];

            textBox1.DataBindings.Add("Text", bs1, "Фамилия");
            textBox2.DataBindings.Add("Text", bs1, "Имя");
            textBox3.DataBindings.Add("Text", bs1, "Отчество");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var currentRow = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
                if (currentRow != null)
                {
                    textBox1.Text = currentRow["Фамилия"].ToString();
                    textBox2.Text = currentRow["Имя"].ToString();
                    textBox3.Text = currentRow["Отчество"].ToString();
                }
            }
        }
    }
}
