using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Form3 : Form
    {
        int count = 0;
        string text1 = "Initializing...";
        string text2 = "Hello...";
        string text3 = "Lets take a look shall we?";
        string text4 = "RIT... interesting...";
        string text5 = "Staff... processing...";
        string text6 = "CounterMeasures...";
        string text7 = "FireWall...";
        string text8 = "Data Transmission Started...";
        string text9 = "This PC(C:)...";
        string text10 = "This PC(D:)...";
        string text11 = "Data Transmission Ended...";
        string text12 = "Until next time :)";
        Random rng = new Random();
        public Form3()
        {
            InitializeComponent();

            SetTimer(rng.Next(50, 150));
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.ReadOnly = true;
            SetTimer(50);
        }
        private void SetTimer(int milliseconds)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = milliseconds;
            timer1.Start();
        }
        public void timer1_Tick(Object o, EventArgs e)
        {
            if (count < text1.Length)
            {
                textBox1.Text += text1[count];
                count++;
                if (count == text1.Length - 1)
                {
                    count = 0;
                    Thread.Sleep(500);
                    textBox1.Clear();
                    textBox1.Text += text2[count];
                    count++;
                    if (count == text2.Length)
                    {
                        count = 0;
                        Thread.Sleep(500);
                        textBox1.Clear();
                        textBox1.Text += text2[count];
                        count++;
                        if (count == text3.Length)
                        {
                            count = 0;
                            Thread.Sleep(500);
                            textBox1.Clear();
                            textBox1.Text += text2[count];
                            count++;
                            if (count == text4.Length)
                            {
                                count = 0;
                                Thread.Sleep(500);
                                textBox1.Clear();
                                textBox1.Text += text2[count];
                                count++;
                                if (count == text5.Length)
                                {
                                    count = 0;
                                    Thread.Sleep(500);
                                    textBox1.Clear();
                                    textBox1.Text += text2[count];
                                    count++;
                                    if (count == text6.Length)
                                    {
                                        count = 0;
                                        Thread.Sleep(500);
                                        textBox1.Clear();
                                        textBox1.Text += text2[count];
                                        count++;
                                        if (count == text7.Length)
                                        {
                                            count = 0;
                                            Thread.Sleep(500);
                                            textBox1.Clear();
                                            textBox1.Text += text2[count];
                                            count++;
                                            if (count == text8.Length)
                                            {
                                                count = 0;
                                                Thread.Sleep(500);
                                                textBox1.Clear();
                                                textBox1.Text += text2[count];
                                                count++;
                                                if (count == text9.Length)
                                                {
                                                    count = 0;
                                                    Thread.Sleep(500);
                                                    textBox1.Clear();
                                                    textBox1.Text += text2[count];
                                                    count++;
                                                    if (count == text10.Length)
                                                    {
                                                        count = 0;
                                                        Thread.Sleep(500);
                                                        textBox1.Clear();
                                                        textBox1.Text += text2[count];
                                                        count++;
                                                        if (count == text11.Length)
                                                        {
                                                            count = 0;
                                                            Thread.Sleep(500);
                                                            textBox1.Clear();
                                                            textBox1.Text += text2[count];
                                                            count++;
                                                            if (count == text12.Length)
                                                            {
                                                                count = 0;
                                                                Thread.Sleep(500);
                                                                this.Close();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
            
                                                        //jesus thats a lot of repeating that I couldn't figure out how to shorten
    
