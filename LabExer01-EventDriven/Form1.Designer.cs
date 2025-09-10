namespace LabExer01_EventDriven
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.frm1StudNum = new System.Windows.Forms.Label();
            this.frm1Prog = new System.Windows.Forms.Label();
            this.frm1LN = new System.Windows.Forms.Label();
            this.frm1FN = new System.Windows.Forms.Label();
            this.frm1MN = new System.Windows.Forms.Label();
            this.frm1Age = new System.Windows.Forms.Label();
            this.frm1ConNum = new System.Windows.Forms.Label();
            this.frm1Add = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox1.Location = new System.Drawing.Point(77, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox2.Location = new System.Drawing.Point(77, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox3.Location = new System.Drawing.Point(77, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox4.Location = new System.Drawing.Point(248, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox5.Location = new System.Drawing.Point(407, 259);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox6.Location = new System.Drawing.Point(146, 312);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // frm1StudNum
            // 
            this.frm1StudNum.AutoSize = true;
            this.frm1StudNum.BackColor = System.Drawing.Color.Transparent;
            this.frm1StudNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1StudNum.ForeColor = System.Drawing.Color.Black;
            this.frm1StudNum.Location = new System.Drawing.Point(74, 185);
            this.frm1StudNum.Name = "frm1StudNum";
            this.frm1StudNum.Size = new System.Drawing.Size(88, 18);
            this.frm1StudNum.TabIndex = 7;
            this.frm1StudNum.Text = "Student No. :";
            // 
            // frm1Prog
            // 
            this.frm1Prog.AutoSize = true;
            this.frm1Prog.BackColor = System.Drawing.Color.Transparent;
            this.frm1Prog.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1Prog.ForeColor = System.Drawing.Color.Black;
            this.frm1Prog.Location = new System.Drawing.Point(246, 183);
            this.frm1Prog.Name = "frm1Prog";
            this.frm1Prog.Size = new System.Drawing.Size(68, 18);
            this.frm1Prog.TabIndex = 8;
            this.frm1Prog.Text = "Program :";
            this.frm1Prog.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm1LN
            // 
            this.frm1LN.AutoSize = true;
            this.frm1LN.BackColor = System.Drawing.Color.Transparent;
            this.frm1LN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1LN.ForeColor = System.Drawing.Color.Black;
            this.frm1LN.Location = new System.Drawing.Point(74, 235);
            this.frm1LN.Name = "frm1LN";
            this.frm1LN.Size = new System.Drawing.Size(80, 18);
            this.frm1LN.TabIndex = 9;
            this.frm1LN.Text = "Last Name :";
            // 
            // frm1FN
            // 
            this.frm1FN.AutoSize = true;
            this.frm1FN.BackColor = System.Drawing.Color.Transparent;
            this.frm1FN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1FN.ForeColor = System.Drawing.Color.Black;
            this.frm1FN.Location = new System.Drawing.Point(245, 235);
            this.frm1FN.Name = "frm1FN";
            this.frm1FN.Size = new System.Drawing.Size(82, 18);
            this.frm1FN.TabIndex = 10;
            this.frm1FN.Text = "First Name :";
            // 
            // frm1MN
            // 
            this.frm1MN.AutoSize = true;
            this.frm1MN.BackColor = System.Drawing.Color.Transparent;
            this.frm1MN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1MN.ForeColor = System.Drawing.Color.Black;
            this.frm1MN.Location = new System.Drawing.Point(404, 235);
            this.frm1MN.Name = "frm1MN";
            this.frm1MN.Size = new System.Drawing.Size(99, 18);
            this.frm1MN.TabIndex = 11;
            this.frm1MN.Text = "Middle Name :";
            // 
            // frm1Age
            // 
            this.frm1Age.AutoSize = true;
            this.frm1Age.BackColor = System.Drawing.Color.Transparent;
            this.frm1Age.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1Age.ForeColor = System.Drawing.Color.Black;
            this.frm1Age.Location = new System.Drawing.Point(74, 290);
            this.frm1Age.Name = "frm1Age";
            this.frm1Age.Size = new System.Drawing.Size(40, 18);
            this.frm1Age.TabIndex = 12;
            this.frm1Age.Text = "Age :";
            this.frm1Age.Click += new System.EventHandler(this.label6_Click);
            // 
            // frm1ConNum
            // 
            this.frm1ConNum.AutoSize = true;
            this.frm1ConNum.BackColor = System.Drawing.Color.Transparent;
            this.frm1ConNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1ConNum.ForeColor = System.Drawing.Color.Black;
            this.frm1ConNum.Location = new System.Drawing.Point(143, 289);
            this.frm1ConNum.Name = "frm1ConNum";
            this.frm1ConNum.Size = new System.Drawing.Size(87, 18);
            this.frm1ConNum.TabIndex = 13;
            this.frm1ConNum.Text = "Contact No. :";
            // 
            // frm1Add
            // 
            this.frm1Add.AutoSize = true;
            this.frm1Add.BackColor = System.Drawing.Color.Transparent;
            this.frm1Add.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm1Add.ForeColor = System.Drawing.Color.Black;
            this.frm1Add.Location = new System.Drawing.Point(74, 389);
            this.frm1Add.Name = "frm1Add";
            this.frm1Add.Size = new System.Drawing.Size(65, 18);
            this.frm1Add.TabIndex = 14;
            this.frm1Add.Text = "Address :";
            this.frm1Add.Click += new System.EventHandler(this.label8_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.richTextBox1.Location = new System.Drawing.Point(77, 419);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 118);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Birthday :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender :";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(391, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 776);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.frm1Add);
            this.Controls.Add(this.frm1ConNum);
            this.Controls.Add(this.frm1Age);
            this.Controls.Add(this.frm1MN);
            this.Controls.Add(this.frm1FN);
            this.Controls.Add(this.frm1LN);
            this.Controls.Add(this.frm1Prog);
            this.Controls.Add(this.frm1StudNum);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label frm1StudNum;
        private System.Windows.Forms.Label frm1Prog;
        private System.Windows.Forms.Label frm1LN;
        private System.Windows.Forms.Label frm1FN;
        private System.Windows.Forms.Label frm1MN;
        private System.Windows.Forms.Label frm1Age;
        private System.Windows.Forms.Label frm1ConNum;
        private System.Windows.Forms.Label frm1Add;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

