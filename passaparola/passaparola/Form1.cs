using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0,bos=0;

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
        int sayac = 0;

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            sayac = 0;
            linkLabel1.Text = "Sonraki";
            linkLabel1.Enabled = false;
            soruno++;
            
           
            


            textBox1.Enabled = true;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir ?";
                button1.BackColor = Color.Yellow;
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = " Uludağ hangi ilimizde bulunmaktadır ?";
                button2.BackColor = Color.Yellow;

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                button3.BackColor = Color.Yellow;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Türkiyenin karpuzuyla ünlü şehri neresidir ?";
                button4.BackColor = Color.Yellow;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                button5.BackColor = Color.Yellow;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = " Padişahın emirlerinin yazılı hali ?";
                button6.BackColor = Color.Yellow;

            }
            if (soruno ==7 )
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı  ?";
                button7.BackColor = Color.Yellow;

            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne ?";
                button8.BackColor = Color.Yellow;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = " Gülüyle ünlü ilimiz ?";
                button9.BackColor = Color.Yellow;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Şehirin eş anlamlısı ?";
                button10.BackColor = Color.Yellow;

            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                button11.BackColor = Color.Yellow;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi ?";
                button12.BackColor = Color.Yellow;

            }
            if (soruno == 13)
            {
                richTextBox1.Text = " Osmanlı hanedanını temsil eden çiçek ?";
                button13.BackColor = Color.Yellow;

            }
            if (soruno == 14)
            {
                richTextBox1.Text = "HZ isanın annesinin ismi ?";
                button14.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti ?";
                button15.BackColor = Color.Yellow;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi ?";
                button16.BackColor = Color.Yellow;

            }
            if (soruno == 17)
            {
                richTextBox1.Text = "kutuplarda yaşayan siyah beyaz hayvan ?";
                button17.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button18.BackColor = Color.Yellow;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "yumuşağın zıt anlamlısı ?";
                button19.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı ?";
                button20.BackColor = Color.Yellow;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = " ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;

            }
            if (soruno == 22)
            {
                richTextBox1.Text = "kahvaltısı ile ünlü ilimiz  ?";
                button22.BackColor = Color.Yellow;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "şimşek kelimesinin eş anlamlısı ?";
                button23.BackColor = Color.Yellow;

            }
            if (soruno == 24)
            {
                richTextBox1.Text = "ege bölgesinin en çok ağacı bulunan yağıda yapıla" +
                    "kahvaltı besini ?";
                button24.BackColor = Color.Yellow;

            }
            


        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                linkLabel1.Enabled = true;
                sayac = 0;
                switch (soruno)
                {   
                  case 1:
                  if (textBox1.Text == "ankara")
                  {
                   button1.BackColor = Color.Green;
                   dogru++;
                   label2.Text = dogru.ToString();
                            textBox1.Enabled = false;



                        }
                  else
                  {
                       button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        
                   break;
                  case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "il")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "meryem")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "penguen")

                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "sert")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        break;

                }

        }
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            button25.Text = sayac.ToString();
            if (sayac == 15)
            {
                timer1.Stop();
                button25.Text = "Süreniz bitti üzgünüm diğer soruya geçiniz ";
                textBox1.Enabled = false;
                linkLabel1.Enabled = true;
                bos++;
                label5.Text = bos.ToString();

                sayac = 0;

            }
           
       }

    }
}
