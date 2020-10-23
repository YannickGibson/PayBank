namespace Paypal
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
            this.components = new System.ComponentModel.Container();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayTimer = new System.Windows.Forms.Timer(this.components);
            this.savingsAccountLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.basicAccountPanel = new System.Windows.Forms.Panel();
            this.savingsAccountBalanceLabel = new System.Windows.Forms.Label();
            this.studentsAccountPanel = new System.Windows.Forms.Panel();
            this.studentsSavingsAccountBalanceLabel = new System.Windows.Forms.Label();
            this.studentsSavingsAccountLabel = new System.Windows.Forms.Label();
            this.creditAccountPanel = new System.Windows.Forms.Panel();
            this.creditAccountBalanceLabel = new System.Windows.Forms.Label();
            this.creditAccountLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.basicAccountPanel.SuspendLayout();
            this.studentsAccountPanel.SuspendLayout();
            this.creditAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(4, 11);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date: ";
            // 
            // dayTimer
            // 
            this.dayTimer.Enabled = true;
            this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
            // 
            // savingsAccountLabel
            // 
            this.savingsAccountLabel.AutoSize = true;
            this.savingsAccountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountLabel.Location = new System.Drawing.Point(4, 9);
            this.savingsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsAccountLabel.Name = "savingsAccountLabel";
            this.savingsAccountLabel.Size = new System.Drawing.Size(191, 31);
            this.savingsAccountLabel.TabIndex = 0;
            this.savingsAccountLabel.Text = "Savings Account";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.bottomPanel.Controls.Add(this.dateLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 560);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1140, 40);
            this.bottomPanel.TabIndex = 1;
            // 
            // basicAccountPanel
            // 
            this.basicAccountPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.basicAccountPanel.Controls.Add(this.savingsAccountBalanceLabel);
            this.basicAccountPanel.Controls.Add(this.savingsAccountLabel);
            this.basicAccountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.basicAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.basicAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.basicAccountPanel.Name = "basicAccountPanel";
            this.basicAccountPanel.Size = new System.Drawing.Size(380, 560);
            this.basicAccountPanel.TabIndex = 2;
            // 
            // savingsAccountBalanceLabel
            // 
            this.savingsAccountBalanceLabel.AutoSize = true;
            this.savingsAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.savingsAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsAccountBalanceLabel.Name = "savingsAccountBalanceLabel";
            this.savingsAccountBalanceLabel.Size = new System.Drawing.Size(82, 28);
            this.savingsAccountBalanceLabel.TabIndex = 0;
            this.savingsAccountBalanceLabel.Text = "Balance:";
            // 
            // studentsAccountPanel
            // 
            this.studentsAccountPanel.BackColor = System.Drawing.Color.LightBlue;
            this.studentsAccountPanel.Controls.Add(this.studentsSavingsAccountBalanceLabel);
            this.studentsAccountPanel.Controls.Add(this.studentsSavingsAccountLabel);
            this.studentsAccountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsAccountPanel.Location = new System.Drawing.Point(380, 0);
            this.studentsAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.studentsAccountPanel.Name = "studentsAccountPanel";
            this.studentsAccountPanel.Size = new System.Drawing.Size(760, 560);
            this.studentsAccountPanel.TabIndex = 2;
            // 
            // studentsSavingsAccountBalanceLabel
            // 
            this.studentsSavingsAccountBalanceLabel.AutoSize = true;
            this.studentsSavingsAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsSavingsAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.studentsSavingsAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentsSavingsAccountBalanceLabel.Name = "studentsSavingsAccountBalanceLabel";
            this.studentsSavingsAccountBalanceLabel.Size = new System.Drawing.Size(87, 28);
            this.studentsSavingsAccountBalanceLabel.TabIndex = 0;
            this.studentsSavingsAccountBalanceLabel.Text = "Balance: ";
            // 
            // studentsSavingsAccountLabel
            // 
            this.studentsSavingsAccountLabel.AutoSize = true;
            this.studentsSavingsAccountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentsSavingsAccountLabel.Location = new System.Drawing.Point(4, 9);
            this.studentsSavingsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentsSavingsAccountLabel.Name = "studentsSavingsAccountLabel";
            this.studentsSavingsAccountLabel.Size = new System.Drawing.Size(291, 31);
            this.studentsSavingsAccountLabel.TabIndex = 0;
            this.studentsSavingsAccountLabel.Text = "Students Savings Account";
            // 
            // creditAccountPanel
            // 
            this.creditAccountPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.creditAccountPanel.Controls.Add(this.creditAccountBalanceLabel);
            this.creditAccountPanel.Controls.Add(this.creditAccountLabel);
            this.creditAccountPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.creditAccountPanel.Location = new System.Drawing.Point(760, 0);
            this.creditAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.creditAccountPanel.Name = "creditAccountPanel";
            this.creditAccountPanel.Size = new System.Drawing.Size(380, 560);
            this.creditAccountPanel.TabIndex = 2;
            // 
            // creditAccountBalanceLabel
            // 
            this.creditAccountBalanceLabel.AutoSize = true;
            this.creditAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.creditAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditAccountBalanceLabel.Name = "creditAccountBalanceLabel";
            this.creditAccountBalanceLabel.Size = new System.Drawing.Size(87, 28);
            this.creditAccountBalanceLabel.TabIndex = 0;
            this.creditAccountBalanceLabel.Text = "Balance: ";
            // 
            // creditAccountLabel
            // 
            this.creditAccountLabel.AutoSize = true;
            this.creditAccountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditAccountLabel.Location = new System.Drawing.Point(4, 9);
            this.creditAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditAccountLabel.Name = "creditAccountLabel";
            this.creditAccountLabel.Size = new System.Drawing.Size(174, 31);
            this.creditAccountLabel.TabIndex = 0;
            this.creditAccountLabel.Text = "Credit Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.creditAccountPanel);
            this.Controls.Add(this.studentsAccountPanel);
            this.Controls.Add(this.basicAccountPanel);
            this.Controls.Add(this.bottomPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "PayBank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.basicAccountPanel.ResumeLayout(false);
            this.basicAccountPanel.PerformLayout();
            this.studentsAccountPanel.ResumeLayout(false);
            this.studentsAccountPanel.PerformLayout();
            this.creditAccountPanel.ResumeLayout(false);
            this.creditAccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Label savingsAccountLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel basicAccountPanel;
        private System.Windows.Forms.Panel studentsAccountPanel;
        private System.Windows.Forms.Label studentsSavingsAccountLabel;
        private System.Windows.Forms.Panel creditAccountPanel;
        private System.Windows.Forms.Label creditAccountLabel;
        private System.Windows.Forms.Label savingsAccountBalanceLabel;
        private System.Windows.Forms.Label studentsSavingsAccountBalanceLabel;
        private System.Windows.Forms.Label creditAccountBalanceLabel;
    }
}

