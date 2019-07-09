namespace Tax_calculator_uk
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Per = new System.Windows.Forms.ComboBox();
            this.Gross = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Gross_income = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Net = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(497, 62);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(497, 124);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Per
            // 
            this.Per.FormattingEnabled = true;
            this.Per.Items.AddRange(new object[] {
            "Per month",
            "Per year"});
            this.Per.Location = new System.Drawing.Point(353, 61);
            this.Per.Name = "Per";
            this.Per.Size = new System.Drawing.Size(121, 24);
            this.Per.TabIndex = 2;
            this.Per.SelectedIndexChanged += new System.EventHandler(this.Per_SelectedIndexChanged);
            // 
            // Gross
            // 
            this.Gross.Location = new System.Drawing.Point(166, 63);
            this.Gross.Name = "Gross";
            this.Gross.Size = new System.Drawing.Size(128, 22);
            this.Gross.TabIndex = 3;
            this.Gross.TextChanged += new System.EventHandler(this.Gross_TextChanged);
            // 
            // Tax
            // 
            this.Tax.Location = new System.Drawing.Point(166, 124);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(128, 22);
            this.Tax.TabIndex = 4;
            // 
            // Gross_income
            // 
            this.Gross_income.AutoSize = true;
            this.Gross_income.Location = new System.Drawing.Point(57, 65);
            this.Gross_income.Name = "Gross_income";
            this.Gross_income.Size = new System.Drawing.Size(95, 17);
            this.Gross_income.TabIndex = 5;
            this.Gross_income.Text = "Gross income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Net amount ";
            // 
            // Net
            // 
            this.Net.Location = new System.Drawing.Point(166, 184);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(128, 22);
            this.Net.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "%";
            // 
            // Percentage
            // 
            this.Percentage.Location = new System.Drawing.Point(353, 124);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(66, 22);
            this.Percentage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 246);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gross_income);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Gross);
            this.Controls.Add(this.Per);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Tax_calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox Per;
        private System.Windows.Forms.TextBox Gross;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.Label Gross_income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Net;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Percentage;
    }
}

