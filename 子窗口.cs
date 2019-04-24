using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        string[] path = Directory.GetFiles(@"D:\搭配\男\复古\上装\");
        string[] path1 = Directory.GetFiles(@"D:\搭配\男\复古\下装\");
        int i = 0;
        int j = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Stream s = File.Open(path[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            pictureBox1.Image = Image.FromStream(s);
            s.Close();
            Stream s1 = File.Open(path1[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            pictureBox2.Image = Image.FromStream(s1);
            s1.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            i--;
            j--;
            if (i < 0)
            {
                i = path.Length - 1;
            }
            if (j < 0)
            {
                j = path1.Length - 1;
            }
            Stream s = File.Open(path[i], FileMode.Open);
            pictureBox1.Image = Image.FromStream(s);
            s.Close();
            Stream s1 = File.Open(path1[j], FileMode.Open);
            pictureBox2.Image = Image.FromStream(s1);
            s1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            j++;
            if (i > path.Length - 1)
            {
                i = 0;//到最后一张，返回第一张
            }
            if (j > path1.Length - 1)
            {
                j = 0;
            }
            Stream s = File.Open(path[i], FileMode.Open);
            pictureBox1.Image = Image.FromStream(s);
            s.Close();
            Stream s1 = File.Open(path1[j], FileMode.Open);
            pictureBox2.Image = Image.FromStream(s1);
            s1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
