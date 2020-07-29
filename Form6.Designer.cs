namespace StudentManagement
{
    partial class Form6
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
            this.btnfeepay = new System.Windows.Forms.Button();
            this.btnaddstu = new System.Windows.Forms.Button();
            this.btnaddteach = new System.Windows.Forms.Button();
            this.btnaddcour = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfeepay);
            this.groupBox1.Controls.Add(this.btnaddstu);
            this.groupBox1.Controls.Add(this.btnaddteach);
            this.groupBox1.Controls.Add(this.btnaddcour);
            this.groupBox1.Location = new System.Drawing.Point(278, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEERA ACADMEY";
            // 
            // btnfeepay
            // 
            this.btnfeepay.Location = new System.Drawing.Point(176, 401);
            this.btnfeepay.Name = "btnfeepay";
            this.btnfeepay.Size = new System.Drawing.Size(429, 73);
            this.btnfeepay.TabIndex = 3;
            this.btnfeepay.Text = "FEE PAYMENT";
            this.btnfeepay.UseVisualStyleBackColor = true;
            this.btnfeepay.Click += new System.EventHandler(this.btnfeepay_Click);
            // 
            // btnaddstu
            // 
            this.btnaddstu.Location = new System.Drawing.Point(176, 294);
            this.btnaddstu.Name = "btnaddstu";
            this.btnaddstu.Size = new System.Drawing.Size(429, 61);
            this.btnaddstu.TabIndex = 2;
            this.btnaddstu.Text = "ADD STUDENT";
            this.btnaddstu.UseVisualStyleBackColor = true;
            this.btnaddstu.Click += new System.EventHandler(this.btnaddstu_Click);
            // 
            // btnaddteach
            // 
            this.btnaddteach.Location = new System.Drawing.Point(176, 181);
            this.btnaddteach.Name = "btnaddteach";
            this.btnaddteach.Size = new System.Drawing.Size(414, 64);
            this.btnaddteach.TabIndex = 1;
            this.btnaddteach.Text = "ADD TEACHER";
            this.btnaddteach.UseVisualStyleBackColor = true;
            this.btnaddteach.Click += new System.EventHandler(this.btnaddteach_Click);
            // 
            // btnaddcour
            // 
            this.btnaddcour.Location = new System.Drawing.Point(176, 63);
            this.btnaddcour.Name = "btnaddcour";
            this.btnaddcour.Size = new System.Drawing.Size(414, 76);
            this.btnaddcour.TabIndex = 0;
            this.btnaddcour.Text = "ADD COURSES";
            this.btnaddcour.UseVisualStyleBackColor = true;
            this.btnaddcour.Click += new System.EventHandler(this.btnaddcour_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 833);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form6";
            this.Text = "MEERA ACADMEY";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfeepay;
        private System.Windows.Forms.Button btnaddstu;
        private System.Windows.Forms.Button btnaddteach;
        private System.Windows.Forms.Button btnaddcour;
    }
}