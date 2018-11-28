namespace diabetes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.weight_txt = new System.Windows.Forms.TextBox();
            this.year_income = new System.Windows.Forms.ComboBox();
            this.year_income_label = new System.Windows.Forms.Label();
            this.month_exp_label = new System.Windows.Forms.Label();
            this.month_exp_txt = new System.Windows.Forms.TextBox();
            this.monthly_exp_explain = new System.Windows.Forms.Label();
            this.insurance_label = new System.Windows.Forms.Label();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(37, 51);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(58, 23);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.Color.White;
            this.age_label.Location = new System.Drawing.Point(37, 91);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(46, 23);
            this.age_label.TabIndex = 1;
            this.age_label.Text = "Age";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_label.ForeColor = System.Drawing.Color.White;
            this.weight_label.Location = new System.Drawing.Point(37, 130);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(154, 23);
            this.weight_label.TabIndex = 2;
            this.weight_label.Text = "Weight (lbs)";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(207, 52);
            this.name_txt.MaxLength = 50;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(198, 22);
            this.name_txt.TabIndex = 3;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(207, 92);
            this.age_txt.MaxLength = 3;
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(55, 22);
            this.age_txt.TabIndex = 4;
            // 
            // weight_txt
            // 
            this.weight_txt.Location = new System.Drawing.Point(207, 130);
            this.weight_txt.MaxLength = 3;
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(55, 22);
            this.weight_txt.TabIndex = 5;
            // 
            // year_income
            // 
            this.year_income.FormattingEnabled = true;
            this.year_income.Items.AddRange(new object[] {
            "Less than $25,000",
            "$25,000 - $34,999",
            "$35,000 - $49,999",
            "$50,000 - $74,999",
            "$75,000 - $99,999",
            "$100,000 - $149,999",
            "$150,000 or more"});
            this.year_income.Location = new System.Drawing.Point(287, 209);
            this.year_income.Name = "year_income";
            this.year_income.Size = new System.Drawing.Size(198, 24);
            this.year_income.TabIndex = 6;
            // 
            // year_income_label
            // 
            this.year_income_label.AutoSize = true;
            this.year_income_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_income_label.ForeColor = System.Drawing.Color.White;
            this.year_income_label.Location = new System.Drawing.Point(37, 208);
            this.year_income_label.Name = "year_income_label";
            this.year_income_label.Size = new System.Drawing.Size(166, 23);
            this.year_income_label.TabIndex = 7;
            this.year_income_label.Text = "Yearly Income";
            this.year_income_label.Click += new System.EventHandler(this.year_income_label_Click);
            // 
            // month_exp_label
            // 
            this.month_exp_label.AutoSize = true;
            this.month_exp_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_exp_label.ForeColor = System.Drawing.Color.White;
            this.month_exp_label.Location = new System.Drawing.Point(37, 255);
            this.month_exp_label.Name = "month_exp_label";
            this.month_exp_label.Size = new System.Drawing.Size(214, 23);
            this.month_exp_label.TabIndex = 8;
            this.month_exp_label.Text = "Monthly Expenses*";
            // 
            // month_exp_txt
            // 
            this.month_exp_txt.Location = new System.Drawing.Point(287, 255);
            this.month_exp_txt.MaxLength = 5;
            this.month_exp_txt.Name = "month_exp_txt";
            this.month_exp_txt.Size = new System.Drawing.Size(198, 22);
            this.month_exp_txt.TabIndex = 9;
            // 
            // monthly_exp_explain
            // 
            this.monthly_exp_explain.AutoSize = true;
            this.monthly_exp_explain.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly_exp_explain.ForeColor = System.Drawing.Color.White;
            this.monthly_exp_explain.Location = new System.Drawing.Point(38, 534);
            this.monthly_exp_explain.Name = "monthly_exp_explain";
            this.monthly_exp_explain.Size = new System.Drawing.Size(503, 54);
            this.monthly_exp_explain.TabIndex = 10;
            this.monthly_exp_explain.Text = "* Include monthly bills such as: \r\ncar payments/insurance, price of health insura" +
    "nce, etc.\r\nDO NOT include: Groceries";
            // 
            // insurance_label
            // 
            this.insurance_label.AutoSize = true;
            this.insurance_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurance_label.ForeColor = System.Drawing.Color.White;
            this.insurance_label.Location = new System.Drawing.Point(37, 311);
            this.insurance_label.Name = "insurance_label";
            this.insurance_label.Size = new System.Drawing.Size(358, 23);
            this.insurance_label.TabIndex = 11;
            this.insurance_label.Text = "Do you have health insurance?";
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_yes.ForeColor = System.Drawing.Color.White;
            this.rb_yes.Location = new System.Drawing.Point(41, 352);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(67, 27);
            this.rb_yes.TabIndex = 12;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "Yes";
            this.rb_yes.UseVisualStyleBackColor = true;
            this.rb_yes.Click += new System.EventHandler(this.rb_yes_Click);
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_no.ForeColor = System.Drawing.Color.White;
            this.rb_no.Location = new System.Drawing.Point(41, 379);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(55, 27);
            this.rb_no.TabIndex = 13;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(180, 463);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(195, 40);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(576, 607);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.rb_yes);
            this.Controls.Add(this.insurance_label);
            this.Controls.Add(this.monthly_exp_explain);
            this.Controls.Add(this.month_exp_txt);
            this.Controls.Add(this.month_exp_label);
            this.Controls.Add(this.year_income_label);
            this.Controls.Add(this.year_income);
            this.Controls.Add(this.weight_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Demographics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox weight_txt;
        private System.Windows.Forms.ComboBox year_income;
        private System.Windows.Forms.Label year_income_label;
        private System.Windows.Forms.Label month_exp_label;
        private System.Windows.Forms.TextBox month_exp_txt;
        private System.Windows.Forms.Label monthly_exp_explain;
        private System.Windows.Forms.Label insurance_label;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Timer timer1;
    }
}

