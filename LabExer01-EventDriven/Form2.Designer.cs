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
            this.studnum = new System.Windows.Forms.MaskedTextBox();
            this.FullName = new System.Windows.Forms.MaskedTextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.contactnum = new System.Windows.Forms.MaskedTextBox();
            this.frm2StudNum = new System.Windows.Forms.Label();
            this.frm2Prog = new System.Windows.Forms.Label();
            this.frm2LN = new System.Windows.Forms.Label();
            this.frm2Age = new System.Windows.Forms.Label();
            this.frm2ConNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.MaskedTextBox();
            this.gender = new System.Windows.Forms.TextBox();
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
            // studnum
            // 
            this.studnum.BackColor = System.Drawing.Color.BurlyWood;
            this.studnum.Location = new System.Drawing.Point(130, 34);
            this.studnum.Name = "studnum";
            this.studnum.Size = new System.Drawing.Size(222, 20);
            this.studnum.TabIndex = 1;
            this.studnum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.Color.BurlyWood;
            this.FullName.Location = new System.Drawing.Point(130, 138);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(222, 20);
            this.FullName.TabIndex = 3;
            this.FullName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.BurlyWood;
            this.age.Location = new System.Drawing.Point(130, 301);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(222, 20);
            this.age.TabIndex = 4;
            // 
            // contactnum
            // 
            this.contactnum.BackColor = System.Drawing.Color.BurlyWood;
            this.contactnum.Location = new System.Drawing.Point(130, 353);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(222, 20);
            this.contactnum.TabIndex = 7;
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
            // frm2LN
            // 
            this.frm2LN.AutoSize = true;
            this.frm2LN.BackColor = System.Drawing.Color.Transparent;
            this.frm2LN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2LN.Location = new System.Drawing.Point(43, 138);
            this.frm2LN.Name = "frm2LN";
            this.frm2LN.Size = new System.Drawing.Size(82, 18);
            this.frm2LN.TabIndex = 10;
            this.frm2LN.Text = "Full Name : ";
            // 
            // frm2Age
            // 
            this.frm2Age.AutoSize = true;
            this.frm2Age.BackColor = System.Drawing.Color.Transparent;
            this.frm2Age.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2Age.Location = new System.Drawing.Point(43, 303);
            this.frm2Age.Name = "frm2Age";
            this.frm2Age.Size = new System.Drawing.Size(43, 18);
            this.frm2Age.TabIndex = 13;
            this.frm2Age.Text = "Age : ";
            // 
            // frm2ConNum
            // 
            this.frm2ConNum.AutoSize = true;
            this.frm2ConNum.BackColor = System.Drawing.Color.Transparent;
            this.frm2ConNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm2ConNum.Location = new System.Drawing.Point(43, 355);
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
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(130, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 78);
            this.button1.TabIndex = 16;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Birthday :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gender :";
            // 
            // bday
            // 
            this.bday.BackColor = System.Drawing.Color.BurlyWood;
            this.bday.Location = new System.Drawing.Point(130, 251);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(222, 20);
            this.bday.TabIndex = 18;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.BurlyWood;
            this.gender.Location = new System.Drawing.Point(130, 192);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(222, 20);
            this.gender.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frm2ConNum);
            this.Controls.Add(this.frm2Age);
            this.Controls.Add(this.frm2LN);
            this.Controls.Add(this.frm2Prog);
            this.Controls.Add(this.frm2StudNum);
            this.Controls.Add(this.contactnum);
            this.Controls.Add(this.age);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.studnum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox studnum;
        private System.Windows.Forms.MaskedTextBox FullName;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.MaskedTextBox contactnum;
        private System.Windows.Forms.Label frm2StudNum;
        private System.Windows.Forms.Label frm2Prog;
        private System.Windows.Forms.Label frm2LN;
        private System.Windows.Forms.Label frm2Age;
        private System.Windows.Forms.Label frm2ConNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox bday;
        private System.Windows.Forms.TextBox gender;
    }
}