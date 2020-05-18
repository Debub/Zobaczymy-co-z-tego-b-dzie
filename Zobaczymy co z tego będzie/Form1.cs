using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zobaczymy_co_z_tego_będzie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Random rand = new Random();
        Button Guziczek = new Button();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Twoje punkty " + c;
        }
        int a = 150, b = 150, c = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            a--;
            b--;
            c++;
            textBox1.Text = "Twoje punkty " + c;
            Guziczek.Location = new Point(rand.Next(50,600), rand.Next(50,350));
            Guziczek.Height = a;
            Guziczek.Width = b;
            Guziczek.Text = "Klinij mnie";
            Guziczek.Click += new EventHandler(button1_Click);
            Controls.Remove(button1100);
            Controls.Remove(Guziczek);
            Controls.Add(Guziczek);
            
        }         
    }
}
