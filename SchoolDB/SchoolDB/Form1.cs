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

namespace SchoolDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            float Grade = float.Parse(textBox2.Text);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\SchoolDB\SchoolDB\SchoolDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("connection successfull");
                    string query = "INSERT INTO Student(Name,Grade)VALUES(@Name,@Grade);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Grade", Grade);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data added");
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\SchoolDB\SchoolDB\SchoolDB.mdf;Integrated Security=True";
            int ID = int.Parse(textBox3.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("connection successfull");
                    string query = "DELETE FROM Student WHERE ID=@ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        int result= command.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("Data deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not Found");
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Advanced programming\SchoolDB\SchoolDB\SchoolDB.mdf;Integrated Security=True";
            int ID = int.Parse(textBox4.Text);
            string Name = textBox5.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("connection successfull");
                    string query = "UPDATE Student SET Name=@Name WHERE ID=@ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Updated");
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


