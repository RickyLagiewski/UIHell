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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string textOneReverse;
        public string textTwoReverse;


        public void RadioCancer()
        {
            if(radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
            if(radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioCancer();
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioCancer();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            catch
            {
                
            }
        }
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(2, true);
            textBox2.Text = "";
            checkedListBox1.SetItemChecked(1, false);
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(1, true);
            textBox1.Text = "";
            checkedListBox1.SetItemChecked(2, false);
        }
    }
}
