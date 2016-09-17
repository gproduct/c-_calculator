namespace complex_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_a_re = new System.Windows.Forms.TextBox();
            this.box_a_im = new System.Windows.Forms.TextBox();
            this.box_b_re = new System.Windows.Forms.TextBox();
            this.box_b_im = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.subs = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_result = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_a = new System.Windows.Forms.ComboBox();
            this.combo_b = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A complex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B complex";
            // 
            // box_a_re
            // 
            this.box_a_re.Location = new System.Drawing.Point(38, 91);
            this.box_a_re.Name = "box_a_re";
            this.box_a_re.Size = new System.Drawing.Size(100, 20);
            this.box_a_re.TabIndex = 2;
            // 
            // box_a_im
            // 
            this.box_a_im.Location = new System.Drawing.Point(220, 90);
            this.box_a_im.Name = "box_a_im";
            this.box_a_im.Size = new System.Drawing.Size(100, 20);
            this.box_a_im.TabIndex = 3;
            // 
            // box_b_re
            // 
            this.box_b_re.Location = new System.Drawing.Point(38, 167);
            this.box_b_re.Name = "box_b_re";
            this.box_b_re.Size = new System.Drawing.Size(100, 20);
            this.box_b_re.TabIndex = 4;
            // 
            // box_b_im
            // 
            this.box_b_im.Location = new System.Drawing.Point(220, 167);
            this.box_b_im.Name = "box_b_im";
            this.box_b_im.Size = new System.Drawing.Size(100, 20);
            this.box_b_im.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(38, 207);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 23);
            this.sum.TabIndex = 7;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // subs
            // 
            this.subs.Location = new System.Drawing.Point(220, 207);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(100, 23);
            this.subs.TabIndex = 8;
            this.subs.Text = "-";
            this.subs.UseVisualStyleBackColor = true;
            this.subs.Click += new System.EventHandler(this.subs_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(38, 253);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(100, 23);
            this.multi.TabIndex = 9;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(220, 253);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(100, 23);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Im";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Im";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Re";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Re";
            // 
            // box_result
            // 
            this.box_result.Location = new System.Drawing.Point(13, 24);
            this.box_result.Name = "box_result";
            this.box_result.Size = new System.Drawing.Size(269, 20);
            this.box_result.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Result";
            // 
            // combo_a
            // 
            this.combo_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_a.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_a.FormattingEnabled = true;
            this.combo_a.Items.AddRange(new object[] {
            "+",
            "-"});
            this.combo_a.Location = new System.Drawing.Point(144, 90);
            this.combo_a.Name = "combo_a";
            this.combo_a.Size = new System.Drawing.Size(46, 21);
            this.combo_a.TabIndex = 17;
            this.combo_a.SelectedIndexChanged += new System.EventHandler(this.combo_a_SelectedIndexChanged);
            // 
            // combo_b
            // 
            this.combo_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_b.FormattingEnabled = true;
            this.combo_b.Items.AddRange(new object[] {
            "+",
            "-"});
            this.combo_b.Location = new System.Drawing.Point(144, 167);
            this.combo_b.Name = "combo_b";
            this.combo_b.Size = new System.Drawing.Size(46, 21);
            this.combo_b.TabIndex = 18;
            this.combo_b.SelectedIndexChanged += new System.EventHandler(this.combo_b_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_b);
            this.Controls.Add(this.combo_a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.subs);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.box_b_im);
            this.Controls.Add(this.box_b_re);
            this.Controls.Add(this.box_a_im);
            this.Controls.Add(this.box_a_re);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Complex Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_a_re;
        private System.Windows.Forms.TextBox box_a_im;
        private System.Windows.Forms.TextBox box_b_re;
        private System.Windows.Forms.TextBox box_b_im;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button subs;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_a;
        private System.Windows.Forms.ComboBox combo_b;
        private System.Windows.Forms.Button button1;
    }
}

