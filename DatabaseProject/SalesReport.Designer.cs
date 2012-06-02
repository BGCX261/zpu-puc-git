namespace DatabaseProject
{
    partial class SalesReport
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
            this.buttonTitem = new System.Windows.Forms.Button();
            this.buttonTcustomer = new System.Windows.Forms.Button();
            this.buttonTvendor = new System.Windows.Forms.Button();
            this.buttonTsubject = new System.Windows.Forms.Button();
            this.buttonTtitle = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBoxSaleReport = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxVendorID = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.labelItemID = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxSaleReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTitem
            // 
            this.buttonTitem.Location = new System.Drawing.Point(29, 21);
            this.buttonTitem.Name = "buttonTitem";
            this.buttonTitem.Size = new System.Drawing.Size(133, 37);
            this.buttonTitem.TabIndex = 1;
            this.buttonTitem.Text = "Total Sales  by Item";
            this.buttonTitem.UseVisualStyleBackColor = true;
            this.buttonTitem.Click += new System.EventHandler(this.buttonTitem_Click);
            // 
            // buttonTcustomer
            // 
            this.buttonTcustomer.Location = new System.Drawing.Point(29, 83);
            this.buttonTcustomer.Name = "buttonTcustomer";
            this.buttonTcustomer.Size = new System.Drawing.Size(133, 37);
            this.buttonTcustomer.TabIndex = 2;
            this.buttonTcustomer.Text = "Total Sales sorted by Customer";
            this.buttonTcustomer.UseVisualStyleBackColor = true;
            this.buttonTcustomer.Click += new System.EventHandler(this.buttonTcustomer_Click);
            // 
            // buttonTvendor
            // 
            this.buttonTvendor.Location = new System.Drawing.Point(29, 145);
            this.buttonTvendor.Name = "buttonTvendor";
            this.buttonTvendor.Size = new System.Drawing.Size(133, 37);
            this.buttonTvendor.TabIndex = 3;
            this.buttonTvendor.Text = "Total Sales sorted by Vendor";
            this.buttonTvendor.UseVisualStyleBackColor = true;
            this.buttonTvendor.Click += new System.EventHandler(this.buttonTvendor_Click);
            // 
            // buttonTsubject
            // 
            this.buttonTsubject.Location = new System.Drawing.Point(29, 208);
            this.buttonTsubject.Name = "buttonTsubject";
            this.buttonTsubject.Size = new System.Drawing.Size(133, 37);
            this.buttonTsubject.TabIndex = 4;
            this.buttonTsubject.Text = "Total Sales sorted by Subject";
            this.buttonTsubject.UseVisualStyleBackColor = true;
            // 
            // buttonTtitle
            // 
            this.buttonTtitle.Location = new System.Drawing.Point(29, 270);
            this.buttonTtitle.Name = "buttonTtitle";
            this.buttonTtitle.Size = new System.Drawing.Size(133, 37);
            this.buttonTtitle.TabIndex = 5;
            this.buttonTtitle.Text = "Total Sales -Top n Titles";
            this.buttonTtitle.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(29, 335);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(133, 37);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Return to Sell Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // groupBoxSaleReport
            // 
            this.groupBoxSaleReport.Controls.Add(this.textBoxCustomerID);
            this.groupBoxSaleReport.Controls.Add(this.textBoxVendorID);
            this.groupBoxSaleReport.Controls.Add(this.labelVendorID);
            this.groupBoxSaleReport.Controls.Add(this.labelCustomerID);
            this.groupBoxSaleReport.Controls.Add(this.textBoxItemID);
            this.groupBoxSaleReport.Controls.Add(this.labelItemID);
            this.groupBoxSaleReport.Controls.Add(this.buttonSubmit);
            this.groupBoxSaleReport.Location = new System.Drawing.Point(208, 21);
            this.groupBoxSaleReport.Name = "groupBoxSaleReport";
            this.groupBoxSaleReport.Size = new System.Drawing.Size(315, 351);
            this.groupBoxSaleReport.TabIndex = 8;
            this.groupBoxSaleReport.TabStop = false;
            this.groupBoxSaleReport.Text = "Sale Reports";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(161, 114);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerID.TabIndex = 13;
            // 
            // textBoxVendorID
            // 
            this.textBoxVendorID.Location = new System.Drawing.Point(161, 197);
            this.textBoxVendorID.Name = "textBoxVendorID";
            this.textBoxVendorID.Size = new System.Drawing.Size(100, 21);
            this.textBoxVendorID.TabIndex = 12;
            // 
            // labelVendorID
            // 
            this.labelVendorID.AutoSize = true;
            this.labelVendorID.Location = new System.Drawing.Point(35, 202);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(59, 12);
            this.labelVendorID.TabIndex = 11;
            this.labelVendorID.Text = "Vendor ID";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(35, 120);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(71, 12);
            this.labelCustomerID.TabIndex = 10;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Location = new System.Drawing.Point(161, 31);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(100, 21);
            this.textBoxItemID.TabIndex = 9;
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(35, 38);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(47, 12);
            this.labelItemID.TabIndex = 7;
            this.labelItemID.Text = "Item ID";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(117, 278);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 387);
            this.Controls.Add(this.groupBoxSaleReport);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonTtitle);
            this.Controls.Add(this.buttonTsubject);
            this.Controls.Add(this.buttonTvendor);
            this.Controls.Add(this.buttonTcustomer);
            this.Controls.Add(this.buttonTitem);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.groupBoxSaleReport.ResumeLayout(false);
            this.groupBoxSaleReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTitem;
        private System.Windows.Forms.Button buttonTcustomer;
        private System.Windows.Forms.Button buttonTvendor;
        private System.Windows.Forms.Button buttonTsubject;
        private System.Windows.Forms.Button buttonTtitle;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBoxSaleReport;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxVendorID;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.Button buttonSubmit;
    }
}