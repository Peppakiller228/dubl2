using System;
using System.Media;

namespace dubl2
{
    public partial class Form1 : Form
    {

        public static int pobedi;
        public static int proig;
        public Form1()
        {
            InitializeComponent();

            pobedi = 0;
            proig = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
            simpleSound.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\User\Downloads\lose.wav");
            simpleSound1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b;
            Random rn = new Random();
            a = rn.Next(1, 10);
            b = 0;
            if (a < 5)
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5)
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5)
            {
                button10.BackColor = Color.Red;
            }
            else
            {
                button10.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5)
            {
                button11.BackColor = Color.Red;
            }
            else
            {
                button11.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5)
            {
                button12.BackColor = Color.Red;
            }
            else
            {
                button12.BackColor = Color.Green;
                b = b + 1;
            }
            if (b >= 3)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                simpleSound.Play();
                pobedi += 1;
            }
            else
            {
                SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\User\Downloads\lose.wav");
                simpleSound1.Play();
                proig += 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int k, j, take, take1, govno;
            take1 = 0;
            Random rn = new Random();
            j = 0;
            if (checkBox1.Checked == true)
            {
                take1 = Convert.ToInt32(textBox11.Text);
                if (take1 <= 0)
                {
                    MessageBox.Show("nado vibrat, and nezya - chisli i 0");
                }
                else
                {
                    take1 += 1;
                    j = 0;
                    k = rn.Next(0, take1);
                    textBox1.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox2.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox3.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox4.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox5.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox10.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox6.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox7.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox8.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox9.Text = k.ToString();
                    k = rn.Next(0, take1);
                    textBox10.Text = k.ToString();
                    if (textBox5.Text == textBox10.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox4.Text == textBox9.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox3.Text == textBox8.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox2.Text == textBox7.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox1.Text == textBox6.Text)
                    {
                        j = j + 1; // Код может показаться массивным, но других путей я не знаю
                    }
                    if (j == 3 || j>3)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                        simpleSound.Play();
                        pobedi += 1;
                    }
                    else
                    {
                        SoundPlayer simpleSound1 = new SoundPlayer(@"");
                        simpleSound1.Play();
                        proig += 1;
                    }
                }
                
               
                }
            if (checkBox1.Checked == false)
            {
                take = comboBox1.SelectedIndex + 2;
                j = 0;
                if (take <= 0)
                {
                    MessageBox.Show("nado vibrat, and nezya - chisli i 0");
                }
                else
                {
                    k = rn.Next(0, take);
                    textBox1.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox2.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox3.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox4.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox5.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox10.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox6.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox7.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox8.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox9.Text = k.ToString();
                    k = rn.Next(0, take);
                    textBox10.Text = k.ToString();
                    if (textBox5.Text == textBox10.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox4.Text == textBox9.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox3.Text == textBox8.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox2.Text == textBox7.Text)
                    {
                        j = j + 1;
                    }
                    if (textBox1.Text == textBox6.Text)
                    {
                        j = j + 1; // Код может показаться массивным, но других путей я не знаю
                    }
                    if (j >= 3)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                        simpleSound.Play();
                        pobedi += 1;
                    }
                    else
                    {
                        SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\User\Downloads\lose.wav");
                        simpleSound1.Play();
                        proig += 1;
                    }
                }
            }
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "Обновить";
            int klvo, wr, pdz;
            if( checkBox2.Checked == true)
            {
                label6.Text = "Победы " + pobedi;
            }
            if ( checkBox3.Checked == true)
            {

                label7.Text = "Поражения " + proig;
            }
            if ( checkBox4.Checked == true)
            {
                klvo = pobedi + proig;
                label8.Text = "Кол-во игр " + klvo;
            }
            if ( checkBox5.Checked == true)
            {
                wr = pobedi + proig;
                wr = 100 / wr;
                wr = wr * pobedi; // wr = 100 / (pobedi + proig) * pobedi
                label9.Text = "Винрейт " + wr;
                progressBar1.Visible = true;
                progressBar1.Maximum = 100;
                progressBar1.Minimum = 1;
                progressBar1.Value = wr;
            }
            if ( checkBox6.Checked == true)
            {
                pdz = proig - pobedi;
                if (pdz <= 0)
                {
                    label10.Text = "ну ты и везучий 0 подзатылников";
                }
                else
                {
                    label10.Text = "Кол-во подзатылников " + pdz;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}