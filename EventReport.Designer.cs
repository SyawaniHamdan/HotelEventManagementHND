namespace FYP_Event
{
    partial class EventReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventReport));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.rdbAn = new System.Windows.Forms.RadioButton();
            this.rdbMon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(240, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 63;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClick.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClick.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(148, 282);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(76, 25);
            this.btnClick.TabIndex = 62;
            this.btnClick.TabStop = false;
            this.btnClick.Text = "Click Here";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.lblDetail);
            this.grpMenu.Controls.Add(this.rdbAn);
            this.grpMenu.Controls.Add(this.rdbMon);
            this.grpMenu.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(97, 129);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(263, 125);
            this.grpMenu.TabIndex = 60;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "EVENT REPORT";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(32, 27);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(203, 19);
            this.lblDetail.TabIndex = 70;
            this.lblDetail.Text = "Please Choose Your Preference:";
            // 
            // rdbAn
            // 
            this.rdbAn.AutoSize = true;
            this.rdbAn.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAn.Location = new System.Drawing.Point(53, 80);
            this.rdbAn.Name = "rdbAn";
            this.rdbAn.Size = new System.Drawing.Size(143, 25);
            this.rdbAn.TabIndex = 1;
            this.rdbAn.Text = "Annually Report";
            this.rdbAn.UseVisualStyleBackColor = true;
            // 
            // rdbMon
            // 
            this.rdbMon.AutoSize = true;
            this.rdbMon.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMon.Location = new System.Drawing.Point(53, 49);
            this.rdbMon.Name = "rdbMon";
            this.rdbMon.Size = new System.Drawing.Size(139, 25);
            this.rdbMon.TabIndex = 0;
            this.rdbMon.Text = "Monthly Report";
            this.rdbMon.UseVisualStyleBackColor = true;
            // 
            // EventReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 323);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpMenu);
            this.Name = "EventReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventReport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.RadioButton rdbAn;
        private System.Windows.Forms.RadioButton rdbMon;
        private System.Windows.Forms.Label lblDetail;
    }
}