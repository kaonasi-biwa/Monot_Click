using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monot_Click
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            Random r1 = new System.Random(Environment.TickCount + this.Height);
            Random r2 = new System.Random(Environment.TickCount + this.Width);
            form2.Left = r1.Next(0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 256);
            form2.Top = r2.Next(0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 300);
            form2.StartPosition = FormStartPosition.Manual;
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
