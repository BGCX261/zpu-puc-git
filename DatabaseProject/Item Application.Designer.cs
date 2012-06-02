namespace DatabaseProject
{
    partial class Item_Application
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.panelItemD = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panelCD = new System.Windows.Forms.Panel();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.labelProducer = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.panelBook = new System.Windows.Forms.Panel();
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxEdi = new System.Windows.Forms.TextBox();
            this.textBoxISDN = new System.Windows.Forms.TextBox();
            this.labelEditor = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelEdi = new System.Windows.Forms.Label();
            this.labelISDN = new System.Windows.Forms.Label();
            this.radioButtonCD = new System.Windows.Forms.RadioButton();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.GroupItem.SuspendLayout();
            this.panelItemD.SuspendLayout();
            this.panelCD.SuspendLayout();
            this.panelBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(53, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 37);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(53, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete Item";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(53, 198);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(133, 37);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change Item Info";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(53, 291);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(133, 37);
            this.buttonQuery.TabIndex = 3;
            this.buttonQuery.Text = "Query Item Info";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Return to main menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupItem.Controls.Add(this.panelItemD);
            this.GroupItem.Controls.Add(this.buttonCancel);
            this.GroupItem.Controls.Add(this.buttonApply);
            this.GroupItem.Controls.Add(this.panelCD);
            this.GroupItem.Controls.Add(this.panelBook);
            this.GroupItem.Controls.Add(this.radioButtonCD);
            this.GroupItem.Controls.Add(this.radioButtonBook);
            this.GroupItem.Controls.Add(this.textBoxID);
            this.GroupItem.Controls.Add(this.labID);
            this.GroupItem.Location = new System.Drawing.Point(225, 27);
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Size = new System.Drawing.Size(433, 386);
            this.GroupItem.TabIndex = 5;
            this.GroupItem.TabStop = false;
            this.GroupItem.Text = "Item Information";
            // 
            // panelItemD
            // 
            this.panelItemD.Controls.Add(this.textBoxTitle);
            this.panelItemD.Controls.Add(this.labelTitle);
            this.panelItemD.Controls.Add(this.labelPrice);
            this.panelItemD.Controls.Add(this.labelYear);
            this.panelItemD.Controls.Add(this.labelQ);
            this.panelItemD.Controls.Add(this.textBoxQ);
            this.panelItemD.Controls.Add(this.textBoxPrice);
            this.panelItemD.Controls.Add(this.textBoxYear);
            this.panelItemD.Location = new System.Drawing.Point(51, 67);
            this.panelItemD.Name = "panelItemD";
            this.panelItemD.Size = new System.Drawing.Size(149, 128);
            this.panelItemD.TabIndex = 14;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(76, 103);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(54, 21);
            this.textBoxTitle.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(19, 103);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 12);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(17, 43);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 12);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(17, 13);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 12);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(17, 73);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(53, 12);
            this.labelQ.TabIndex = 3;
            this.labelQ.Text = "Quantity";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(76, 72);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(54, 21);
            this.textBoxQ.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(76, 41);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(54, 21);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(76, 10);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(54, 21);
            this.textBoxYear.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(257, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(257, 31);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // panelCD
            // 
            this.panelCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCD.Controls.Add(this.textBoxProducer);
            this.panelCD.Controls.Add(this.textBoxArtist);
            this.panelCD.Controls.Add(this.textBoxComp);
            this.panelCD.Controls.Add(this.textBoxSub);
            this.panelCD.Controls.Add(this.labelProducer);
            this.panelCD.Controls.Add(this.labelArtist);
            this.panelCD.Controls.Add(this.labelComp);
            this.panelCD.Controls.Add(this.labelSub);
            this.panelCD.Location = new System.Drawing.Point(257, 201);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(149, 166);
            this.panelCD.TabIndex = 11;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(80, 124);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(54, 21);
            this.textBoxProducer.TabIndex = 9;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(80, 90);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(54, 21);
            this.textBoxArtist.TabIndex = 8;
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(80, 53);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(54, 21);
            this.textBoxComp.TabIndex = 7;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(80, 22);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(54, 21);
            this.textBoxSub.TabIndex = 6;
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(18, 127);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(53, 12);
            this.labelProducer.TabIndex = 5;
            this.labelProducer.Text = "Producer";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(18, 93);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(41, 12);
            this.labelArtist.TabIndex = 4;
            this.labelArtist.Text = "Artist";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(18, 56);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(53, 12);
            this.labelComp.TabIndex = 3;
            this.labelComp.Text = "Composer";
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(18, 25);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(47, 12);
            this.labelSub.TabIndex = 2;
            this.labelSub.Text = "Subject";
            // 
            // panelBook
            // 
            this.panelBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBook.Controls.Add(this.textBoxEditor);
            this.panelBook.Controls.Add(this.textBoxAuthor);
            this.panelBook.Controls.Add(this.textBoxEdi);
            this.panelBook.Controls.Add(this.textBoxISDN);
            this.panelBook.Controls.Add(this.labelEditor);
            this.panelBook.Controls.Add(this.labelAuthor);
            this.panelBook.Controls.Add(this.labelEdi);
            this.panelBook.Controls.Add(this.labelISDN);
            this.panelBook.Location = new System.Drawing.Point(51, 201);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(149, 166);
            this.panelBook.TabIndex = 10;
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Location = new System.Drawing.Point(75, 124);
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(54, 21);
            this.textBoxEditor.TabIndex = 8;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(75, 90);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(54, 21);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // textBoxEdi
            // 
            this.textBoxEdi.Location = new System.Drawing.Point(75, 53);
            this.textBoxEdi.Name = "textBoxEdi";
            this.textBoxEdi.Size = new System.Drawing.Size(54, 21);
            this.textBoxEdi.TabIndex = 6;
            // 
            // textBoxISDN
            // 
            this.textBoxISDN.Location = new System.Drawing.Point(75, 22);
            this.textBoxISDN.Name = "textBoxISDN";
            this.textBoxISDN.Size = new System.Drawing.Size(54, 21);
            this.textBoxISDN.TabIndex = 5;
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(16, 127);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(41, 12);
            this.labelEditor.TabIndex = 4;
            this.labelEditor.Text = "Editor";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(16, 93);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 12);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Author";
            // 
            // labelEdi
            // 
            this.labelEdi.AutoSize = true;
            this.labelEdi.Location = new System.Drawing.Point(16, 56);
            this.labelEdi.Name = "labelEdi";
            this.labelEdi.Size = new System.Drawing.Size(47, 12);
            this.labelEdi.TabIndex = 2;
            this.labelEdi.Text = "Edition";
            // 
            // labelISDN
            // 
            this.labelISDN.AutoSize = true;
            this.labelISDN.Location = new System.Drawing.Point(16, 25);
            this.labelISDN.Name = "labelISDN";
            this.labelISDN.Size = new System.Drawing.Size(29, 12);
            this.labelISDN.TabIndex = 1;
            this.labelISDN.Text = "ISDN";
            // 
            // radioButtonCD
            // 
            this.radioButtonCD.AutoSize = true;
            this.radioButtonCD.Location = new System.Drawing.Point(257, 136);
            this.radioButtonCD.Name = "radioButtonCD";
            this.radioButtonCD.Size = new System.Drawing.Size(35, 16);
            this.radioButtonCD.TabIndex = 9;
            this.radioButtonCD.TabStop = true;
            this.radioButtonCD.Text = "CD";
            this.radioButtonCD.UseVisualStyleBackColor = true;
            this.radioButtonCD.CheckedChanged += new System.EventHandler(this.radioButtonCD_CheckedChanged);
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Location = new System.Drawing.Point(257, 107);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(47, 16);
            this.radioButtonBook.TabIndex = 8;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Book";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            this.radioButtonBook.CheckedChanged += new System.EventHandler(this.radioButtonBook_CheckedChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(127, 34);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(54, 21);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(70, 37);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(17, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID";
            // 
            // Item_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 425);
            this.Controls.Add(this.GroupItem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Item_Application";
            this.Text = "Item Application";
            this.Load += new System.EventHandler(this.Item_Application_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            this.panelItemD.ResumeLayout(false);
            this.panelItemD.PerformLayout();
            this.panelCD.ResumeLayout(false);
            this.panelCD.PerformLayout();
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.RadioButton radioButtonCD;
        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Panel panelCD;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxComp;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxEdi;
        private System.Windows.Forms.TextBox textBoxISDN;
        private System.Windows.Forms.Label labelEditor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelEdi;
        private System.Windows.Forms.Label labelISDN;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panelItemD;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}