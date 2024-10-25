using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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
            private int speed;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public int Speed
            {
                get { return speed; }
                set { if (value >= 70 && value <= 120) speed = value; }
            }
            public string  PrintInfo()
            {
              return $"Brand:{Brand} , Speed:{Speed} km/h";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car mycar = new Car();
            mycar.Brand = textBox1.Text;
            mycar.Speed =int.Parse( textBox2.Text);
            label3.Text = mycar.PrintInfo();
        }
    }
}
