namespace CashierWindowQueueForm
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierView = new ListView();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ScrollBar;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(39, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(84, 40);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ScrollBar;
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(39, 95);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(84, 37);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // listCashierView
            // 
            listCashierView.Location = new Point(164, 22);
            listCashierView.Name = "listCashierView";
            listCashierView.Size = new Size(194, 226);
            listCashierView.TabIndex = 2;
            listCashierView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 265);
            Controls.Add(listCashierView);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierView;
    }
}