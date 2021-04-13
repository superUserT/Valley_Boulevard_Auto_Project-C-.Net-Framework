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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Valley_Boulevard_Auto;

namespace ValleyBoulevardAutoCenter
{
    public partial class VBAutoCenter : Form
    {

        double stereoSystem = 425.76;
        double leatherInterior = 987.41;
        double computerNavigation = 1741.23;


        double standard = 0.0;
        double pearlized = 345.72;
        double customDetailing = 599.99;

        double tax;
        double taxRate = 0.08;

        double accessories;
        double interiorFinish;

        double subtotalfortxt2;

        double subtotal;
        double carsalesprice;
        double tradeinAllowance;
        double total;

        double amountDue;




        public VBAutoCenter()
        {
            InitializeComponent();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            //shows exit options
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            else
                this.Activate();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!this.IsValidData())
                    return;


                //accesories code
                if (cbStereoFinish.Checked && cbLeatherFinish.Checked && cbComputerNavigation.Checked)
                {
                    accessories = stereoSystem + leatherInterior + computerNavigation;
                }

                else if (cbStereoFinish.Checked && cbLeatherFinish.Checked)
                {
                    accessories = stereoSystem + leatherInterior;
                }

                else if (cbStereoFinish.Checked)
                {
                    accessories = stereoSystem;
                }

                else if (cbLeatherFinish.Checked)
                {
                    accessories = leatherInterior;
                }

                else if (cbComputerNavigation.Checked)
                {
                    accessories = computerNavigation;
                }


                //Interior Finish code
                if (rbStandard.Checked)
                {
                    interiorFinish = standard;
                }
                else if (rbPearlised.Checked)
                {
                    interiorFinish = pearlized;
                }
                else if (rbCustomDetailing.Checked)
                {
                    interiorFinish = customDetailing;
                }



                //Logic for calculations
                subtotalfortxt2 = interiorFinish + accessories;

                subtotal = subtotalfortxt2 + carsalesprice;

                tax = subtotal * taxRate;

                total = tax + subtotal;

                amountDue = total - tradeinAllowance;



                //inputs
                carsalesprice = Convert.ToDouble(txtSalesPrice.Text);
                tradeinAllowance = Convert.ToDouble(txtTradeInAllowance.Text);


                //Outputs
                txtAccessoriesFinish.Text = Convert.ToString(subtotalfortxt2);

                txtSubtotal.Text = Convert.ToString(subtotal);

                txtSalesTax.Text = Convert.ToString(tax);

                txtTotal.Text = Convert.ToString(total);

                txtAmountDue.Text = Convert.ToString(amountDue);




            }
            //Checks of all trypes of ecxeptions in Code above.
            catch (Exception ex)
            {
                int numb2 = (int)MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }


        }
        //Checks types
        public bool IsDecimal(TextBox textBox, string name)
        {
            
            Decimal result = new Decimal();
            if (Decimal.TryParse(textBox.Text, out result))
                return true;
            int num = (int)MessageBox.Show(name + "Number entered must be a decimal number.", "Entry Error");
            textBox.Focus();
            return false;
        }

        //Checks if data is entered
        public bool IsPresent(TextBox textBox, string name)
        {
            if (!(textBox.Text == ""))
                return true;
            int num = (int)MessageBox.Show(name + "Data entered here is required.", "Entry Error");
            textBox.Focus();
            return false;
        }
        //validates all the above
        public bool IsValidData()
        {
            return this.IsPresent(this.txtSalesPrice, "Enter Car Sales Price.")
                && this.IsDecimal(this.txtSalesPrice, "Enter Correct data type. Car Sales Price.")
                &&

              this.IsPresent(this.txtTradeInAllowance, "Enter Car Trade in Allowance, if none enter 0.")
                && this.IsDecimal(this.txtTradeInAllowance, "Enter Correct data type, Trade in Allowance.");

        }

        private void lblAccessoriesAndFinish_Click(object sender, EventArgs e)
        {

        }

        private void txtAccessoriesFinish_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears these texboxes and stuff.
            txtSalesPrice.Text = "";
            txtAccessoriesFinish.Text = "";
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtTotal.Text = "";
            txtTradeInAllowance.Text = "";
            txtAmountDue.Text = "";

            if (cbStereoFinish.Checked == true || cbLeatherFinish.Checked == true || cbComputerNavigation.Checked == true)
            {
                cbStereoFinish.Checked = false;
                cbLeatherFinish.Checked = false;
                cbComputerNavigation.Checked = false;
            }

            if (rbCustomDetailing.Checked == true || rbPearlised.Checked == true || rbStandard.Checked == true)
            {
                rbCustomDetailing.Checked = false;
                rbPearlised.Checked = false;
                rbStandard.Checked = false;
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            // Create document
            PrintDocument _document = new PrintDocument();
            // Add print handler
            _document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            // Create the dialog to display results
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width / 2, Height / 2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            // Setting up our document
            _dlg.Document = _document;
            // Show it
            _dlg.ShowDialog(this);
            // Dispose document
            _document.Dispose();




        }

        // Print handler
        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create Bitmap according form size
            Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            // Draw from into Bitmap DC
            this.DrawToBitmap(_bitmap, this.DisplayRectangle);
            // Draw Bitmap into Printer DC
            e.Graphics.DrawImage(_bitmap, 0, 0);
            // No longer deeded - dispose it
            _bitmap.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //goes to third page
            this.Hide();
            Form03 f3 = new Form03();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //goes to first page
            this.Hide();
            Form01 f1 = new Form01();
            f1.ShowDialog();
            this.Close();
        }
    }
}
