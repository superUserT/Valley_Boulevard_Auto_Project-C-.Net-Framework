using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValleyBoulevardAutoCenter;

namespace Valley_Boulevard_Auto
{
    public partial class Form03 : Form
    {
        public Form03()
        {
            InitializeComponent();
        }

        private void Form03_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prints items selected items in arrays: interior
            string result = "";
            foreach (string sports in this.lbInterior.SelectedItems)
                result = result + sports + "\n";

            this.txtAdd1.Text = result;

          


        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit options
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            else
                this.Activate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbExterior_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = "";
            foreach (string sports in this.lbInterior.SelectedItems)
                result = result + sports + "\n";

            this.txtAdd2.Text = result;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit options
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            else
                this.Activate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //goes to previous page
            this.Hide();
            VBAutoCenter f2 = new VBAutoCenter();
            f2.ShowDialog();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hyperlink to google
            Process.Start("http://www.Google.com");
        }
       


        private void cbPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1d arrays for differenct selected items
            if (this.cbPackages.SelectedItem.ToString() == "Standard")
            {
                this.lbInterior.Items.Clear();
                this.lbInterior.Items.AddRange(new object[]
                    {
                        "Fragrence"
                    });

                this.lbExterior.Items.Clear();
                this.lbExterior.Items.AddRange(new object[]
                    {
                        "Hand Wash"
                    });

            }

            else if (this.cbPackages.SelectedItem.ToString() == "Deluxe")
            {
                this.lbInterior.Items.Clear();
                this.lbInterior.Items.AddRange(new object[]
                    {
                        "Fragrence", "Shampoo Carpets"
                    });

                this.lbExterior.Items.Clear();
                this.lbExterior.Items.AddRange(new object[]
                    {
                        "Hand Wash", "Hand Wax",
                    });
            }

            else if (this.cbPackages.SelectedItem.ToString() == "Executive")
            {
                this.lbInterior.Items.Clear();
                this.lbInterior.Items.AddRange(new object[]
                    {
                        "Fragrence", "Shampoo Carpets", "Interior Protection Coat"
                    });

                this.lbExterior.Items.Clear();
                this.lbExterior.Items.AddRange(new object[]
                    {
                        "Hand Wash", "Hand Wax","Check Engine Fluids"
                    });
            }

            else if (this.cbPackages.SelectedItem.ToString() == "Luxury")
            {
                this.lbInterior.Items.Clear();
                this.lbInterior.Items.AddRange(new object[]
                    {
                        "Fragrence", "Shampoo Carpets", "Interior Protection Coat","Shampoo Upholstry","Scotchgard"
                    });

                this.lbExterior.Items.Clear();
                this.lbExterior.Items.AddRange(new object[]
                    {
                        "Hand Wash", "Hand Wax","Check Engine Fluids", "Detail Engine Compartment","Detail Undercarriage"
                    });
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //goes to forth page
            this.Hide();
            Form04 f4 = new Form04();
            f4.ShowDialog();
            this.Close();
        }

