namespace LabExer01_EventDriven
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.frm2StudNum = new System.Windows.Forms.Label();
            this.frm2Prog = new System.Windows.Forms.Label();
            this.frm2FN = new System.Windows.Forms.Label();
            this.frm2LN = new System.Windows.Forms.Label();
            this.frm2Age = new System.Windows.Forms.Label();
            this.frm2MN = new System.Windows.Forms.Label();
            this.frm2Add = new System.Windows.Forms.Label();
            this.frm2ConNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox1.Location = new System.Drawing.Point(130, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.maskedTextBox1.Location = new System.Drawing.Point(130, 34);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.maskedTextBox2.Location = new System.Drawing.Point(130, 138);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox2.Location = new System.Drawing.Point(130, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 2;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.maskedTextBox3.Location = new System.Drawing.Point(130, 251);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBox3.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox3.Location = new System.Drawing.Point(130, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 4;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.BurlyWood;
            this.maskedTextBox4.Location = new System.Drawing.Point(130, 361);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBox4.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox4.Location = new System.Drawing.Point(130, 414);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 20);
            this.textBox4.TabIndex = 6;
            // 
            // frm2StudNum
            // 
            this.frm2StudNum.AutoSize = true;
            this.frm2StudNum.BackColor = System.Drawing.Color.Transparent;
            this.frm2StudNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2StudNum.Location = new System.Drawing.Point(43, 37);
            this.frm2StudNum.Name = "frm2StudNum";
            this.frm2StudNum.Size = new System.Drawing.Size(91, 18);
            this.frm2StudNum.TabIndex = 8;
            this.frm2StudNum.Text = "Student No. : ";
            // 
            // frm2Prog
            // 
            this.frm2Prog.AutoSize = true;
            this.frm2Prog.BackColor = System.Drawing.Color.Transparent;
            this.frm2Prog.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2Prog.Location = new System.Drawing.Point(43, 82);
            this.frm2Prog.Name = "frm2Prog";
            this.frm2Prog.Size = new System.Drawing.Size(68, 18);
            this.frm2Prog.TabIndex = 9;
            this.frm2Prog.Text = "Program :";
            // 
            // frm2FN
            // 
            this.frm2FN.AutoSize = true;
            this.frm2FN.BackColor = System.Drawing.Color.Transparent;
            this.frm2FN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2FN.Location = new System.Drawing.Point(43, 194);
            this.frm2FN.Name = "frm2FN";
            this.frm2FN.Size = new System.Drawing.Size(82, 18);
            this.frm2FN.TabIndex = 11;
            this.frm2FN.Text = "First Name :";
            // 
            // frm2LN
            // 
            this.frm2LN.AutoSize = true;
            this.frm2LN.BackColor = System.Drawing.Color.Transparent;
            this.frm2LN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2LN.Location = new System.Drawing.Point(43, 138);
            this.frm2LN.Name = "frm2LN";
            this.frm2LN.Size = new System.Drawing.Size(83, 18);
            this.frm2LN.TabIndex = 10;
            this.frm2LN.Text = "Last Name : ";
            // 
            // frm2Age
            // 
            this.frm2Age.AutoSize = true;
            this.frm2Age.BackColor = System.Drawing.Color.Transparent;
            this.frm2Age.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2Age.Location = new System.Drawing.Point(43, 311);
            this.frm2Age.Name = "frm2Age";
            this.frm2Age.Size = new System.Drawing.Size(43, 18);
            this.frm2Age.TabIndex = 13;
            this.frm2Age.Text = "Age : ";
            // 
            // frm2MN
            // 
            this.frm2MN.AutoSize = true;
            this.frm2MN.BackColor = System.Drawing.Color.Transparent;
            this.frm2MN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2MN.Location = new System.Drawing.Point(25, 253);
            this.frm2MN.Name = "frm2MN";
            this.frm2MN.Size = new System.Drawing.Size(99, 18);
            this.frm2MN.TabIndex = 12;
            this.frm2MN.Text = "Middle Name :";
            // 
            // frm2Add
            // 
            this.frm2Add.AutoSize = true;
            this.frm2Add.BackColor = System.Drawing.Color.Transparent;
            this.frm2Add.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2Add.Location = new System.Drawing.Point(43, 414);
            this.frm2Add.Name = "frm2Add";
            this.frm2Add.Size = new System.Drawing.Size(68, 18);
            this.frm2Add.TabIndex = 15;
            this.frm2Add.Text = "Address : ";
            // 
            // frm2ConNum
            // 
            this.frm2ConNum.AutoSize = true;
            this.frm2ConNum.BackColor = System.Drawing.Color.Transparent;
            this.frm2ConNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2ConNum.Location = new System.Drawing.Point(43, 363);
            this.frm2ConNum.Name = "frm2ConNum";
            this.frm2ConNum.Size = new System.Drawing.Size(87, 18);
            this.frm2ConNum.TabIndex = 14;
            this.frm2ConNum.Text = "Contact No. :";
            this.frm2ConNum.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(385, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 256);
            this.button1.TabIndex = 16;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frm2Add);
            this.Controls.Add(this.frm2ConNum);
            this.Controls.Add(this.frm2Age);
            this.Controls.Add(this.frm2MN);
            this.Controls.Add(this.frm2FN);
            this.Controls.Add(this.frm2LN);
            this.Controls.Add(this.frm2Prog);
            this.Controls.Add(this.frm2StudNum);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label frm2StudNum;
        private System.Windows.Forms.Label frm2Prog;
        private System.Windows.Forms.Label frm2FN;
        private System.Windows.Forms.Label frm2LN;
        private System.Windows.Forms.Label frm2Age;
        private System.Windows.Forms.Label frm2MN;
        private System.Windows.Forms.Label frm2Add;
        private System.Windows.Forms.Label frm2ConNum;
        private System.Windows.Forms.Button button1;
    }
}