using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//By Blake McCullough
//https://github.com/Blake-McCullough
namespace Payroll
{
    public partial class Form2 : Form

    {
        Form2 frm2;

        //Editor will not load editing unless you temporarily deleted the public class Invoice and then retry
        public Invoice Invoice
        {
            set
            {
                //Grabs variables from first form
                //////////////////////////////////////////////////////////////
                textBox10.Text = value.EquivHours;
                textBox2.Text = value.Total_After_GST;
                textBox7.Text = value.Total;
                textBox17.Text = value.Totalhours;
                textBox4.Text = value.DoubleHours;
                textBox11.Text = value.TimeAndHalfHours;
                textBox12.Text = value.NormalHours;
                textBox16.Text = value.TimeandHalfRate;
                textBox15.Text = value.NormalRate;
                textBox1.Text = value.DoubleRate;
                textBox5.Text = value.EmployeeName;
                textBox6.Text = value.EmployerName;
                textBox3.Text = value.CompanyName;
                textBox9.Text = value.Address;
                textBox14.Text = value.Suburb;
                textBox13.Text = value.Postcode;
                textBox8.Text = value.State;
                textBox18.Text = value.Date;
                textBox19.Text = value.Tax;
                // etc
                //////////////////////////////////////////////////////////////
            }
        }
        Form1 frm1;
        public Form2()
        {

            InitializeComponent();
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Returns to original form
            //////////////////////////////////////////////////////////////
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
            //////////////////////////////////////////////////////////////
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Save document to file button initialiser
            //////////////////////////////////////////////////////////////
            //Sets document variables
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            printPreviewDialog1.Document = pd;
            //Saves the file
            pd.Print();
            //////////////////////////////////////////////////////////////


        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            //////////////////////////////////////////////////////////////
            //Sets width and height for program
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);
            //Draws for bitmap
            this.DrawToBitmap(img, bounds);
            Point p = new Point(0, 0);
            e.Graphics.DrawImage(img, p);

            //Pulls date from Date text box
            string Date = textBox18.Text;
            //Pulls name from Name text box
            String Name = textBox5.Text;

            //Converts date to string
            string DateString = Date.ToString();

            //Replaces / with - in date so can be used in file name
            DateString = DateString.Replace(@"/", "-");

            //Combined all variables into one
            string Data = DateString + "-" + Name +  ".bmp";
            //Showed what file was saved as
            MessageBox.Show("Saved as:" + Data);
            //Saves Image
            img.Save(Data);
            //////////////////////////////////////////////////////////////
        }


    }
}
