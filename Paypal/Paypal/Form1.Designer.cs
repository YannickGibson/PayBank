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
            this.basicAccountLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.basicAccountPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentsAccountLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.creditAccountLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.basicAccountPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(17, 13);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date: ";
            // 
            // dayTimer
            // 
            this.dayTimer.Enabled = true;
            this.dayTimer.Interval = 1000;
            this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
            // 
            // basicAccountLabel
            // 
            this.basicAccountLabel.AutoSize = true;
            this.basicAccountLabel.Location = new System.Drawing.Point(78, 49);
            this.basicAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.basicAccountLabel.Name = "basicAccountLabel";
            this.basicAccountLabel.Size = new System.Drawing.Size(97, 20);
            this.basicAccountLabel.TabIndex = 0;
            this.basicAccountLabel.Text = "BasicAccount";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.bottomPanel.Controls.Add(this.dateLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 560);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1140, 40);
            this.bottomPanel.TabIndex = 1;
            // 
            // basicAccountPanel
            // 
            this.basicAccountPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.basicAccountPanel.Controls.Add(this.basicAccountLabel);
            this.basicAccountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.basicAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.basicAccountPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basicAccountPanel.Name = "basicAccountPanel";
            this.basicAccountPanel.Size = new System.Drawing.Size(240, 560);
            this.basicAccountPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.studentsAccountLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 560);
            this.panel1.TabIndex = 2;
            // 
            // studentsAccountLabel
            // 
            this.studentsAccountLabel.AutoSize = true;
            this.studentsAccountLabel.Location = new System.Drawing.Point(255, 49);
            this.studentsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentsAccountLabel.Name = "studentsAccountLabel";
            this.studentsAccountLabel.Size = new System.Drawing.Size(120, 20);
            this.studentsAccountLabel.TabIndex = 0;
            this.studentsAccountLabel.Text = "StudentsAccount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.creditAccountLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 560);
            this.panel2.TabIndex = 2;
            // 
            // creditAccountLabel
            // 
            this.creditAccountLabel.AutoSize = true;
            this.creditAccountLabel.Location = new System.Drawing.Point(66, 49);
            this.creditAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditAccountLabel.Name = "creditAccountLabel";
            this.creditAccountLabel.Size = new System.Drawing.Size(103, 20);
            this.creditAccountLabel.TabIndex = 0;
            this.creditAccountLabel.Text = "CreditAccount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Label basicAccountLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel basicAccountPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label studentsAccountLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label creditAccountLabel;
    }
}

