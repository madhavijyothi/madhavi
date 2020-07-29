namespace StudentManagement
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
            this.lblstudent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsur = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.cbcollege = new System.Windows.Forms.ComboBox();
            this.cbteacher = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.Location = new System.Drawing.Point(549, 22);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(280, 34);
            this.lblstudent.TabIndex = 0;
            this.lblstudent.Text = "ADD NEW STUDENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.txtpincode);
            this.groupBox1.Controls.Add(this.txtcontact);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtsur);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(346, 308);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(127, 45);
            this.btnnext.TabIndex = 12;
            this.btnnext.Text = "Next..";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(418, 97);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(100, 39);
            this.txtpincode.TabIndex = 11;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(427, 177);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 39);
            this.txtcontact.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(141, 267);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 39);
            this.txtemail.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(141, 198);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 39);
            this.txtaddress.TabIndex = 8;
            // 
            // txtsur
            // 
            this.txtsur.Location = new System.Drawing.Point(160, 128);
            this.txtsur.Name = "txtsur";
            this.txtsur.Size = new System.Drawing.Size(100, 39);
            this.txtsur.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(141, 62);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 39);
            this.txtname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact No: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pincode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.cbyear);
            this.groupBox2.Controls.Add(this.txtdetail);
            this.groupBox2.Controls.Add(this.txtfees);
            this.groupBox2.Controls.Add(this.cbcollege);
            this.groupBox2.Controls.Add(this.cbteacher);
            this.groupBox2.Controls.Add(this.cbcourse);
            this.groupBox2.Controls.Add(this.btnsubmit);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(638, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 482);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Educational Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 305);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cbyear
            // 
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbyear.Location = new System.Drawing.Point(505, 304);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(121, 40);
            this.cbyear.TabIndex = 15;
            // 
            // txtdetail
            // 
            this.txtdetail.Location = new System.Drawing.Point(505, 227);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(100, 39);
            this.txtdetail.TabIndex = 14;
            // 
            // txtfees
            // 
            this.txtfees.Location = new System.Drawing.Point(517, 80);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(100, 39);
            this.txtfees.TabIndex = 13;
            // 
            // cbcollege
            // 
            this.cbcollege.FormattingEnabled = true;
            this.cbcollege.Items.AddRange(new object[] {
            "VASAVI",
            "NIT ",
            "BVRIT",
            "VISHNU",
            "GITAM"});
            this.cbcollege.Location = new System.Drawing.Point(145, 158);
            this.cbcollege.Name = "cbcollege";
            this.cbcollege.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbcollege.Size = new System.Drawing.Size(121, 40);
            this.cbcollege.TabIndex = 12;
            // 
            // cbteacher
            // 
            this.cbteacher.FormattingEnabled = true;
            this.cbteacher.Items.AddRange(new object[] {
            "DEEPA",
            "VISHYA",
            "VISHYA",
            "GEETHA"});
            this.cbteacher.Location = new System.Drawing.Point(484, 162);
            this.cbteacher.Name = "cbteacher";
            this.cbteacher.Size = new System.Drawing.Size(121, 40);
            this.cbteacher.TabIndex = 11;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "ECE",
            "CSE",
            "EE",
            "CICIL",
            "IT"});
            this.cbcourse.Location = new System.Drawing.Point(142, 90);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(121, 40);
            this.cbcourse.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(243, 430);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(170, 46);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(334, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 32);
            this.label16.TabIndex = 8;
            this.label16.Text = "Teacher:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 32);
            this.label15.TabIndex = 7;
            this.label15.Text = "Fees:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(388, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 32);
            this.label14.TabIndex = 6;
            this.label14.Text = "Detail:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Year:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "End Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "College:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1422, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Addstudent";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblstudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "ADD STUDENT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtpincode;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsur;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.ComboBox cbcollege;
        private System.Windows.Forms.ComboBox cbteacher;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

