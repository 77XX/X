using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sexual.Items.Clear();
            if(sexual.SelectedIndex == 0)
            {
                st.Items.Clear();
                st.Items.Add("休闲");
                st.Items.Add("商务");
                st.Items.Add("运动");
                st.Items.Add("简约");
                st.Items.Add("欧美");
                st.Items.Add("英伦");
                st.Items.Add("韩风");
                st.Items.Add("日系");
                st.Items.Add("复古");
                st.Items.Add("街头");
            }
            else if(sexual.SelectedIndex == 1)
            {
                st.Items.Clear();
                st.Items.Add("原宿");
                st.Items.Add("嘻哈");
                st.Items.Add("民族");

                st.Items.Add("欧美");
                st.Items.Add("学院");
                st.Items.Add("田园");
                st.Items.Add("淑女");
                st.Items.Add("简约");
                st.Items.Add("中性");
                st.Items.Add("韩版");
                st.Items.Add("甜美");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sexual.Items.Add("男");
            sexual.Items.Add("女");
            face.Items.Add("鹅蛋脸");
            face.Items.Add("圆脸");
            face.Items.Add("逆三角");
            face.Items.Add("长方脸");
            face.Items.Add("菱形脸");
            face.Items.Add("瓜子脸");
            face.Items.Add("方脸");
            b.Items.Add("梯形");
            b.Items.Add("倒三角");
            b.Items.Add("矩形");
            b.Items.Add("正三角形");
            b.Items.Add("椭圆形");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sexual.SelectedIndex==0&&st.SelectedIndex == 0)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 1)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 2)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 3)
            {
                Form5 form5 = new Form5();
                this.Hide();
                form5.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 4)
            {
                Form6 form6 = new Form6();
                this.Hide();
                form6.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 5)
            {
                Form7 form7 = new Form7();
                this.Hide();
                form7.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 6)
            {
                Form8 form8 = new Form8();
                this.Hide();
                form8.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 7)
            {
                Form9 form9 = new Form9();
                this.Hide();
                form9.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 8)
            {
                Form10 form10 = new Form10();
                this.Hide();
                form10.Show();
            }
            if (sexual.SelectedIndex == 0 && st.SelectedIndex == 9)
            {
                Form11 form11 = new Form11();
                this.Hide();
                form11.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 0)
            {
                Form12 form12 = new Form12();
                this.Hide();
                form12.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 1)
            {
                Form13 form13 = new Form13();
                this.Hide();
                form13.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 2)
            {
                Form14 form14 = new Form14();
                this.Hide();
                form14.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 3)
            {
                Form15 form15 = new Form15();
                this.Hide();
                form15.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 4)
            {
                Form16 form16 = new Form16();
                this.Hide();
                form16.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 5)
            {
                Form17 form17 = new Form17();
                this.Hide();
                form17.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 6)
            {
                Form18 form18 = new Form18();
                this.Hide();
                form18.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 7)
            {
                Form19 form19 = new Form19();
                this.Hide();
                form19.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 8)
            {
                Form20 form20 = new Form20();
                this.Hide();
                form20.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 9)
            {
                Form21 form21 = new Form21();
                this.Hide();
                form21.Show();
            }
            if (sexual.SelectedIndex == 1 && st.SelectedIndex == 10)
            {
                Form22 form22 = new Form22();
                this.Hide();
                form22.Show();
            }
        }
    }
}
