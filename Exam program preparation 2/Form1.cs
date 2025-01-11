using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_program_preparation_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            UserControl1 userControl = new UserControl1(100,100,50);
            userControl.NumericChanged += DrawCircle;
            userControl.CircleRemove += CircleRemove;
            flowLayoutPanel1.Controls.Add(userControl);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DrawCircle()
        {
            g.Clear(Color.White);
            foreach (UserControl1 userControl in flowLayoutPanel1.Controls)
            {
                g.DrawEllipse(new Pen(Color.Black), userControl.X - userControl.R, 
                    userControl.Y - userControl.R, userControl.R * 2, userControl.R * 2);
            } 
            pictureBox1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1(10, 10, 10);
            flowLayoutPanel1.Controls.Add(userControl1);
            userControl1.NumericChanged += DrawCircle;
            userControl1.CircleRemove += CircleRemove;
            DrawCircle();
        }
        private void CircleRemove(object sender)
        {
            flowLayoutPanel1.Controls.Remove(sender as UserControl1);
            DrawCircle();
        }
    }
}
