namespace LAB4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.textBirthYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textListofPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textGPA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textGPAAvg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textGPAMin = new System.Windows.Forms.TextBox();
            this.textGPAMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textName3 = new System.Windows.Forms.TextBox();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(68, 28);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 0;
            // 
            // textBirthYear
            // 
            this.textBirthYear.Location = new System.Drawing.Point(68, 61);
            this.textBirthYear.Name = "textBirthYear";
            this.textBirthYear.Size = new System.Drawing.Size(125, 27);
            this.textBirthYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textListofPerson
            // 
            this.textListofPerson.Location = new System.Drawing.Point(306, 161);
            this.textListofPerson.Multiline = true;
            this.textListofPerson.Name = "textListofPerson";
            this.textListofPerson.Size = new System.Drawing.Size(125, 171);
            this.textListofPerson.TabIndex = 5;
            this.textListofPerson.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "รายชื่อ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "อายุรวม";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(306, 128);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(125, 27);
            this.textTotal.TabIndex = 8;
            this.textTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "GPA";
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(68, 95);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(125, 27);
            this.textGPA.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "GPA Avg";
            // 
            // textGPAAvg
            // 
            this.textGPAAvg.Location = new System.Drawing.Point(306, 91);
            this.textGPAAvg.Name = "textGPAAvg";
            this.textGPAAvg.Size = new System.Drawing.Size(125, 27);
            this.textGPAAvg.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "GPA Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "GPA Max";
            // 
            // textGPAMin
            // 
            this.textGPAMin.Location = new System.Drawing.Point(306, 57);
            this.textGPAMin.Name = "textGPAMin";
            this.textGPAMin.Size = new System.Drawing.Size(125, 27);
            this.textGPAMin.TabIndex = 12;
            // 
            // textGPAMax
            // 
            this.textGPAMax.Location = new System.Drawing.Point(306, 24);
            this.textGPAMax.Name = "textGPAMax";
            this.textGPAMax.Size = new System.Drawing.Size(125, 27);
            this.textGPAMax.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ชื่อ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "ชื่อ";
            // 
            // textName3
            // 
            this.textName3.Location = new System.Drawing.Point(497, 57);
            this.textName3.Name = "textName3";
            this.textName3.Size = new System.Drawing.Size(125, 27);
            this.textName3.TabIndex = 18;
            // 
            // textName2
            // 
            this.textName2.Location = new System.Drawing.Point(497, 24);
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(125, 27);
            this.textName2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textName3);
            this.Controls.Add(this.textName2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textGPAAvg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textGPAMin);
            this.Controls.Add(this.textGPAMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textListofPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBirthYear);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName;
        private TextBox textBirthYear;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textListofPerson;
        private Label label3;
        private Label label4;
        private TextBox textTotal;
        private Label label5;
        private TextBox textGPA;
        private Label label6;
        private TextBox textGPAAvg;
        private Label label7;
        private Label label8;
        private TextBox textGPAMin;
        private TextBox textGPAMax;
        private Label label9;
        private Label label10;
        private TextBox textName3;
        private TextBox textName2;
    }
}