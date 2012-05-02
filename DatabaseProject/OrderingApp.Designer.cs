namespace DatabaseProject
{
    partial class OrderingApp
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
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.OrderInfo = new System.Windows.Forms.GroupBox();
            this.textBoxOrderItemQuan = new System.Windows.Forms.TextBox();
            this.labelItemQuan = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelItemID = new System.Windows.Forms.Label();
            this.textBoxOrderItemID = new System.Windows.Forms.TextBox();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.textBoxVendorID = new System.Windows.Forms.TextBox();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.OrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(35, 12);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(133, 37);
            this.buttonQuery.TabIndex = 0;
            this.buttonQuery.Text = "Query Order Info";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(35, 96);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(133, 37);
            this.buttonPlace.TabIndex = 1;
            this.buttonPlace.Text = "Place New Order";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(35, 168);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(133, 37);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Change Existing Order";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(35, 238);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 37);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete an order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(35, 305);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(133, 37);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Return to main menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // OrderInfo
            // 
            this.OrderInfo.Controls.Add(this.textBoxOrderItemQuan);
            this.OrderInfo.Controls.Add(this.labelItemQuan);
            this.OrderInfo.Controls.Add(this.buttonCancel);
            this.OrderInfo.Controls.Add(this.buttonApply);
            this.OrderInfo.Controls.Add(this.labelItemID);
            this.OrderInfo.Controls.Add(this.textBoxOrderItemID);
            this.OrderInfo.Controls.Add(this.textBoxOrderDate);
            this.OrderInfo.Controls.Add(this.labelOrderDate);
            this.OrderInfo.Controls.Add(this.textBoxVendorID);
            this.OrderInfo.Controls.Add(this.textBoxOrderID);
            this.OrderInfo.Controls.Add(this.labelVendorID);
            this.OrderInfo.Controls.Add(this.labelOrderID);
            this.OrderInfo.Location = new System.Drawing.Point(241, 12);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.Size = new System.Drawing.Size(345, 330);
            this.OrderInfo.TabIndex = 6;
            this.OrderInfo.TabStop = false;
            this.OrderInfo.Text = "Order Information";
            this.OrderInfo.Enter += new System.EventHandler(this.OrderInfo_Enter);
            // 
            // textBoxOrderItemQuan
            // 
            this.textBoxOrderItemQuan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOrderItemQuan.Location = new System.Drawing.Point(158, 235);
            this.textBoxOrderItemQuan.Name = "textBoxOrderItemQuan";
            this.textBoxOrderItemQuan.Size = new System.Drawing.Size(100, 21);
            this.textBoxOrderItemQuan.TabIndex = 11;
            // 
            // labelItemQuan
            // 
            this.labelItemQuan.AutoSize = true;
            this.labelItemQuan.Location = new System.Drawing.Point(55, 238);
            this.labelItemQuan.Name = "labelItemQuan";
            this.labelItemQuan.Size = new System.Drawing.Size(83, 12);
            this.labelItemQuan.TabIndex = 10;
            this.labelItemQuan.Text = "Item Quantity";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(42, 279);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(55, 185);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(47, 12);
            this.labelItemID.TabIndex = 7;
            this.labelItemID.Text = "Item ID";
            // 
            // textBoxOrderItemID
            // 
            this.textBoxOrderItemID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOrderItemID.Location = new System.Drawing.Point(158, 182);
            this.textBoxOrderItemID.Name = "textBoxOrderItemID";
            this.textBoxOrderItemID.Size = new System.Drawing.Size(100, 21);
            this.textBoxOrderItemID.TabIndex = 6;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(158, 129);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.Size = new System.Drawing.Size(100, 21);
            this.textBoxOrderDate.TabIndex = 5;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(55, 132);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(65, 12);
            this.labelOrderDate.TabIndex = 4;
            this.labelOrderDate.Text = "Order Date";
            // 
            // textBoxVendorID
            // 
            this.textBoxVendorID.Location = new System.Drawing.Point(158, 76);
            this.textBoxVendorID.Name = "textBoxVendorID";
            this.textBoxVendorID.Size = new System.Drawing.Size(100, 21);
            this.textBoxVendorID.TabIndex = 3;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(158, 23);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 21);
            this.textBoxOrderID.TabIndex = 2;
            this.textBoxOrderID.TextChanged += new System.EventHandler(this.textBoxOrderID_TextChanged);
            // 
            // labelVendorID
            // 
            this.labelVendorID.AutoSize = true;
            this.labelVendorID.Location = new System.Drawing.Point(55, 79);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(59, 12);
            this.labelVendorID.TabIndex = 1;
            this.labelVendorID.Text = "Vendor ID";
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(55, 26);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(53, 12);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID";
            // 
            // OrderingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 366);
            this.Controls.Add(this.OrderInfo);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.buttonQuery);
            this.Name = "OrderingApp";
            this.Text = "Ordering Application";
            this.Load += new System.EventHandler(this.OrderingApp_Load_1);
            this.OrderInfo.ResumeLayout(false);
            this.OrderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox OrderInfo;
        private System.Windows.Forms.TextBox textBoxOrderItemQuan;
        private System.Windows.Forms.Label labelItemQuan;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.TextBox textBoxOrderItemID;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxVendorID;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.Label labelOrderID;
    }
}