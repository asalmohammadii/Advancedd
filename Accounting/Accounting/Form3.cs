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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\Accounting\Accounting\Accounting.mdf;Integrated Security=True";
        SqlConnection connection = null;
        string id;
        public void Refresh()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("گزینه مورد نظر ");
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM Students;";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string row = reader["id"].ToString() + ":" + reader["name"].ToString() + " " +
                        reader["family"].ToString() + "-" + reader["stunum"].ToString();
                    comboBox1.Items.Add(row);
                }
                comboBox1.SelectedIndex = 0;
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
            private void button1_Click(object sender, EventArgs e)
            {
            try
            {
                string selected = comboBox1.SelectedItem.ToString();
                int index = selected.IndexOf(":");
                id = selected.Substring(0, index);
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM Students WHERE id=@id;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("دانشجو با موفقیت حذف شد");
                Refresh();

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
        private void Form3_Load(object sender, EventArgs e)
        {
                Refresh();
        }
    }
}
