using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reactangle shape = new Reactangle();
            shape.Width = int.Parse(textBox1.Text);
            shape.Height = int.Parse(textBox2.Text);
            double Area = shape.Area();
            label4.Text = Area.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Radius = int.Parse(textBox3.Text);
            double Area = circle.Area();
            label5.Text = Area.ToString();

        }
    }
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
    public class Reactangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

}