        private void printDocumentAll_PrintPage(object sender, PrintPageEventArgs e)
        {
            //printing logic
            Font PrintFont = new System.Drawing.Font("Arial", 12);
            Single LineHeightSingle = PrintFont.GetHeight() + 2;
            Single HorizontalPrintLocationSingle = e.MarginBounds.Left;
            Single VerticalPrintLocationSingle = e.MarginBounds.Top;

            string PrintLineString = "";
            e.Graphics.DrawString(PrintLineString, Font, Brushes.Black,
                HorizontalPrintLocationSingle, VerticalPrintLocationSingle);

            using (Font HeadingFont = new Font("Arial", 14, FontStyle.Bold))
            {

                PrintLineString = "Car Wash Information \n";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

                PrintLineString = "by: Thabiso Rantsho";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

            }

            VerticalPrintLocationSingle += LineHeightSingle * 2;

            using (Font subHeadingFont = new Font("Arial", 12, FontStyle.Bold))
            {
                PrintLineString = cbPackages.SelectedItem.ToString() + " Packages";
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            
           

           //for fragrence
            using (Font subHeadingFont = new Font("Arial", 12, FontStyle.Bold))
            {
                PrintLineString = cbFragrenceOptions.SelectedItem.ToString() + "Fragrences";
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            VerticalPrintLocationSingle += LineHeightSingle;

            foreach (string InteriorItem in lbInterior.Items)
            {
                PrintLineString = InteriorItem;
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            foreach (string ExteriorItem in lbExterior.Items)
            {
                PrintLineString = ExteriorItem;
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

        }

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocumentSelected;

            printPreviewDialog1.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbInterior.Items.Add(txtAdd1.Text);
            txtAdd1.Clear();


            //Here
            if (this.cbPackages.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(this.txtAdd1.Text))
                {
                    int num1 = (int)MessageBox.Show("Package name can not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                    this.lbInterior.Items.Add((object)this.txtAdd1.Text);

            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a Package", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.txtAdd1.Clear();


            //Here
            if (this.cbPackages.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(this.txtAdd2.Text))
                {
                    int num1 = (int)MessageBox.Show("Package name can not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                    this.lbExterior.Items.Add((object)this.txtAdd2.Text);

            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a Package", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.txtAdd2.Clear();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //shows preview
            PrintDialog printDialog1 = new PrintDialog();
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocumentAll.Print();
            }
        }

        private void printDocumentSelected_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font PrintFont = new System.Drawing.Font("Arial", 12);
            Single LineHeightSingle = PrintFont.GetHeight() + 2;
            Single HorizontalPrintLocationSingle = e.MarginBounds.Left;
            Single VerticalPrintLocationSingle = e.MarginBounds.Top;

            string PrintLineString = "";
            e.Graphics.DrawString(PrintLineString, Font, Brushes.Black,
                HorizontalPrintLocationSingle, VerticalPrintLocationSingle);

            using (Font HeadingFont = new Font("Arial", 14, FontStyle.Bold))
            {

                PrintLineString = "Car Wash Information \n";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

                PrintLineString = "by: Thabiso Rantsho";
                e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;

            }

            VerticalPrintLocationSingle += LineHeightSingle * 2;

            using (Font subHeadingFont = new Font("Arial", 12, FontStyle.Bold))
            {
                PrintLineString = cbPackages.SelectedItem.ToString() + " Packages";
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }
            //Fragrences Need to fix
            using (Font subHeadingFont = new Font("Arial", 12, FontStyle.Bold))
            {
                PrintLineString = cbFragrenceOptions.SelectedItem.ToString() + "Fragrences";
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            VerticalPrintLocationSingle += LineHeightSingle;

            foreach (string InteriorItem in lbInterior.Items)
            {
                PrintLineString = InteriorItem;
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }

            foreach (string ExteriorItem in lbExterior.Items)
            {
                PrintLineString = ExteriorItem;
                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black,
                    HorizontalPrintLocationSingle, VerticalPrintLocationSingle);
                VerticalPrintLocationSingle += LineHeightSingle;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form04 f4 = new Form04();
            f4.ShowDialog();
            this.Close();
        }

        private void clearSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clears listboxes and textboxes
            lbExterior.Items.Clear();
            lbInterior.Items.Clear();
            txtAdd1.Text = "";
            txtAdd2.Text = "";
        }

        private void txtAdd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSelectedExteriorItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //adds to items listboxes
            lbExterior.Items.Add(txtAdd2.Text);
            txtAdd2.Clear();
        }

        private void removeSelectedInteriorItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbInterior.Items.Remove(lbInterior.Text);

            //validates selection for deleting
            if (MessageBox.Show("Are you sure you want to delete " + this.lbInterior.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            this.lbInterior.Items.Remove((object)this.lbInterior.Text);
        }

        private void removeSelectedInteriorItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbExterior.Items.Remove(lbExterior.Text);

            if (MessageBox.Show("Are you sure you want to delete " + this.lbExterior.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            this.lbExterior.Items.Remove((object)this.lbExterior.Text);
        }


        

       

       

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.cbPackages.SelectedIndex != -1)
            {
                this.printPreviewDialog1.Document = this.printDocumentAll;
                int num = (int)this.printPreviewDialog1.ShowDialog();
                if (MessageBox.Show("Do you want to to print from printer attached to your computer?", "Printer Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                if (new PrintDialog()
                {
                    Document = this.printDocumentAll
                }.ShowDialog() == DialogResult.OK)
                    this.printDocumentAll.Print();
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select a Package", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
