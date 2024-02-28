using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Spanzuratoare
{
    public partial class Form1 : Form
    {
        int viata = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void VerificaCastig()
        {
            foreach( Control control in flowLayoutPanel1.Controls)
            {
                if (control.Text == "")
                    return;
            }
            MessageBox.Show("Bravo, ai ghicit si tu un cuvant");
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IncepereJoc(string linie)
        {
            flowLayoutPanel1.Controls.Clear();
            label2.Text = "";
            string[] parts = linie.Split('-');
            string cuvant = parts[0];
            string indiciu = parts[1];
            label2.Text = indiciu;

            for(int i=0; i<cuvant.Length; i++)
            {
                Label label = new Label();
                label.Text = "";
                label.Width = 30;
                label.BackColor = Color.LightGray;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
                label.Tag = cuvant[i];
                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (File.Exists("Cuvinte.txt"))
            {
                string[] lines = File.ReadAllLines("Cuvinte.txt");
                Random rand = new Random();
                int linie = rand.Next(0, lines.Length);
                IncepereJoc(lines[linie]);
            }
            else
                MessageBox.Show("Nu exista cuvinte pe care sa le ghicesti!");
        }

        private void SchimbaPoza()
        {
            viata++;

            if(viata == 2)
            {
                pictureBox1.Image = Image.FromFile("Stare2.png");
            }
            if (viata == 3)
            {
                pictureBox1.Image = Image.FromFile("Stare3.png");
            }
            if (viata == 4)
            {
                pictureBox1.Image = Image.FromFile("Stare4.png");
            }
            if (viata == 5)
            {
                pictureBox1.Image = Image.FromFile("Stare5.png");
            }
            if (viata == 6)
            {
                pictureBox1.Image = Image.FromFile("Stare6.png");
            }


            if (viata == 6)
            {
                MessageBox.Show("Ai pierdut fraere :((((((((((( ");
                Form2 f = new Form2();
                f.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button1.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button2.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button3.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button4.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button8.Text[0])
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button7.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button6.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button5.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button12.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button11.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button10.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button9.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button16.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button15.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button14.Text[0])
                    {
                        control.Text = tag.ToString();
                        gasit = true;
                       VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button13.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button20.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button19.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button18.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button17.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button24.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button23.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button22.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button21.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button28.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Visible = false;
            bool gasit = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Label && control.Tag is char) 
                {
                    char tag = (char)control.Tag;
                    if (tag == button27.Text[0]) 
                    {
                        control.Text = tag.ToString(); 
                        gasit = true;
                        VerificaCastig();
                    }
                }
            }

            if (!gasit)
                SchimbaPoza();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
