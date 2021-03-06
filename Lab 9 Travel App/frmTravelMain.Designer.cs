﻿namespace Lab_9_Travel_App
{
    partial class frmTravelMain
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
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSegment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLengthTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStart
            // 
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Items.AddRange(new object[] {
            "Chicago, IL",
            "Fort Worth, TX",
            "Minneapolis, MN",
            "San Francisco, CA",
            "Seattle, WA"});
            this.cmbStart.Location = new System.Drawing.Point(96, 9);
            this.cmbStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(121, 21);
            this.cmbStart.Sorted = true;
            this.cmbStart.TabIndex = 0;
            this.cmbStart.SelectedIndexChanged += new System.EventHandler(this.ChangeDestinationCollection);
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(298, 11);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(121, 21);
            this.cmbDestination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Point: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSegment,
            this.colDeparts,
            this.colDestination,
            this.colDistance,
            this.colLengthTime,
            this.colPrice});
            this.listView1.Location = new System.Drawing.Point(16, 148);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 214);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colSegment
            // 
            this.colSegment.Text = "Segment";
            // 
            // colDeparts
            // 
            this.colDeparts.Text = "Departs";
            this.colDeparts.Width = 66;
            // 
            // colDestination
            // 
            this.colDestination.Text = "Destination";
            this.colDestination.Width = 75;
            // 
            // colDistance
            // 
            this.colDistance.Text = "Distance";
            // 
            // colLengthTime
            // 
            this.colLengthTime.Text = "Time";
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.AutoSize = true;
            this.btnMakePayment.Location = new System.Drawing.Point(16, 391);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(97, 41);
            this.btnMakePayment.TabIndex = 5;
            this.btnMakePayment.Text = "Make a payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Segment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTravelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 486);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.cmbStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTravelMain";
            this.Text = "Travel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSegment;
        private System.Windows.Forms.ColumnHeader colDeparts;
        private System.Windows.Forms.ColumnHeader colDestination;
        private System.Windows.Forms.ColumnHeader colDistance;
        private System.Windows.Forms.ColumnHeader colLengthTime;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnAdd;
    }
}

