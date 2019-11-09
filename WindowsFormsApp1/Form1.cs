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
        bool flag;
        database db;
        public Form1()
        {
            InitializeComponent();
            db = new database();
            flag = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                button1.Enabled = false;
            else
                button1.Enabled = true;



             

            bool flag1 =db.search(textBox1.Text, textBox2.Text);
            if (flag1)
            {

                MessageBox.Show("welcome");
                flag = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("access denied");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Button1_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                Application.Exit();
                
            }
        }
    }
}
