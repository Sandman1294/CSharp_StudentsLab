namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmitRes = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblDaysOnCampus = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtDaysOnCampus = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSubmit = new System.Windows.Forms.GroupBox();
            this.btnSubmitOff = new System.Windows.Forms.Button();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.grpSubmit.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(0, 19);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(167, 49);
            this.btnRes.TabIndex = 1;
            this.btnRes.Text = "Resident Student";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.ResidentFunction);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(325, 19);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(167, 49);
            this.btnCom.TabIndex = 2;
            this.btnCom.Text = "Off Campus Student";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.OffCampusFunction);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitFunction);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(653, 19);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(167, 49);
            this.btnExit2.TabIndex = 4;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.ExitFunction);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(325, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetFunction);
            // 
            // btnSubmitRes
            // 
            this.btnSubmitRes.Location = new System.Drawing.Point(0, 19);
            this.btnSubmitRes.Name = "btnSubmitRes";
            this.btnSubmitRes.Size = new System.Drawing.Size(81, 49);
            this.btnSubmitRes.TabIndex = 6;
            this.btnSubmitRes.Text = "Submit Data";
            this.btnSubmitRes.UseVisualStyleBackColor = true;
            this.btnSubmitRes.Visible = false;
            this.btnSubmitRes.Click += new System.EventHandler(this.SubmitRes);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Please Enter Your Name :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(136, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Please Enter Your Address:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(6, 102);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(124, 13);
            this.lblMajor.TabIndex = 9;
            this.lblMajor.Text = "Please Enter Your Major:";
            // 
            // lblDaysOnCampus
            // 
            this.lblDaysOnCampus.AutoSize = true;
            this.lblDaysOnCampus.Location = new System.Drawing.Point(6, 135);
            this.lblDaysOnCampus.Name = "lblDaysOnCampus";
            this.lblDaysOnCampus.Size = new System.Drawing.Size(124, 13);
            this.lblDaysOnCampus.TabIndex = 10;
            this.lblDaysOnCampus.Text = "Days/Week on Campus:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtDaysOnCampus);
            this.grpInfo.Controls.Add(this.txtMajor);
            this.grpInfo.Controls.Add(this.txtAddress);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.lblDaysOnCampus);
            this.grpInfo.Controls.Add(this.lblAddress);
            this.grpInfo.Controls.Add(this.lblMajor);
            this.grpInfo.Location = new System.Drawing.Point(12, 117);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(819, 178);
            this.grpInfo.TabIndex = 11;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Student Information:";
            this.grpInfo.Visible = false;
            // 
            // txtDaysOnCampus
            // 
            this.txtDaysOnCampus.Location = new System.Drawing.Point(245, 128);
            this.txtDaysOnCampus.Name = "txtDaysOnCampus";
            this.txtDaysOnCampus.Size = new System.Drawing.Size(387, 20);
            this.txtDaysOnCampus.TabIndex = 14;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(245, 95);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(387, 20);
            this.txtMajor.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(245, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(387, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 20);
            this.txtName.TabIndex = 11;
            // 
            // grpSubmit
            // 
            this.grpSubmit.Controls.Add(this.btnSubmitOff);
            this.grpSubmit.Controls.Add(this.btnReset);
            this.grpSubmit.Controls.Add(this.btnSubmitRes);
            this.grpSubmit.Controls.Add(this.btnExit2);
            this.grpSubmit.Location = new System.Drawing.Point(12, 382);
            this.grpSubmit.Name = "grpSubmit";
            this.grpSubmit.Size = new System.Drawing.Size(819, 84);
            this.grpSubmit.TabIndex = 12;
            this.grpSubmit.TabStop = false;
            this.grpSubmit.Text = "Submit Buttons";
            this.grpSubmit.Visible = false;
            // 
            // btnSubmitOff
            // 
            this.btnSubmitOff.Location = new System.Drawing.Point(87, 19);
            this.btnSubmitOff.Name = "btnSubmitOff";
            this.btnSubmitOff.Size = new System.Drawing.Size(80, 49);
            this.btnSubmitOff.TabIndex = 7;
            this.btnSubmitOff.Text = "Submit Data";
            this.btnSubmitOff.UseVisualStyleBackColor = true;
            this.btnSubmitOff.Visible = false;
            this.btnSubmitOff.Click += new System.EventHandler(this.OffSubmit);
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.btnExit);
            this.grpStudents.Controls.Add(this.btnRes);
            this.grpStudents.Controls.Add(this.btnCom);
            this.grpStudents.Location = new System.Drawing.Point(12, 301);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(819, 75);
            this.grpStudents.TabIndex = 13;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Choose Which Kind of Student You Are:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 478);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpSubmit);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To SUNY Adirondack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpSubmit.ResumeLayout(false);
            this.grpStudents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmitRes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblDaysOnCampus;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtDaysOnCampus;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSubmit;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.Button btnSubmitOff;
    }
}

