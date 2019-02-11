using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetCompleter
{
    public partial class Form1 : Form
    {
        public static int totalHours = 40;
        public static DateTime monDate;
        public static DateTime tuesDate;
        public static DateTime wedsDate;
        public static DateTime thurDate;
        public static DateTime friDate;
        public Form1()
        {
            InitializeComponent();
            endingWeekDay.CustomFormat = "MM-dd-yyyy";
            signedDay.CustomFormat = "MM-dd-yyyy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotalHours.Text = totalHours.ToString();
            lblDaySigned.Text = signedDay.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                totalHours = change;
                lblTotalHours.Text = totalHours.ToString();
            }
            catch
            {
                lblTotalHours.Text = "Missing Hours!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                totalHours = change;
                lblTotalHours.Text = totalHours.ToString();
            }
            catch
            {
                lblTotalHours.Text = "Missing Hours!";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                totalHours = change;
                lblTotalHours.Text = totalHours.ToString();
            }
            catch
            {
                lblTotalHours.Text = "Missing Hours!";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                totalHours = change;
                lblTotalHours.Text = totalHours.ToString();
            }
            catch
            {
                lblTotalHours.Text = "Missing Hours!";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text);
                totalHours = change;
                lblTotalHours.Text = totalHours.ToString();
            }
            catch
            {
                lblTotalHours.Text = "Missing Hours!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monDate = endingWeekDay.Value.AddDays(-4);
            tuesDate = endingWeekDay.Value.AddDays(-3);
            wedsDate = endingWeekDay.Value.AddDays(-2);
            thurDate = endingWeekDay.Value.AddDays(-1);
            friDate = endingWeekDay.Value;
            OpenFileDialog fileDiag = new OpenFileDialog();
            fileDiag.Filter = "PDF Files | *.pdf";
            fileDiag.ShowDialog();
            PdfProcessor.GenerateAndSavePDF(fileDiag.FileName,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,endingWeekDay.Text,signedDay.Text);
            MessageBox.Show("Your timesheet has been saved!");
        }

        private void endingWeekDay_ValueChanged(object sender, EventArgs e)
        {
            lblWeekEndingDay.Text = endingWeekDay.Text;
        }

        private void signedDay_ValueChanged(object sender, EventArgs e)
        {
            lblDaySigned.Text = signedDay.Text;
        }
    }
}
