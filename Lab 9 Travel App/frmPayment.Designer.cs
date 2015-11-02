namespace Lab_9_Travel_App
{
    partial class frmPayment
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBitcoin = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.pctBitCoinImage2 = new System.Windows.Forms.PictureBox();
            this.pctBitCoinImage1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBitCoinImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBitCoinImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(325, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(435, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBitcoin);
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your payment:";
            // 
            // rdoBitcoin
            // 
            this.rdoBitcoin.AutoSize = true;
            this.rdoBitcoin.Location = new System.Drawing.Point(219, 36);
            this.rdoBitcoin.Name = "rdoBitcoin";
            this.rdoBitcoin.Size = new System.Drawing.Size(71, 20);
            this.rdoBitcoin.TabIndex = 2;
            this.rdoBitcoin.TabStop = true;
            this.rdoBitcoin.Text = "BitCoin";
            this.rdoBitcoin.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(109, 36);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(104, 20);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash Money";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(6, 36);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(96, 20);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit Card:";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 16;
            this.lstCreditCardType.Location = new System.Drawing.Point(97, 95);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(215, 100);
            this.lstCreditCardType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credit Card Number:";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(146, 214);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(225, 22);
            this.txtCreditCardNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiration Date:";
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Location = new System.Drawing.Point(122, 258);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(121, 24);
            this.cboExpirationMonth.TabIndex = 8;
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(250, 257);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(121, 24);
            this.cboExpirationYear.TabIndex = 9;
            // 
            // pctBitCoinImage2
            // 
            this.pctBitCoinImage2.Image = global::Lab_9_Travel_App.Properties.Resources.default_qrcode;
            this.pctBitCoinImage2.Location = new System.Drawing.Point(325, 287);
            this.pctBitCoinImage2.Name = "pctBitCoinImage2";
            this.pctBitCoinImage2.Size = new System.Drawing.Size(194, 193);
            this.pctBitCoinImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBitCoinImage2.TabIndex = 11;
            this.pctBitCoinImage2.TabStop = false;
            // 
            // pctBitCoinImage1
            // 
            this.pctBitCoinImage1.Image = global::Lab_9_Travel_App.Properties.Resources.weAcceptBitcoin;
            this.pctBitCoinImage1.InitialImage = global::Lab_9_Travel_App.Properties.Resources.weAcceptBitcoin;
            this.pctBitCoinImage1.Location = new System.Drawing.Point(13, 307);
            this.pctBitCoinImage1.Margin = new System.Windows.Forms.Padding(0);
            this.pctBitCoinImage1.Name = "pctBitCoinImage1";
            this.pctBitCoinImage1.Size = new System.Drawing.Size(290, 111);
            this.pctBitCoinImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBitCoinImage1.TabIndex = 10;
            this.pctBitCoinImage1.TabStop = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 575);
            this.ControlBox = false;
            this.Controls.Add(this.pctBitCoinImage2);
            this.Controls.Add(this.pctBitCoinImage1);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.Text = "Payment Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBitCoinImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBitCoinImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBitcoin;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.PictureBox pctBitCoinImage1;
        private System.Windows.Forms.PictureBox pctBitCoinImage2;
    }
}