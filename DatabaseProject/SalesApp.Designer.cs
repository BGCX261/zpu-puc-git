namespace DatabaseProject
{
    partial class SalesApp
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
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonSaleReport = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBoxSellItem = new System.Windows.Forms.GroupBox();
            this.textBoxVendorID = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.labelItemQuantity = new System.Windows.Forms.Label();
            this.labelItemID = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxSid = new System.Windows.Forms.TextBox();
            this.textBoxCid = new System.Windows.Forms.TextBox();
            this.labelSid = new System.Windows.Forms.Label();
            this.labelCid = new System.Windows.Forms.Label();
            this.textBoxEid = new System.Windows.Forms.TextBox();
            this.labelEid = new System.Windows.Forms.Label();
            this.groupBoxSellItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(31, 42);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(133, 37);
            this.buttonSell.TabIndex = 0;
            this.buttonSell.Text = "Sell Item(s)";
            this.buttonSell.UseVisualStyleBackColor = true;
            // 
            // buttonSaleReport
            // 
            this.buttonSaleReport.Location = new System.Drawing.Point(31, 140);
            this.buttonSaleReport.Name = "buttonSaleReport";
            this.buttonSaleReport.Size = new System.Drawing.Size(133, 37);
            this.buttonSaleReport.TabIndex = 1;
            this.buttonSaleReport.Text = "Sales Reports";
            this.buttonSaleReport.UseVisualStyleBackColor = true;
            this.buttonSaleReport.Click += new System.EventHandler(this.buttonSaleReport_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(31, 240);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(133, 37);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return to main menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // groupBoxSellItem
            // 
            this.groupBoxSellItem.Controls.Add(this.textBoxVendorID);
            this.groupBoxSellItem.Controls.Add(this.labelVendorID);
            this.groupBoxSellItem.Controls.Add(this.textBoxItemQuantity);
            this.groupBoxSellItem.Controls.Add(this.textBoxItemID);
            this.groupBoxSellItem.Controls.Add(this.labelItemQuantity);
            this.groupBoxSellItem.Controls.Add(this.labelItemID);
            this.groupBoxSellItem.Controls.Add(this.buttonApply);
            this.groupBoxSellItem.Controls.Add(this.textBoxSid);
            this.groupBoxSellItem.Controls.Add(this.textBoxCid);
            this.groupBoxSellItem.Controls.Add(this.labelSid);
            this.groupBoxSellItem.Controls.Add(this.labelCid);
            this.groupBoxSellItem.Controls.Add(this.textBoxEid);
            this.groupBoxSellItem.Controls.Add(this.labelEid);
            this.groupBoxSellItem.Location = new System.Drawing.Point(202, 12);
            this.groupBoxSellItem.Name = "groupBoxSellItem";
            this.groupBoxSellItem.Size = new System.Drawing.Size(353, 335);
            this.groupBoxSellItem.TabIndex = 4;
            this.groupBoxSellItem.TabStop = false;
            this.groupBoxSellItem.Text = "Sell Item";
            // 
            // textBoxVendorID
            // 
            this.textBoxVendorID.Location = new System.Drawing.Point(216, 251);
            this.textBoxVendorID.Name = "textBoxVendorID";
            this.textBoxVendorID.Size = new System.Drawing.Size(100, 21);
            this.textBoxVendorID.TabIndex = 12;
            // 
            // labelVendorID
            // 
            this.labelVendorID.AutoSize = true;
            this.labelVendorID.Location = new System.Drawing.Point(59, 253);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(59, 12);
            this.labelVendorID.TabIndex = 11;
            this.labelVendorID.Text = "Vendor ID";
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Location = new System.Drawing.Point(216, 206);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(100, 21);
            this.textBoxItemQuantity.TabIndex = 10;
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Location = new System.Drawing.Point(216, 71);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(100, 21);
            this.textBoxItemID.TabIndex = 9;
            // 
            // labelItemQuantity
            // 
            this.labelItemQuantity.AutoSize = true;
            this.labelItemQuantity.Location = new System.Drawing.Point(59, 208);
            this.labelItemQuantity.Name = "labelItemQuantity";
            this.labelItemQuantity.Size = new System.Drawing.Size(83, 12);
            this.labelItemQuantity.TabIndex = 8;
            this.labelItemQuantity.Text = "Item Quantity";
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(59, 73);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(47, 12);
            this.labelItemID.TabIndex = 7;
            this.labelItemID.Text = "Item ID";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(139, 287);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Sell";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxSid
            // 
            this.textBoxSid.Location = new System.Drawing.Point(216, 26);
            this.textBoxSid.Name = "textBoxSid";
            this.textBoxSid.Size = new System.Drawing.Size(100, 21);
            this.textBoxSid.TabIndex = 5;
            // 
            // textBoxCid
            // 
            this.textBoxCid.Location = new System.Drawing.Point(216, 161);
            this.textBoxCid.Name = "textBoxCid";
            this.textBoxCid.Size = new System.Drawing.Size(100, 21);
            this.textBoxCid.TabIndex = 4;
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Location = new System.Drawing.Point(59, 28);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(47, 12);
            this.labelSid.TabIndex = 3;
            this.labelSid.Text = "Sale ID";
            // 
            // labelCid
            // 
            this.labelCid.AutoSize = true;
            this.labelCid.Location = new System.Drawing.Point(59, 163);
            this.labelCid.Name = "labelCid";
            this.labelCid.Size = new System.Drawing.Size(71, 12);
            this.labelCid.TabIndex = 2;
            this.labelCid.Text = "Customer ID";
            // 
            // textBoxEid
            // 
            this.textBoxEid.Location = new System.Drawing.Point(216, 116);
            this.textBoxEid.Name = "textBoxEid";
            this.textBoxEid.Size = new System.Drawing.Size(100, 21);
            this.textBoxEid.TabIndex = 1;
            // 
            // labelEid
            // 
            this.labelEid.AutoSize = true;
            this.labelEid.Location = new System.Drawing.Point(59, 118);
            this.labelEid.Name = "labelEid";
            this.labelEid.Size = new System.Drawing.Size(71, 12);
            this.labelEid.TabIndex = 0;
            this.labelEid.Text = "Employee ID";
            // 
            // SalesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 351);
            this.Controls.Add(this.groupBoxSellItem);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSaleReport);
            this.Controls.Add(this.buttonSell);
            this.Name = "SalesApp";
            this.Text = "Sales Application";
            this.groupBoxSellItem.ResumeLayout(false);
            this.groupBoxSellItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonSaleReport;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBoxSellItem;
        private System.Windows.Forms.TextBox textBoxVendorID;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label labelItemQuantity;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxSid;
        private System.Windows.Forms.TextBox textBoxCid;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.Label labelCid;
        private System.Windows.Forms.TextBox textBoxEid;
        private System.Windows.Forms.Label labelEid;
    }
}