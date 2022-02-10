namespace FYP_Event
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.cboQuantity = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblTotalPr = new System.Windows.Forms.Label();
            this.lblDisPrice = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDisBill = new System.Windows.Forms.Button();
            this.txtCIDU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.grpP = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPay.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 34);
            this.label1.TabIndex = 63;
            this.label1.Text = "HOTEL EVENT MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // grpPay
            // 
            this.grpPay.BackColor = System.Drawing.Color.Transparent;
            this.grpPay.Controls.Add(this.cboQuantity);
            this.grpPay.Controls.Add(this.txtPrice);
            this.grpPay.Controls.Add(this.label5);
            this.grpPay.Controls.Add(this.txtDeposit);
            this.grpPay.Controls.Add(this.lblTotalPr);
            this.grpPay.Controls.Add(this.lblDisPrice);
            this.grpPay.Controls.Add(this.txtTotal);
            this.grpPay.Controls.Add(this.btnCal);
            this.grpPay.Controls.Add(this.label7);
            this.grpPay.Enabled = false;
            this.grpPay.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPay.ForeColor = System.Drawing.Color.Black;
            this.grpPay.Location = new System.Drawing.Point(25, 233);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(292, 250);
            this.grpPay.TabIndex = 65;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "PAYMENT";
            // 
            // cboQuantity
            // 
            this.cboQuantity.BackColor = System.Drawing.Color.White;
            this.cboQuantity.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuantity.FormattingEnabled = true;
            this.cboQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuantity.Location = new System.Drawing.Point(130, 79);
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(136, 25);
            this.cboQuantity.TabIndex = 83;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(130, 40);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 24);
            this.txtPrice.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(23, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "Price (RM)";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BackColor = System.Drawing.Color.White;
            this.txtDeposit.Enabled = false;
            this.txtDeposit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDeposit.Location = new System.Drawing.Point(129, 118);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(137, 24);
            this.txtDeposit.TabIndex = 6;
            this.txtDeposit.Text = "100";
            // 
            // lblTotalPr
            // 
            this.lblTotalPr.AutoSize = true;
            this.lblTotalPr.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPr.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotalPr.Location = new System.Drawing.Point(17, 197);
            this.lblTotalPr.Name = "lblTotalPr";
            this.lblTotalPr.Size = new System.Drawing.Size(100, 18);
            this.lblTotalPr.TabIndex = 0;
            this.lblTotalPr.Text = "Total Price (RM)";
            // 
            // lblDisPrice
            // 
            this.lblDisPrice.AutoSize = true;
            this.lblDisPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblDisPrice.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDisPrice.Location = new System.Drawing.Point(23, 122);
            this.lblDisPrice.Name = "lblDisPrice";
            this.lblDisPrice.Size = new System.Drawing.Size(83, 18);
            this.lblDisPrice.TabIndex = 11;
            this.lblDisPrice.Text = "Deposit (RM)";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTotal.Location = new System.Drawing.Point(129, 197);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 24);
            this.txtTotal.TabIndex = 12;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Moccasin;
            this.btnCal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCal.Location = new System.Drawing.Point(161, 156);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(70, 31);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(17, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Quantity (DAY)";
            // 
            // btnDisBill
            // 
            this.btnDisBill.BackColor = System.Drawing.Color.Moccasin;
            this.btnDisBill.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisBill.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDisBill.Location = new System.Drawing.Point(523, 575);
            this.btnDisBill.Name = "btnDisBill";
            this.btnDisBill.Size = new System.Drawing.Size(120, 23);
            this.btnDisBill.TabIndex = 22;
            this.btnDisBill.Text = "Display Order Bill";
            this.btnDisBill.UseVisualStyleBackColor = false;
            this.btnDisBill.Click += new System.EventHandler(this.btnDisBill_Click);
            // 
            // txtCIDU
            // 
            this.txtCIDU.BackColor = System.Drawing.Color.White;
            this.txtCIDU.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIDU.Location = new System.Drawing.Point(162, 73);
            this.txtCIDU.Name = "txtCIDU";
            this.txtCIDU.Size = new System.Drawing.Size(137, 24);
            this.txtCIDU.TabIndex = 70;
            this.txtCIDU.TextChanged += new System.EventHandler(this.txtCIDU_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Please Insert Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(42, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Customer ID";
            // 
            // grpUpdate
            // 
            this.grpUpdate.BackColor = System.Drawing.Color.Transparent;
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Controls.Add(this.txtCIDU);
            this.grpUpdate.Controls.Add(this.cboStatus);
            this.grpUpdate.Controls.Add(this.button1);
            this.grpUpdate.Controls.Add(this.label12);
            this.grpUpdate.Enabled = false;
            this.grpUpdate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.ForeColor = System.Drawing.Color.Black;
            this.grpUpdate.Location = new System.Drawing.Point(361, 233);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(329, 250);
            this.grpUpdate.TabIndex = 81;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "UPDATE";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.White;
            this.cboStatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Has Paid",
            "Not Paid Yet"});
            this.cboStatus.Location = new System.Drawing.Point(162, 115);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(137, 25);
            this.cboStatus.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(186, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(55, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 80;
            this.label12.Text = "Pay Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Event Type";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(24, 7);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(167, 19);
            this.lblDetail.TabIndex = 69;
            this.lblDetail.Text = "Please Insert Event Type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboEvent);
            this.panel1.Controls.Add(this.lblDetail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(271, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 64);
            this.panel1.TabIndex = 73;
            // 
            // cboEvent
            // 
            this.cboEvent.BackColor = System.Drawing.Color.White;
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Items.AddRange(new object[] {
            "Full Day Meeting",
            "Half Day Meeting",
            "Full Day Seminar",
            "Half Day Seminar",
            "Birthday Party"});
            this.cboEvent.Location = new System.Drawing.Point(105, 29);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(121, 21);
            this.cboEvent.TabIndex = 70;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Moccasin;
            this.btnPay.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPay.Location = new System.Drawing.Point(161, 174);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(95, 26);
            this.btnPay.TabIndex = 81;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // grpP
            // 
            this.grpP.BackColor = System.Drawing.Color.Transparent;
            this.grpP.Controls.Add(this.txtAmount);
            this.grpP.Controls.Add(this.txtTotalPr);
            this.grpP.Controls.Add(this.label6);
            this.grpP.Controls.Add(this.txtBalance);
            this.grpP.Controls.Add(this.label10);
            this.grpP.Controls.Add(this.btnCalculate);
            this.grpP.Controls.Add(this.label13);
            this.grpP.Enabled = false;
            this.grpP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpP.ForeColor = System.Drawing.Color.Black;
            this.grpP.Location = new System.Drawing.Point(25, 498);
            this.grpP.Name = "grpP";
            this.grpP.Size = new System.Drawing.Size(456, 167);
            this.grpP.TabIndex = 84;
            this.grpP.TabStop = false;
            this.grpP.Text = "PAYMENT";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(171, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(137, 24);
            this.txtAmount.TabIndex = 83;
            // 
            // txtTotalPr
            // 
            this.txtTotalPr.BackColor = System.Drawing.Color.White;
            this.txtTotalPr.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPr.Location = new System.Drawing.Point(171, 38);
            this.txtTotalPr.Name = "txtTotalPr";
            this.txtTotalPr.Size = new System.Drawing.Size(137, 24);
            this.txtTotalPr.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(57, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Total Price (RM)";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBalance.Location = new System.Drawing.Point(171, 121);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(137, 24);
            this.txtBalance.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(57, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Balance (RM)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Moccasin;
            this.btnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCalculate.Location = new System.Drawing.Point(336, 74);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(70, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(57, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 18);
            this.label13.TabIndex = 80;
            this.label13.Text = "Amount Pay (RM)";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 685);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpP);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDisBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPay);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPay.ResumeLayout(false);
            this.grpPay.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpP.ResumeLayout(false);
            this.grpP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.Button btnDisBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDisPrice;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblTotalPr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCIDU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboQuantity;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox grpP;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTotalPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboEvent;
    }
}