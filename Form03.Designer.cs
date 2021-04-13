namespace Valley_Boulevard_Auto
{
    partial class Form03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form03));
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.cbPackages = new System.Windows.Forms.ComboBox();
            this.lbInterior = new System.Windows.Forms.ListBox();
            this.lblCarWashInfo = new System.Windows.Forms.Label();
            this.lbExterior = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedInteriorItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedExteriorItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedInteriorItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddExt = new System.Windows.Forms.Button();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFragrenceOptions = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.printDocumentAll = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentSelected = new System.Drawing.Printing.PrintDocument();
            this.clearSelectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(140, 375);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.Text = "Print Screen";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPackages
            // 
            this.cbPackages.FormattingEnabled = true;
            this.cbPackages.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.cbPackages.Location = new System.Drawing.Point(293, 128);
            this.cbPackages.Name = "cbPackages";
            this.cbPackages.Size = new System.Drawing.Size(121, 21);
            this.cbPackages.TabIndex = 5;
            this.cbPackages.SelectedIndexChanged += new System.EventHandler(this.cbPackages_SelectedIndexChanged);
            // 
            // lbInterior
            // 
            this.lbInterior.FormattingEnabled = true;
            this.lbInterior.Location = new System.Drawing.Point(177, 198);
            this.lbInterior.Name = "lbInterior";
            this.lbInterior.Size = new System.Drawing.Size(120, 95);
            this.lbInterior.TabIndex = 6;
            this.lbInterior.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblCarWashInfo
            // 
            this.lblCarWashInfo.AutoSize = true;
            this.lblCarWashInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarWashInfo.Location = new System.Drawing.Point(319, 53);
            this.lblCarWashInfo.Name = "lblCarWashInfo";
            this.lblCarWashInfo.Size = new System.Drawing.Size(155, 16);
            this.lblCarWashInfo.TabIndex = 7;
            this.lblCarWashInfo.Text = "Car wash Information.";
            // 
            // lbExterior
            // 
            this.lbExterior.FormattingEnabled = true;
            this.lbExterior.Location = new System.Drawing.Point(416, 198);
            this.lbExterior.Name = "lbExterior";
            this.lbExterior.Size = new System.Drawing.Size(120, 95);
            this.lbExterior.TabIndex = 8;
            this.lbExterior.SelectedIndexChanged += new System.EventHandler(this.lbExterior_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Interior: ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(339, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Interior Options: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exterior Options: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Package Choice: ";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(31, 209);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(100, 20);
            this.txtAdd1.TabIndex = 14;
            this.txtAdd1.TextChanged += new System.EventHandler(this.txtAdd1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAllToolStripMenuItem,
            this.printSelectedToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printAllToolStripMenuItem
            // 
            this.printAllToolStripMenuItem.Name = "printAllToolStripMenuItem";
            this.printAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printAllToolStripMenuItem.Text = "Print All";
            this.printAllToolStripMenuItem.Click += new System.EventHandler(this.printAllToolStripMenuItem_Click);
            // 
            // printSelectedToolStripMenuItem
            // 
            this.printSelectedToolStripMenuItem.Name = "printSelectedToolStripMenuItem";
            this.printSelectedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printSelectedToolStripMenuItem.Text = "Print Selected";
            this.printSelectedToolStripMenuItem.Click += new System.EventHandler(this.printSelectedToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeSelectedInteriorItemToolStripMenuItem,
            this.addSelectedExteriorItemToolStripMenuItem,
            this.removeSelectedInteriorItemToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.addToolStripMenuItem.Text = "Add Selected Interior Item";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeSelectedInteriorItemToolStripMenuItem
            // 
            this.removeSelectedInteriorItemToolStripMenuItem.Name = "removeSelectedInteriorItemToolStripMenuItem";
            this.removeSelectedInteriorItemToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.removeSelectedInteriorItemToolStripMenuItem.Text = "Remove Selected Interior Item";
            this.removeSelectedInteriorItemToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedInteriorItemToolStripMenuItem_Click);
            // 
            // addSelectedExteriorItemToolStripMenuItem
            // 
            this.addSelectedExteriorItemToolStripMenuItem.Name = "addSelectedExteriorItemToolStripMenuItem";
            this.addSelectedExteriorItemToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.addSelectedExteriorItemToolStripMenuItem.Text = "Add Selected Exterior Item";
            this.addSelectedExteriorItemToolStripMenuItem.Click += new System.EventHandler(this.addSelectedExteriorItemToolStripMenuItem_Click);
            // 
            // removeSelectedInteriorItemToolStripMenuItem1
            // 
            this.removeSelectedInteriorItemToolStripMenuItem1.Name = "removeSelectedInteriorItemToolStripMenuItem1";
            this.removeSelectedInteriorItemToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.removeSelectedInteriorItemToolStripMenuItem1.Text = "Remove Selected Exterior Item";
            this.removeSelectedInteriorItemToolStripMenuItem1.Click += new System.EventHandler(this.removeSelectedInteriorItemToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSelectionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnAddExt
            // 
            this.btnAddExt.Location = new System.Drawing.Point(601, 169);
            this.btnAddExt.Name = "btnAddExt";
            this.btnAddExt.Size = new System.Drawing.Size(75, 23);
            this.btnAddExt.TabIndex = 16;
            this.btnAddExt.Text = "Add Exterior: ";
            this.btnAddExt.UseVisualStyleBackColor = true;
            this.btnAddExt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(601, 209);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(100, 20);
            this.txtAdd2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fragrence Options: ";
            // 
            // cbFragrenceOptions
            // 
            this.cbFragrenceOptions.FormattingEnabled = true;
            this.cbFragrenceOptions.Items.AddRange(new object[] {
            "Hawaiian Mist",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.cbFragrenceOptions.Location = new System.Drawing.Point(293, 335);
            this.cbFragrenceOptions.Name = "cbFragrenceOptions";
            this.cbFragrenceOptions.Size = new System.Drawing.Size(121, 21);
            this.cbFragrenceOptions.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(540, 375);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // printDocumentAll
            // 
            this.printDocumentAll.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentAll_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocumentSelected
            // 
            this.printDocumentSelected.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSelected_PrintPage);
            // 
            // clearSelectionsToolStripMenuItem
            // 
            this.clearSelectionsToolStripMenuItem.Name = "clearSelectionsToolStripMenuItem";
            this.clearSelectionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearSelectionsToolStripMenuItem.Text = "Clear Selections";
            this.clearSelectionsToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionsToolStripMenuItem_Click);
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbFragrenceOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.btnAddExt);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbExterior);
            this.Controls.Add(this.lblCarWashInfo);
            this.Controls.Add(this.lbInterior);
            this.Controls.Add(this.cbPackages);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form03";
            this.Text = "CAR WASH Options";
            this.Load += new System.EventHandler(this.Form03_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.ComboBox cbPackages;
        private System.Windows.Forms.ListBox lbInterior;
        private System.Windows.Forms.Label lblCarWashInfo;
        private System.Windows.Forms.ListBox lbExterior;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAddExt;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedInteriorItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSelectedExteriorItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedInteriorItemToolStripMenuItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFragrenceOptions;
        private System.Windows.Forms.Button btnNext;
        private System.Drawing.Printing.PrintDocument printDocumentAll;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocumentSelected;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionsToolStripMenuItem;
    }
}