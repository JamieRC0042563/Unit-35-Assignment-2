using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //get length, width and height from the textboxes
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                //calculates the area and the volume 
                double area = 2.0 * ((length * width) + (length * height) + (width * Height));
                double volume = length * width * height;
                //put values into labels 
                label1.Text = "Surface area = " + area;
                label2.Text = "Volume = " + volume;
            }
            catch
            {
                //show error message if program fails 
                MessageBox.Show("Error!"); 
            }
        }
    }
}
