using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Car
        {
            private string brand;
            private string color;
            public Car (string Brand , string Color)
            {
                Brand = brand;
                Color = color;
                brand = "BMW";
                color = "Black";
            }
            ~Car()
            {
                MessageBox.Show($"brand:{brand} , color:{color}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Car mycar = new Car("BMW","Black");
        }
    }
}
