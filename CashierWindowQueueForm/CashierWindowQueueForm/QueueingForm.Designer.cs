namespace CashierWindowQueueForm
{
    partial class QueueingForm
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
            button1 = new Button();
            btnCashier = new Button();
            labells = new Label();
            lblQueue = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(511, 118);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashier.Location = new Point(35, 44);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(139, 106);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += button2_Click;
            // 
            // labells
            // 
            labells.AutoSize = true;
            labells.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labells.Location = new Point(287, 64);
            labells.Name = "labells";
            labells.Size = new Size(180, 30);
            labells.TabIndex = 2;
            labells.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(193, 122);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(356, 75);
            lblQueue.TabIndex = 3;
            lblQueue.Text = "P - 100007";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(39, 183);
            label2.Name = "label2";
            label2.Size = new Size(135, 14);
            label2.TabIndex = 4;
            label2.Text = "*Click to get a number";
            // 
            // QueueingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 265);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(labells);
            Controls.Add(btnCashier);
            Controls.Add(button1);
            Name = "QueueingForm";
            Text = "QueueingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCashier;
        private Label labells;
        private Label lblQueue;
        private Label label2;
    }
}