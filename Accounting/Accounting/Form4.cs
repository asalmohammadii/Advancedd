using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\Accounting\Accounting\Accounting.mdf;Integrated Security=True";
        SqlConnection connection = null;
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "2500000 تومان";
            textBox2.Text = "20";
            textBox3.Text = "14";
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT * FROM Students WHERE paid='{1}'";
                SqlCommand command = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT * FROM Students WHERE paid='{0}'";
                SqlCommand command = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
