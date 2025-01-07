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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\Accounting\Accounting\Accounting.mdf;Integrated Security=True";
            SqlConnection connection = null;
            try
            {
                string Name = textBox1.Text;
                string Family = textBox2.Text;
                string Stunum = textBox3.Text;
                string Phone = textBox4.Text;
                string Major = textBox5.Text;
                string Address = textBox6.Text;
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO Students (name,family,stunum,phone,major,address) VALUES(@Name,@Family,@Stunum,@Phone,@Major,@Address);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@family", Family);
                command.Parameters.AddWithValue("@stunum", Stunum);
                command.Parameters.AddWithValue("@phone", Phone);
                command.Parameters.AddWithValue("@major", Major);
                command.Parameters.AddWithValue("@address", Address);
                command.ExecuteNonQuery();
                MessageBox.Show("دانشجو با موفقیت ثبت شد");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = " ";
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
