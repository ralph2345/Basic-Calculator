namespace BasicCalculator
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
            this.numOneTextbox = new System.Windows.Forms.TextBox();
            this.numTwoTextBox = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.computeBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOneTextbox
            // 
            this.numOneTextbox.Location = new System.Drawing.Point(99, 80);
            this.numOneTextbox.Name = "numOneTextbox";
            this.numOneTextbox.Size = new System.Drawing.Size(169, 20);
            this.numOneTextbox.TabIndex = 0;
            // 
            // numTwoTextBox
            // 
            this.numTwoTextBox.Location = new System.Drawing.Point(99, 154);
            this.numTwoTextBox.Name = "numTwoTextBox";
            this.numTwoTextBox.Size = new System.Drawing.Size(169, 20);
            this.numTwoTextBox.TabIndex = 1;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(130, 116);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(110, 21);
            this.cbOperator.TabIndex = 2;
            // 
            // computeBtn
            // 
            this.computeBtn.BackColor = System.Drawing.Color.Coral;
            this.computeBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.computeBtn.Location = new System.Drawing.Point(121, 281);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(119, 37);
            this.computeBtn.TabIndex = 3;
            this.computeBtn.Text = "Compute";
            this.computeBtn.UseVisualStyleBackColor = false;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(72, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(82, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(82, 231);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 25);
            this.totalLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 330);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.numTwoTextBox);
            this.Controls.Add(this.numOneTextbox);
            this.Name = "Form1";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOneTextbox;
        private System.Windows.Forms.TextBox numTwoTextBox;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
    }
}

