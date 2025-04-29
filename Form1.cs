using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Law_background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label titlelabel = new Label();
            titlelabel.Text = "مكتب المستشار:صبري محمد";
            titlelabel.Font = new Font("Arial", 48, FontStyle.Bold);
            titlelabel.ForeColor = Color.Black;
            titlelabel.BackColor = Color.FromArgb(200, Color.BurlyWood);
            titlelabel.AutoSize = true;
            titlelabel.Location = new Point(12, 39);
            this.Controls.Add(titlelabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "تقديم بيانات العملاء";
            button1.Font = new Font("Arial", 24, FontStyle.Bold);
            button1.Size = new Size(250, 40);
            button1.Location = new Point(12, 633);
            this.Controls.Add(button1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = new Button();
            button2.Text = "التواصل مع المكتب";
            button2.Font = new Font("Arial", 24, FontStyle.Bold);
            button2.Size = new Size(250, 40);
            button2.Location = new Point(12, 940);
            this.Controls.Add(button2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button3 = new Button();
            button3.Text = "اتاحة فرص للتدريب";
            button3.Font = new Font("Arial", 24, FontStyle.Bold);
            button3.Size = new Size(250, 40);
            button3.Location = new Point(12, 1241);
            this.Controls.Add(button3);
        }
    }
}

