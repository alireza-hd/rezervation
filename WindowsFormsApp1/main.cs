using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Class;


namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        MaftooxCalendar.MaftooxPersianCalendar.TimeWork prdtime = new MaftooxCalendar.MaftooxPersianCalendar.TimeWork();
        private MaftooxCalendar.MaftooxPersianCalendar.DateWork prd= new MaftooxCalendar.MaftooxPersianCalendar.DateWork();

        private void main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            circularProgressBar1.Text = dt.Hour.ToString("00") + ":" + dt.Minute.ToString("00");
            label1.Text = dt.Second.ToString("00");
            circularProgressBar1.Value = dt.Second;
            prdtime.Upate();
            string stry = prd.GetNameMonth() + prd.GetNameDayInMonth();
            label2.Text = prd.GetNameDayInMonth();

            label3.Text = prd.GetNumberDayInMonth().ToString() + "" + prd.GetNameMonth() + "" + prd.GetNumberYear();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
