using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "تقديم بيانات العملاء";
            this.Size = new Size(1277, 191);
            this.BackColor = Color.BurlyWood;
            label1.Font = new Font("Arial", 36, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Location = new Point(87, 9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Law_background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", 24, FontStyle.Bold);
            this.BackColor = Color.BurlyWood;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(630, 133);
            label2.Location = new Point(967, 267);
            this.Text = "الاسم كامل";
            label2.Location = new Point(textBox1.Left + textBox1.Width +25, textBox1.Top);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Font = new Font("Arial", 24, FontStyle.Bold);
            this.BackColor = Color.BurlyWood;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(630, 133);
            label3.Location = new Point(968, 484);
            this.Text = "الرقم القومي";
            label3.Location = new Point(textBox2.Left + textBox2.Width + 25, textBox2.Top);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Font = new Font("Arial", 24, FontStyle.Bold);
            this.BackColor = Color.BurlyWood;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(630, 133);
            label4.Location = new Point(963, 689);
            this.Text = "رقم الهاتف";
            label4.Location = new Point(textBox3.Left + textBox3.Width + 25, textBox3.Top);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Font = new Font("Arial", 24, FontStyle.Bold);
            this.BackColor = Color.BurlyWood;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(630, 133);
            label5.Location = new Point(957, 935);
            this.Text = "العنوان";
            label5.Location = new Point(textBox4.Left + textBox4.Width + 25, textBox4.Top);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Font = new Font("Arial", 24, FontStyle.Bold);
            this.BackColor = Color.BurlyWood;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(630, 133);
            label6.Location = new Point(955, 1165);
            this.Text = "اسم المحكمه التابع لها";
            label6.Location = new Point(textBox5.Left + textBox5.Width + 25, textBox5.Top);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 18, FontStyle.Bold);
            textBox1.BackColor = Color.BurlyWood;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.RightToLeft = RightToLeft.Yes;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font("Arial", 18, FontStyle.Bold);
            textBox2.BackColor = Color.BurlyWood;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.RightToLeft = RightToLeft.Yes;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Font = new Font("Arial", 18, FontStyle.Bold);
            textBox3.BackColor = Color.BurlyWood;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.RightToLeft = RightToLeft.Yes;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Font = new Font("Arial", 18, FontStyle.Bold);
            textBox4.BackColor = Color.BurlyWood;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.RightToLeft = RightToLeft.Yes;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Font = new Font("Arial", 18, FontStyle.Bold);
            textBox5.BackColor = Color.BurlyWood;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.TextAlign = HorizontalAlignment.Right;
            textBox5.RightToLeft = RightToLeft.Yes;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Font = new Font("Arial", 24, FontStyle.Bold);
            radioButton1.BackColor = Color.BurlyWood;
            radioButton1.RightToLeft = RightToLeft.Yes;
            this.Text = "شاكي";
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Font = new Font("Arial", 24, FontStyle.Bold);
            radioButton2.BackColor = Color.BurlyWood;
            radioButton2.RightToLeft = RightToLeft.Yes;
            this.Text = "مشكو منه";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Font = new Font("Arial", 24, FontStyle.Bold);
            comboBox1.BackColor = Color.BurlyWood;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.RightToLeft = RightToLeft.Yes;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Arial", 24, FontStyle.Bold);
            button1.BackColor = Color.BurlyWood;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Cursor = Cursors.Hand;
        }
    }
}
