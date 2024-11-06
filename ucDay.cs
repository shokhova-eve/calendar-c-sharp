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
    public partial class ucDay : UserControl
    {
        string _day, date, weekday;

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.Chocolate;
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void ucDay_Load(object sender, EventArgs e)
        {
            sundaysHolidays();
        }

        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            label3.Text = day;
            checkBox1.Hide();
            date = _day + "/" + Form1._month + "/" + Form1._year;
        }

        private void sundaysHolidays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    //Form1.label1.ForeColor = Color.Chocolate;
                }
            }
            catch (Exception) { }
        }
    }
}
