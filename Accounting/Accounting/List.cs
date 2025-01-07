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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\Accounting\Accounting\Accounting.mdf;Integrated Security=True";
        SqlConnection connection = null;
        private void List_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM Students;";
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
        }
        string id;
        string shahrie;
        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT(shahrie) FROM Students WHERE id='{id}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                shahrie = reader["shahrie"].ToString();
                MessageBox.Show("تومان توسط این دانشجو پرداخت شده" + " " + shahrie);
            }
            
            connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1] !=null)
            {
                string firstname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string lastname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                id= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = firstname + " " + lastname;
                button1.Enabled = true;

            }
        }
    }
}
