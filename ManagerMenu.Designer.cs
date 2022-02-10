namespace FYP_Event
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rdbSchRep = new System.Windows.Forms.RadioButton();
            this.rdbEveRep = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rdbPayRep = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWelcome.Location = new System.Drawing.Point(79, 117);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(295, 26);
            this.lblWelcome.TabIndex = 54;
            this.lblWelcome.Text = "WELCOME TO MANAGER MAIN MENU";
            // 
            // rdbSchRep
            // 
            this.rdbSchRep.AutoSize = true;
            this.rdbSchRep.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSchRep.Location = new System.Drawing.Point(66, 55);
            this.rdbSchRep.Name = "rdbSchRep";
            this.rdbSchRep.Size = new System.Drawing.Size(143, 25);
            this.rdbSchRep.TabIndex = 1;
            this.rdbSchRep.Text = "Schedule Report";
            this.rdbSchRep.UseVisualStyleBackColor = true;
            // 
            // rdbEveRep
            // 
            this.rdbEveRep.AutoSize = true;
            this.rdbEveRep.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEveRep.Location = new System.Drawing.Point(66, 24);
            this.rdbEveRep.Name = "rdbEveRep";
            this.rdbEveRep.Size = new System.Drawing.Size(120, 25);
            this.rdbEveRep.TabIndex = 0;
            this.rdbEveRep.Text = "Event Report";
            this.rdbEveRep.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(240, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 58;
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
            this.btnClick.Location = new System.Drawing.Point(148, 279);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(76, 25);
            this.btnClick.TabIndex = 57;
            this.btnClick.TabStop = false;
            this.btnClick.Text = "Click Here";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.rdbPayRep);
            this.grpMenu.Controls.Add(this.rdbSchRep);
            this.grpMenu.Controls.Add(this.rdbEveRep);
            this.grpMenu.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(95, 146);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(263, 125);
            this.grpMenu.TabIndex = 55;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "MAIN MENU";
            // 
            // rdbPayRep
            // 
            this.rdbPayRep.AutoSize = true;
            this.rdbPayRep.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPayRep.Location = new System.Drawing.Point(66, 86);
            this.rdbPayRep.Name = "rdbPayRep";
            this.rdbPayRep.Size = new System.Drawing.Size(141, 25);
            this.rdbPayRep.TabIndex = 2;
            this.rdbPayRep.Text = "Payment Report";
            this.rdbPayRep.UseVisualStyleBackColor = true;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 323);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.RadioButton rdbSchRep;
        private System.Windows.Forms.RadioButton rdbEveRep;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.RadioButton rdbPayRep;
    }
}