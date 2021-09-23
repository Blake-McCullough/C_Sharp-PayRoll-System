using System;
using System.Windows.Forms;
//By Blake McCullough
//https://github.com/Blake-McCullough
namespace Payroll
{
    //Editor will not load editing unless you temporarily deleted the public class Invoice and then retry
    
    public class Invoice
    {
        //String setup to share variables with other forms
        //////////////////////////////////////////////////////////////
        public string EquivHours { get; set; }
        public string Total_After_GST { get; set; }
        public string Total { get; set; }
        public string Totalhours { get; set; }
        public string DoubleHours { get; set; }
        public string TimeandHalfRate { get; set; }
        public string DoubleRate { get; set; }
        public string NormalRate { get; set; }
        public string TimeAndHalfHours { get; set; }

        public string EmployerName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public string EmployeeName { get; set; }
        public string NormalHours { get; set; }
        public string Tax { get; set; }
        //////////////////////////////////////////////////////////////


    }
    public partial class Form1 : Form
    {

            // etc
        Form2 frm2;


        public Form1()
        {


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets date time picker to correct format for variables
            //////////////////////////////////////////////////////////////
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            //////////////////////////////////////////////////////////////
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //////////////////////////////////////////////////////////////
            //Prepares the variables for later use
            Double Totalsalary = 0;
            //Hours of work at different pay variables
            Double NormalPayHours = 0;
            Double Timeandhalfhours = 0;
            Double DoublePayHours = 0;

            //Rate of pay
            Double rate = 0;
            //Equivelent hours
            Double EquivNormal = 0;
            Double EquivTimeandHalfHours = 0;
            Double EquivDoubleHours = 0;
            Double EquivHours = 0;
            //Pay rates
            Double NormalRate = 0;
            Double TimeandHalfRate = 0;
            Double DoubleRate = 0;
            //Number for Total Hours
            Double Totalhours = 0;
            //Number for Total Before GST
            Double TotalAfterGST = 0;
            Double tax_input = 0;
            Double tax = 0;

            //get text property from text boxs 
            string taxbox = textBox10.Text;
            string ratebox = textBox13.Text;
            string Normalhoursbox = textBox5.Text;
            string Timeandhalfhoursbox = textBox8.Text;
            string Doublehoursbox = textBox9.Text;
            string EmployerName = textBox6.Text;
            string CompanyName = textBox3.Text;
            string Address = textBox2.Text;
            string Suburb = textBox7.Text;
            string Postcode = textBox4.Text;
            string State = textBox11.Text;
            string EmployeeName = textBox1.Text;


            //String for Equiv Hours
            string EquivHoursString = "";
            string EquivTimeandHalfHoursString = "";
            string EquivDoubleHoursString = "";
            string EquivNormalString = "";
            //String for Total Pay
            string TotalsalaryString = "";
            //String for Total Pay Before GST
            string TotalAfterGSTString = "";
            //String for Total Hours
            string TotalhoursString = "";
            //String for pay rates
            String NormalRateString = "";
            String TimeandHalfRateString = "";
            String DoubleRateString = "";
            String NormalPayHoursString = "";
            //String for hours of Double pay
            String DoublePayHoursString = "";
            //String for hours of time and half pay
            String TimeandHalfHoursString = "";

            // covert values in text bozes from string to number 
            Double.TryParse(ratebox, out rate);
            Double.TryParse(Normalhoursbox, out NormalPayHours);
            Double.TryParse(Timeandhalfhoursbox, out Timeandhalfhours);
            Double.TryParse(Doublehoursbox, out DoublePayHours);
            Double.TryParse(taxbox, out tax_input);

            //Gets dateTimePicker value
            string dt = dateTimePicker1.Value.ToString("dd/MM/yyyy");


            //Tax calculation variables
            Double TaxCost = 0;
            String TaxCostString = "";
            //Cost before payments such as medicare variable
            Double TotalBeforePayments = 0;

            //////////////////////////////////////////////////////////////





            //Checks if casual box is ticked or not
            if (checkBox1.Checked)

            {  //////////////////////////////////////////////////////////////
                ///For Casual Workers
                //Gets equiv normal hours by times hours by rate
                EquivNormal = NormalPayHours * 1.2;

                //Gets equiv timeandhalf hours by times hours by rate times 1.5
                EquivTimeandHalfHours = Timeandhalfhours * 1.5 * 1.2;

                //Gets equiv double hours by times hours by rate times 2
                EquivDoubleHours = DoublePayHours * 2 * 1.2;

                // Calculates equivalent hours Casual workers  
                EquivHours = NormalPayHours + EquivTimeandHalfHours + EquivDoubleHours;

                //Adds all pay together for Casual workers
                Totalsalary = EquivHours * rate;

                //Works out normal rate for Casual Workers
                NormalRate = rate * 1.2;
                //Works out Time and Half rate for Casual Workers
                TimeandHalfRate = rate * 1.5 * 1.2;
                //Works out Double for Casual Workers
                DoubleRate = rate * 2 * 1.2;
                //////////////////////////////////////////////////////////////
            }
            else
            {
                //////////////////////////////////////////////////////////////
                ///for normal workers
                //Gets equiv normal hours by times hours by rate
                EquivNormal = NormalPayHours;

                //Gets equiv timeandhalf hours by times hours by rate times 1.5
                EquivTimeandHalfHours = Timeandhalfhours * 1.5;

                //Gets equiv double hours by times hours by rate times 2
                EquivDoubleHours = DoublePayHours * 2;

                // Calculates equivalent hours normal workers  
                EquivHours = EquivNormal + EquivTimeandHalfHours + EquivDoubleHours;

                //Adds all pay together for normal workers
                Totalsalary = EquivHours * rate;

                //Works out normal rate for Normal Workers
                NormalRate = rate;
                //Works out Time and Half rate for Normal Workers
                TimeandHalfRate = rate * 1.5;
                //Works out Double for Normal Workers
                DoubleRate = rate * 2;
                //////////////////////////////////////////////////////////////
            }


            //////////////////////////////////////////////////////////////
            //EQUIVALENT HOURS
            //Converts to 2 decimal places and to a string
            EquivNormalString = $"{EquivNormal:0.00}";
            //Converts to 2 decimal places and to a string
            EquivTimeandHalfHoursString = $"{EquivTimeandHalfHours:0.00}";
            //Converts to 2 decimal places and to a string
            EquivDoubleHoursString = $"{EquivDoubleHours:0.00}";
            //Converts to 2 decimal places and to a string
            TotalhoursString = $"{Totalhours:0.00}";
            //Converts to 2 decimal places and to a string
            EquivHoursString = $"{EquivHours:0.00}";
            //DoublePayHours to string
            DoublePayHoursString = $"{DoublePayHours:0.00}";
            //Time an half Hours to string
            TimeandHalfHoursString = $"{Timeandhalfhours:0.00}";

            NormalPayHoursString = $"{NormalPayHours:0.00}";



            //Converts to 2 decimal places and to a string
            TotalsalaryString = $"{Totalsalary:0.00}";
            //////////////////////////////////////////////////////////////

            //Pay RATE
            //////////////////////////////////////////////////////////////
            //Converts to 2 decimal places and to a string
            NormalRateString = $"{NormalRate:0.00}";
            //Converts to 2 decimal places and to a string
            TimeandHalfRateString = $"{TimeandHalfRate:0.00}";
            //Converts to 2 decimal places and to a string
            DoubleRateString = $"{DoubleRate:0.00}";

            //Works out total before the medicare etc payments
            //////////////////////////////////////////////////////////////
            TotalBeforePayments = Totalsalary * 0.89;

            //////////////////////////////////////////////////////////////

            //Calculates tax and payment
            //////////////////////////////////////////////////////////////
            tax = 1 - (tax_input * 0.01);
            //Total for before GST is calculated
            TotalAfterGST = TotalBeforePayments * tax;
            //Total   
            TotalAfterGSTString = $"{TotalAfterGST:0.00}";
            //////////////////////////////////////////////////////////////



            //Total hours by adding all hours
            //////////////////////////////////////////////////////////////
            Totalhours = NormalPayHours + Timeandhalfhours + DoublePayHours;

            TotalhoursString = $"{Totalhours:0.00}";
            //////////////////////////////////////////////////////////////








            //TAX CALCULATION
            //////////////////////////////////////////////////////////////
            TaxCost = TotalBeforePayments * (tax_input * 0.01);
            //TAX TO STRING
            TaxCostString = $"{TaxCost:0.00}";
            //////////////////////////////////////////////////////////////


            //Passing variables from this form to other forms
            //////////////////////////////////////////////////////////////
            frm2 = new Form2();

            Invoice invoice = new Invoice();
            invoice.EquivHours = EquivHoursString;
            invoice.Total_After_GST = TotalAfterGSTString;
            invoice.Total = TotalsalaryString;
            invoice.Totalhours = TotalhoursString;
            invoice.DoubleHours = DoublePayHoursString;
            invoice.TimeAndHalfHours = TimeandHalfHoursString;
            invoice.NormalRate = NormalRateString;
            invoice.TimeandHalfRate = TimeandHalfRateString;
            invoice.DoubleRate = DoubleRateString;
            invoice.EmployerName = EmployerName;
            invoice.CompanyName = CompanyName;
            invoice.Address = Address;
            invoice.Suburb = Suburb;
            invoice.Postcode = Postcode;
            invoice.State = State;
            invoice.NormalHours = NormalPayHoursString;

            invoice.Tax = TaxCostString;
            invoice.Date = dt;
            invoice.EmployeeName = EmployeeName;
            //invoice.
            // etc
            //////////////////////////////////////////////////////////////
           
            /////Hides this form and shows second form
            //////////////////////////////////////////////////////////////
            this.Visible = false;

            
            frm2.Invoice = invoice;
            frm2.Show();
            //////////////////////////////////////////////////////////////






        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
