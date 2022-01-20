using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetaCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt0 = new DateTime(2021, 12, 21);

            DateTime dt = dateTimePicker1.Value;

            TimeSpan ts = new TimeSpan();

            while (DateTime.Compare(dt0, dt) < 0)
            {
                ts = dt - dt0;

                if (DateTime.IsLeapYear(dt0.Year - 1))
                {
                    dt0 += new TimeSpan(366, 0, 0, 0);
                }
                else
                {
                    dt0 += new TimeSpan(365, 0, 0, 0);
                }
            }

            int days = ts.Days + 1;

            int year = dt0.Year;
            int month, day;

            int i = days / 30;
            int j = days % 30;

            if (j <= i / 2)
            {
                month = i;
            }
            else
            {
                month = i + 1;
            }

            if (month == 1)
            {
                day = days;
            }
            else
            {
                day = days - (month - 1) * 30 - (month - 1) / 2;
            }

            textBox1.Text = year + "-" + month + "-" + day;
        }
    }
}
