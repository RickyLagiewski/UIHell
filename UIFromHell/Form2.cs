using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Form2_KeyPress);
        }
        

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Meme Rank: God";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Blood Level: More red then usual";
            this.BackColor = Color.Red;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBox3.Text = "Hair: None";
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBox4.Text = "Eyes: Round";
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            textBox5.Text = "Height: Tallish";
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            textBox6.Text = "Weight: Little thick";
        }

        private void textBox11_MouseEnter(object sender, EventArgs e)
        {
            textBox11.Text = "Taxes: 112%";
        }

        private void textBox10_MouseEnter(object sender, EventArgs e)
        {
            textBox10.Text = "Income: $69,000";
        }

        private void textBox9_MouseEnter(object sender, EventArgs e)
        {
            textBox9.Text = "Car: wheelchair with rocket thrust";
        }

        private void textBox8_MouseEnter(object sender, EventArgs e)
        {
            textBox8.Text = "House: A pineapple";
        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            textBox7.Text = "Muscle: Buff";
        }
        private bool firsttime = true;

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (firsttime)
            {
                textBox12.Clear();
                firsttime = false;
            }
            if(textBox12.Text == "form3")
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
        }
        void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
        }
    }
}
