namespace DatabaseProject
{
    partial class AdminApp
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
            this.buttonCInfo = new System.Windows.Forms.Button();
            this.buttonPInfo = new System.Windows.Forms.Button();
            this.buttonEinfo = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.AdminInfo = new System.Windows.Forms.GroupBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.AdminInfoID = new System.Windows.Forms.Label();
            this.AdminInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCInfo
            // 
            this.buttonCInfo.Location = new System.Drawing.Point(36, 30);
            this.buttonCInfo.Name = "buttonCInfo";
            this.buttonCInfo.Size = new System.Drawing.Size(133, 37);
            this.buttonCInfo.TabIndex = 0;
            this.buttonCInfo.Text = "Customer Information";
            this.buttonCInfo.UseVisualStyleBackColor = true;
            this.buttonCInfo.Click += new System.EventHandler(this.buttonCInfo_Click);
            // 
            // buttonPInfo
            // 
            this.buttonPInfo.Location = new System.Drawing.Point(36, 118);
            this.buttonPInfo.Name = "buttonPInfo";
            this.buttonPInfo.Size = new System.Drawing.Size(133, 37);
            this.buttonPInfo.TabIndex = 1;
            this.buttonPInfo.Text = "Publisher Information";
            this.buttonPInfo.UseVisualStyleBackColor = true;
            this.buttonPInfo.Click += new System.EventHandler(this.buttonPInfo_Click);
            // 
            // buttonEinfo
            // 
            this.buttonEinfo.Location = new System.Drawing.Point(36, 200);
            this.buttonEinfo.Name = "buttonEinfo";
            this.buttonEinfo.Size = new System.Drawing.Size(133, 37);
            this.buttonEinfo.TabIndex = 2;
            this.buttonEinfo.Text = "Employee Information";
            this.buttonEinfo.UseVisualStyleBackColor = true;
            this.buttonEinfo.Click += new System.EventHandler(this.buttonEinfo_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(36, 294);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(133, 37);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Return to main menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // AdminInfo
            // 
            this.AdminInfo.Controls.Add(this.buttonModify);
            this.AdminInfo.Controls.Add(this.buttonAdd);
            this.AdminInfo.Controls.Add(this.textBoxZip);
            this.AdminInfo.Controls.Add(this.textBoxState);
            this.AdminInfo.Controls.Add(this.textBoxCity);
            this.AdminInfo.Controls.Add(this.textBoxStreet);
            this.AdminInfo.Controls.Add(this.labelZip);
            this.AdminInfo.Controls.Add(this.labelState);
            this.AdminInfo.Controls.Add(this.labelCity);
            this.AdminInfo.Controls.Add(this.labelStreet);
            this.AdminInfo.Controls.Add(this.textBoxName);
            this.AdminInfo.Controls.Add(this.labelName);
            this.AdminInfo.Controls.Add(this.textBoxID);
            this.AdminInfo.Controls.Add(this.AdminInfoID);
            this.AdminInfo.Location = new System.Drawing.Point(239, 30);
            this.AdminInfo.Name = "AdminInfo";
            this.AdminInfo.Size = new System.Drawing.Size(312, 319);
            this.AdminInfo.TabIndex = 5;
            this.AdminInfo.TabStop = false;
            this.AdminInfo.Text = "AdminInformation";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(204, 272);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 21);
            this.buttonModify.TabIndex = 13;
            this.buttonModify.Text = "Update";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(64, 272);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 21);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(179, 216);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 21);
            this.textBoxZip.TabIndex = 11;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(179, 179);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(100, 21);
            this.textBoxState.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(179, 144);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 21);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(179, 110);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 21);
            this.textBoxStreet.TabIndex = 8;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(62, 222);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(23, 12);
            this.labelZip.TabIndex = 7;
            this.labelZip.Text = "Zip";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(62, 185);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 12);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(62, 150);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 12);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(62, 113);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(41, 12);
            this.labelStreet.TabIndex = 4;
            this.labelStreet.Text = "Street";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(179, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(62, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(179, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // AdminInfoID
            // 
            this.AdminInfoID.AutoSize = true;
            this.AdminInfoID.Location = new System.Drawing.Point(62, 30);
            this.AdminInfoID.Name = "AdminInfoID";
            this.AdminInfoID.Size = new System.Drawing.Size(17, 12);
            this.AdminInfoID.TabIndex = 0;
            this.AdminInfoID.Text = "ID";
            // 
            // AdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 365);
            this.Controls.Add(this.AdminInfo);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonEinfo);
            this.Controls.Add(this.buttonPInfo);
            this.Controls.Add(this.buttonCInfo);
            this.Name = "AdminApp";
            this.Text = "Admin Application";
            this.AdminInfo.ResumeLayout(false);
            this.AdminInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCInfo;
        private System.Windows.Forms.Button buttonPInfo;
        private System.Windows.Forms.Button buttonEinfo;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox AdminInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label AdminInfoID;
        private System.Windows.Forms.Button buttonModify;
    }
}