namespace StudentManagement
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnview = new System.Windows.Forms.Button();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbcour = new System.Windows.Forms.ComboBox();
            this.cbcolleg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddfee = new System.Windows.Forms.TextBox();
            this.txtrfee = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtpaidfee = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txttofee = new System.Windows.Forms.TextBox();
            this.txtstname2 = new System.Windows.Forms.TextBox();
            this.txtstname1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.txtstudentid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Fees";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(539, 55);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(104, 39);
            this.btnview.TabIndex = 3;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(286, 39);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(100, 39);
            this.txtstudentid.TabIndex = 2;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.cbcour);
            this.groupBox2.Controls.Add(this.cbcolleg);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtaddfee);
            this.groupBox2.Controls.Add(this.txtrfee);
            this.groupBox2.Controls.Add(this.txtmobile);
            this.groupBox2.Controls.Add(this.txtpaidfee);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txttofee);
            this.groupBox2.Controls.Add(this.txtstname2);
            this.groupBox2.Controls.Add(this.txtstname1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(67, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1212, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee Detail";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(948, 343);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(164, 50);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbcour
            // 
            this.cbcour.FormattingEnabled = true;
            this.cbcour.Items.AddRange(new object[] {
            "ECE",
            "CSE",
            "EEE",
            "CIVIL"});
            this.cbcour.Location = new System.Drawing.Point(927, 144);
            this.cbcour.Name = "cbcour";
            this.cbcour.Size = new System.Drawing.Size(121, 40);
            this.cbcour.TabIndex = 18;
            // 
            // cbcolleg
            // 
            this.cbcolleg.FormattingEnabled = true;
            this.cbcolleg.Items.AddRange(new object[] {
            "NIT",
            "VASAVI",
            "VISHNU",
            "GITAM"});
            this.cbcolleg.Location = new System.Drawing.Point(927, 221);
            this.cbcolleg.Name = "cbcolleg";
            this.cbcolleg.Size = new System.Drawing.Size(121, 40);
            this.cbcolleg.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Rem.Fees: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtaddfee
            // 
            this.txtaddfee.Location = new System.Drawing.Point(649, 354);
            this.txtaddfee.Name = "txtaddfee";
            this.txtaddfee.Size = new System.Drawing.Size(100, 39);
            this.txtaddfee.TabIndex = 16;
            // 
            // txtrfee
            // 
            this.txtrfee.Location = new System.Drawing.Point(641, 261);
            this.txtrfee.Name = "txtrfee";
            this.txtrfee.Size = new System.Drawing.Size(100, 39);
            this.txtrfee.TabIndex = 15;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(948, 63);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(100, 39);
            this.txtmobile.TabIndex = 14;
            // 
            // txtpaidfee
            // 
            this.txtpaidfee.Location = new System.Drawing.Point(294, 261);
            this.txtpaidfee.Name = "txtpaidfee";
            this.txtpaidfee.Size = new System.Drawing.Size(100, 39);
            this.txtpaidfee.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(328, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 39);
            this.txtEmail.TabIndex = 12;
            // 
            // txttofee
            // 
            this.txttofee.Location = new System.Drawing.Point(328, 172);
            this.txttofee.Name = "txttofee";
            this.txttofee.Size = new System.Drawing.Size(100, 39);
            this.txttofee.TabIndex = 11;
            this.txttofee.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtstname2
            // 
            this.txtstname2.Location = new System.Drawing.Point(468, 58);
            this.txtstname2.Name = "txtstname2";
            this.txtstname2.Size = new System.Drawing.Size(100, 39);
            this.txtstname2.TabIndex = 10;
            this.txtstname2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtstname1
            // 
            this.txtstname1.Location = new System.Drawing.Point(328, 59);
            this.txtstname1.Name = "txtstname1";
            this.txtstname1.Size = new System.Drawing.Size(100, 39);
            this.txtstname1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Mobile:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 32);
            this.label10.TabIndex = 7;
            this.label10.Text = "ADD FEES: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(716, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Course:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "College:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "E mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Paid fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT FEES";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.Text = "FEE PAYMENT";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbcour;
        private System.Windows.Forms.ComboBox cbcolleg;
        private System.Windows.Forms.TextBox txtaddfee;
        private System.Windows.Forms.TextBox txtrfee;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtpaidfee;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txttofee;
        private System.Windows.Forms.TextBox txtstname2;
        private System.Windows.Forms.TextBox txtstname1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}