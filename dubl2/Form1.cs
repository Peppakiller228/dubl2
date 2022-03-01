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
            proig = 0; // Глобальные данные( счётчик побед и поражений)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
            simpleSound.Play(); // Звук победы кнопочка ( в правилах)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\User\Downloads\lose.wav");
            simpleSound1.Play(); // Звук поражения кнопка( в правилах)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3); // В главном меню кнопка направляющия куда-то
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2); // В главном меню кнопка направляющия куда-то
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b; // Цветовая Лотерея ( а число красных , b число зеленых)
            Random rn = new Random();
            a = rn.Next(1, 10);
            b = 0;
            if (a < 5) // рандомайзер ( если чило меньше 5 оно становится красным( по правилам 3 красных луз)
            {
                button8.BackColor = Color.Red; 
            }
            else  // рандомайзер ( если чило больше  5 оно становится зеленым( по правилам 3 зеленых вин)
            {
                button8.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5) // рандомайзер ( если чило меньше 5 оно становится красным( по правилам 3 красных луз)
            {
                button9.BackColor = Color.Red;
            }
            else // рандомайзер ( если чило больше  5 оно становится зеленым( по правилам 3 зеленых вин)
            {
                button9.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5) // рандомайзер ( если чило меньше 5 оно становится красным( по правилам 3 красных луз)
            {
                button10.BackColor = Color.Red;
            }
            else // рандомайзер ( если чило больше  5 оно становится зеленым( по правилам 3 зеленых вин)
            {
                button10.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10);
            if (a < 5) // рандомайзер ( если чило меньше 5 оно становится красным( по правилам 3 красных луз)
            {
                button11.BackColor = Color.Red;
            }
            else // рандомайзер ( если чило больше  5 оно становится зеленым( по правилам 3 зеленых вин)
            {
                button11.BackColor = Color.Green;
                b = b + 1;
            }
            a = rn.Next(1, 10); // рандомайзер ( если чило меньше 5 оно становится красным( по правилам 3 красных луз)
            if (a < 5)
            {
                button12.BackColor = Color.Red;
            }
            else // рандомайзер ( если чило больше  5 оно становится зеленым( по правилам 3 зеленых вин)
            {
                button12.BackColor = Color.Green;
                b = b + 1;
            }
            if (b >= 3) // Если зеленых больше 3 то победа
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                simpleSound.Play();
                pobedi += 1;
            }
            else  // это если меньше луз
            {
                SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\User\Downloads\lose.wav");
                simpleSound1.Play();
                proig += 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e) // Числовая лотерея
        {
            int k, j, take, take1, govno; // к это переменная для рандомайзера, j счетчик похожих числе, take берет число с ComboBox, тэйк1 берет с текстбокса, говно 
            take1 = 0;
            Random rn = new Random();
            j = 0;
            if (checkBox1.Checked == true) 
            {
                take1 = Convert.ToInt32(textBox11.Text);  
                if (take1 <= 0)  // Если число 0 или меньше его( такое незя выбирать)
                {
                    MessageBox.Show("nado vibrat, and nezya - chisli i 0");
                }
                else
                {
                    take1 += 1;
                    j = 0;
                    k = rn.Next(0, take1);
                    textBox1.Text = k.ToString(); // Рандомайзер дает число случайное для к и помещает его в текстбокс( на картинку и позже будет считывать кол-во совпадений
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
                        j = j + 1; // Это все счетчики схожих чисел
                    }
                    if (j == 3 || j>3) // если вин
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                        simpleSound.Play();
                        pobedi += 1;
                    }
                    else // если луз
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
                    k = rn.Next(0, take); // Рандомайзер дает число случайное для к и помещает его в текстбокс( на картинку и позже будет считывать кол-во совпадений
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
                        j = j + 1; // Это все счетчики схожих чисел
                    }
                    if (j >= 3) // если вин
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Downloads\win.wav");
                        simpleSound.Play();
                        pobedi += 1;
                    }
                    else // если луз
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

        private void button15_Click(object sender, EventArgs e) // это Счетчик
        {
            button15.Text = "Îáíîâèòü";
            int klvo, wr, pdz; // для математических вычеслений
            if( checkBox2.Checked == true) //  берет с коробочки где надо галочку поставить
            {
                label6.Text = "Ïîáåäû " + pobedi;  // выйгранные показывает
            }
            if ( checkBox3.Checked == true) //  берет с коробочки где надо галочку поставить
            {

                label7.Text = "Ïîðàæåíèÿ " + proig; // проигранные игры показывает
            }
            if ( checkBox4.Checked == true) //  берет с коробочки где надо галочку поставить
            {
                klvo = pobedi + proig; // Счетчик обшего кол-во игр
                label8.Text = "Êîë-âî èãð " + klvo;
            }
            if ( checkBox5.Checked == true) //  берет с коробочки где надо галочку поставить
            {
                wr = pobedi + proig; 
                wr = 100 / wr;
                wr = wr * pobedi; // wr = 100 / (pobedi + proig) * pobedi Счетчик Винрейта
                label9.Text = "Âèíðåéò " + wr; 
                progressBar1.Visible = true; // это такая полосочка которая заполняется (ProgressBar) Собственно изученный материал.
                progressBar1.Maximum = 100; // Макс значение
                progressBar1.Minimum = 1; // Мин значение 
                progressBar1.Value = wr; //и вообще его значение( Насколько оно заполнится) 
            }
            if ( checkBox6.Checked == true)
            {
                pdz = proig - pobedi; // Сколько ударов по затылку получишь( по правилам проиграл удар по затыльнику, но если отыгрался то не получаешь его( в этом и азарт))
                if (pdz <= 0)
                {
                    label10.Text = "íó òû è âåçó÷èé 0 ïîäçàòûëíèêîâ"; 
                }
                else
                {
                    label10.Text = "Êîë-âî ïîäçàòûëíèêîâ " + pdz;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage5); // кнопка направляющия куда-то
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4); // кнопка направляющия куда-то
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4); // кнопка направляющия куда-то
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3); // кнопка направляющия куда-то

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
