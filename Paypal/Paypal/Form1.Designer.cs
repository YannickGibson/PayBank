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
            this.stopTimeButton = new System.Windows.Forms.Button();
            this.basicAccountPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.savingsAccountDepositNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.savingsAccountDepositButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.savingsAccountWithdrawNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.savingsAccountWithdrawButton = new System.Windows.Forms.Button();
            this.savingsAccountMonthlyInterest = new System.Windows.Forms.Label();
            this.savingsAccountBalanceLabel = new System.Windows.Forms.Label();
            this.studentsAccountPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.studentSavingsAccountDepositNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentSavingsAccountDepositButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentSavingsAccountWithdrawNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentSavingsAccountWithdrawButton = new System.Windows.Forms.Button();
            this.studentSavingsAccountMonthlyInterest = new System.Windows.Forms.Label();
            this.studentSavingsAccountBalanceLabel = new System.Windows.Forms.Label();
            this.studentSavingsAccountLabel = new System.Windows.Forms.Label();
            this.creditAccountPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.creditAccountDepositNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.creditAccountDepositButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.creditAccountWithdrawNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.creditAccountWithdrawButton = new System.Windows.Forms.Button();
            this.creditAccountMonthlyInterest = new System.Windows.Forms.Label();
            this.creditAccountBalanceLabel = new System.Windows.Forms.Label();
            this.creditAccountLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.basicAccountPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savingsAccountDepositNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savingsAccountWithdrawNumericUpDown)).BeginInit();
            this.studentsAccountPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentSavingsAccountDepositNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentSavingsAccountWithdrawNumericUpDown)).BeginInit();
            this.creditAccountPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountDepositNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountWithdrawNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(4, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(95, 41);
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
            this.bottomPanel.Controls.Add(this.stopTimeButton);
            this.bottomPanel.Controls.Add(this.dateLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 253);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1140, 59);
            this.bottomPanel.TabIndex = 1;
            // 
            // stopTimeButton
            // 
            this.stopTimeButton.BackColor = System.Drawing.Color.Thistle;
            this.stopTimeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.stopTimeButton.Location = new System.Drawing.Point(999, 0);
            this.stopTimeButton.Name = "stopTimeButton";
            this.stopTimeButton.Size = new System.Drawing.Size(141, 59);
            this.stopTimeButton.TabIndex = 1;
            this.stopTimeButton.Text = "Stop Time";
            this.stopTimeButton.UseVisualStyleBackColor = false;
            this.stopTimeButton.Click += new System.EventHandler(this.stopTimeButton_Click);
            // 
            // basicAccountPanel
            // 
            this.basicAccountPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.basicAccountPanel.Controls.Add(this.panel4);
            this.basicAccountPanel.Controls.Add(this.panel1);
            this.basicAccountPanel.Controls.Add(this.savingsAccountMonthlyInterest);
            this.basicAccountPanel.Controls.Add(this.savingsAccountBalanceLabel);
            this.basicAccountPanel.Controls.Add(this.savingsAccountLabel);
            this.basicAccountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.basicAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.basicAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.basicAccountPanel.Name = "basicAccountPanel";
            this.basicAccountPanel.Size = new System.Drawing.Size(380, 253);
            this.basicAccountPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.savingsAccountDepositNumericUpDown);
            this.panel4.Controls.Add(this.savingsAccountDepositButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 47);
            this.panel4.TabIndex = 2;
            // 
            // savingsAccountDepositNumericUpDown
            // 
            this.savingsAccountDepositNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.savingsAccountDepositNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountDepositNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.savingsAccountDepositNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.savingsAccountDepositNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.savingsAccountDepositNumericUpDown.Name = "savingsAccountDepositNumericUpDown";
            this.savingsAccountDepositNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.savingsAccountDepositNumericUpDown.TabIndex = 2;
            this.savingsAccountDepositNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savingsAccountDepositNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // savingsAccountDepositButton
            // 
            this.savingsAccountDepositButton.BackColor = System.Drawing.Color.LightGreen;
            this.savingsAccountDepositButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.savingsAccountDepositButton.Location = new System.Drawing.Point(209, 0);
            this.savingsAccountDepositButton.Name = "savingsAccountDepositButton";
            this.savingsAccountDepositButton.Size = new System.Drawing.Size(171, 47);
            this.savingsAccountDepositButton.TabIndex = 1;
            this.savingsAccountDepositButton.Text = "Deposit";
            this.savingsAccountDepositButton.UseVisualStyleBackColor = false;
            this.savingsAccountDepositButton.Click += new System.EventHandler(this.savingsAccountDepositButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.savingsAccountWithdrawNumericUpDown);
            this.panel1.Controls.Add(this.savingsAccountWithdrawButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 47);
            this.panel1.TabIndex = 2;
            // 
            // savingsAccountWithdrawNumericUpDown
            // 
            this.savingsAccountWithdrawNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.savingsAccountWithdrawNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountWithdrawNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.savingsAccountWithdrawNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.savingsAccountWithdrawNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.savingsAccountWithdrawNumericUpDown.Name = "savingsAccountWithdrawNumericUpDown";
            this.savingsAccountWithdrawNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.savingsAccountWithdrawNumericUpDown.TabIndex = 2;
            this.savingsAccountWithdrawNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savingsAccountWithdrawNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // savingsAccountWithdrawButton
            // 
            this.savingsAccountWithdrawButton.BackColor = System.Drawing.Color.LightCoral;
            this.savingsAccountWithdrawButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.savingsAccountWithdrawButton.Location = new System.Drawing.Point(209, 0);
            this.savingsAccountWithdrawButton.Name = "savingsAccountWithdrawButton";
            this.savingsAccountWithdrawButton.Size = new System.Drawing.Size(171, 47);
            this.savingsAccountWithdrawButton.TabIndex = 1;
            this.savingsAccountWithdrawButton.Text = "Withdraw";
            this.savingsAccountWithdrawButton.UseVisualStyleBackColor = false;
            this.savingsAccountWithdrawButton.Click += new System.EventHandler(this.savingsAccountWithdrawButton_Click);
            // 
            // savingsAccountMonthlyInterest
            // 
            this.savingsAccountMonthlyInterest.AutoSize = true;
            this.savingsAccountMonthlyInterest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountMonthlyInterest.ForeColor = System.Drawing.Color.ForestGreen;
            this.savingsAccountMonthlyInterest.Location = new System.Drawing.Point(9, 90);
            this.savingsAccountMonthlyInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsAccountMonthlyInterest.Name = "savingsAccountMonthlyInterest";
            this.savingsAccountMonthlyInterest.Size = new System.Drawing.Size(87, 41);
            this.savingsAccountMonthlyInterest.TabIndex = 0;
            this.savingsAccountMonthlyInterest.Text = " + 10";
            // 
            // savingsAccountBalanceLabel
            // 
            this.savingsAccountBalanceLabel.AutoSize = true;
            this.savingsAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.savingsAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsAccountBalanceLabel.Name = "savingsAccountBalanceLabel";
            this.savingsAccountBalanceLabel.Size = new System.Drawing.Size(126, 41);
            this.savingsAccountBalanceLabel.TabIndex = 0;
            this.savingsAccountBalanceLabel.Text = "Balance:";
            // 
            // studentsAccountPanel
            // 
            this.studentsAccountPanel.BackColor = System.Drawing.Color.LightBlue;
            this.studentsAccountPanel.Controls.Add(this.panel5);
            this.studentsAccountPanel.Controls.Add(this.panel2);
            this.studentsAccountPanel.Controls.Add(this.studentSavingsAccountMonthlyInterest);
            this.studentsAccountPanel.Controls.Add(this.studentSavingsAccountBalanceLabel);
            this.studentsAccountPanel.Controls.Add(this.studentSavingsAccountLabel);
            this.studentsAccountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentsAccountPanel.Location = new System.Drawing.Point(380, 0);
            this.studentsAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.studentsAccountPanel.Name = "studentsAccountPanel";
            this.studentsAccountPanel.Size = new System.Drawing.Size(380, 253);
            this.studentsAccountPanel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.studentSavingsAccountDepositNumericUpDown);
            this.panel5.Controls.Add(this.studentSavingsAccountDepositButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 47);
            this.panel5.TabIndex = 2;
            // 
            // studentSavingsAccountDepositNumericUpDown
            // 
            this.studentSavingsAccountDepositNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentSavingsAccountDepositNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentSavingsAccountDepositNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.studentSavingsAccountDepositNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.studentSavingsAccountDepositNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.studentSavingsAccountDepositNumericUpDown.Name = "studentSavingsAccountDepositNumericUpDown";
            this.studentSavingsAccountDepositNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.studentSavingsAccountDepositNumericUpDown.TabIndex = 2;
            this.studentSavingsAccountDepositNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentSavingsAccountDepositNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // studentSavingsAccountDepositButton
            // 
            this.studentSavingsAccountDepositButton.BackColor = System.Drawing.Color.LightGreen;
            this.studentSavingsAccountDepositButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentSavingsAccountDepositButton.Location = new System.Drawing.Point(209, 0);
            this.studentSavingsAccountDepositButton.Name = "studentSavingsAccountDepositButton";
            this.studentSavingsAccountDepositButton.Size = new System.Drawing.Size(171, 47);
            this.studentSavingsAccountDepositButton.TabIndex = 1;
            this.studentSavingsAccountDepositButton.Text = "Deposit";
            this.studentSavingsAccountDepositButton.UseVisualStyleBackColor = false;
            this.studentSavingsAccountDepositButton.Click += new System.EventHandler(this.savingsAccountDepositButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentSavingsAccountWithdrawNumericUpDown);
            this.panel2.Controls.Add(this.studentSavingsAccountWithdrawButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 47);
            this.panel2.TabIndex = 2;
            // 
            // studentSavingsAccountWithdrawNumericUpDown
            // 
            this.studentSavingsAccountWithdrawNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentSavingsAccountWithdrawNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentSavingsAccountWithdrawNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.studentSavingsAccountWithdrawNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.studentSavingsAccountWithdrawNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.studentSavingsAccountWithdrawNumericUpDown.Name = "studentSavingsAccountWithdrawNumericUpDown";
            this.studentSavingsAccountWithdrawNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.studentSavingsAccountWithdrawNumericUpDown.TabIndex = 2;
            this.studentSavingsAccountWithdrawNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentSavingsAccountWithdrawNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // studentSavingsAccountWithdrawButton
            // 
            this.studentSavingsAccountWithdrawButton.BackColor = System.Drawing.Color.LightCoral;
            this.studentSavingsAccountWithdrawButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentSavingsAccountWithdrawButton.Location = new System.Drawing.Point(209, 0);
            this.studentSavingsAccountWithdrawButton.Name = "studentSavingsAccountWithdrawButton";
            this.studentSavingsAccountWithdrawButton.Size = new System.Drawing.Size(171, 47);
            this.studentSavingsAccountWithdrawButton.TabIndex = 1;
            this.studentSavingsAccountWithdrawButton.Text = "Withdraw";
            this.studentSavingsAccountWithdrawButton.UseVisualStyleBackColor = false;
            this.studentSavingsAccountWithdrawButton.Click += new System.EventHandler(this.savingsAccountWithdrawButton_Click);
            // 
            // studentSavingsAccountMonthlyInterest
            // 
            this.studentSavingsAccountMonthlyInterest.AutoSize = true;
            this.studentSavingsAccountMonthlyInterest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentSavingsAccountMonthlyInterest.ForeColor = System.Drawing.Color.ForestGreen;
            this.studentSavingsAccountMonthlyInterest.Location = new System.Drawing.Point(9, 90);
            this.studentSavingsAccountMonthlyInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentSavingsAccountMonthlyInterest.Name = "studentSavingsAccountMonthlyInterest";
            this.studentSavingsAccountMonthlyInterest.Size = new System.Drawing.Size(79, 41);
            this.studentSavingsAccountMonthlyInterest.TabIndex = 0;
            this.studentSavingsAccountMonthlyInterest.Text = "+ 10";
            // 
            // studentSavingsAccountBalanceLabel
            // 
            this.studentSavingsAccountBalanceLabel.AutoSize = true;
            this.studentSavingsAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentSavingsAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.studentSavingsAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentSavingsAccountBalanceLabel.Name = "studentSavingsAccountBalanceLabel";
            this.studentSavingsAccountBalanceLabel.Size = new System.Drawing.Size(134, 41);
            this.studentSavingsAccountBalanceLabel.TabIndex = 0;
            this.studentSavingsAccountBalanceLabel.Text = "Balance: ";
            // 
            // studentSavingsAccountLabel
            // 
            this.studentSavingsAccountLabel.AutoSize = true;
            this.studentSavingsAccountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentSavingsAccountLabel.Location = new System.Drawing.Point(4, 9);
            this.studentSavingsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentSavingsAccountLabel.Name = "studentSavingsAccountLabel";
            this.studentSavingsAccountLabel.Size = new System.Drawing.Size(281, 31);
            this.studentSavingsAccountLabel.TabIndex = 0;
            this.studentSavingsAccountLabel.Text = "Student Savings Account";
            // 
            // creditAccountPanel
            // 
            this.creditAccountPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.creditAccountPanel.Controls.Add(this.panel6);
            this.creditAccountPanel.Controls.Add(this.panel3);
            this.creditAccountPanel.Controls.Add(this.creditAccountMonthlyInterest);
            this.creditAccountPanel.Controls.Add(this.creditAccountBalanceLabel);
            this.creditAccountPanel.Controls.Add(this.creditAccountLabel);
            this.creditAccountPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.creditAccountPanel.Location = new System.Drawing.Point(760, 0);
            this.creditAccountPanel.Margin = new System.Windows.Forms.Padding(2);
            this.creditAccountPanel.Name = "creditAccountPanel";
            this.creditAccountPanel.Size = new System.Drawing.Size(380, 253);
            this.creditAccountPanel.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.creditAccountDepositNumericUpDown);
            this.panel6.Controls.Add(this.creditAccountDepositButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 47);
            this.panel6.TabIndex = 2;
            // 
            // creditAccountDepositNumericUpDown
            // 
            this.creditAccountDepositNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.creditAccountDepositNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAccountDepositNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.creditAccountDepositNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.creditAccountDepositNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.creditAccountDepositNumericUpDown.Name = "creditAccountDepositNumericUpDown";
            this.creditAccountDepositNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.creditAccountDepositNumericUpDown.TabIndex = 2;
            this.creditAccountDepositNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditAccountDepositNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // creditAccountDepositButton
            // 
            this.creditAccountDepositButton.BackColor = System.Drawing.Color.LightGreen;
            this.creditAccountDepositButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.creditAccountDepositButton.Location = new System.Drawing.Point(209, 0);
            this.creditAccountDepositButton.Name = "creditAccountDepositButton";
            this.creditAccountDepositButton.Size = new System.Drawing.Size(171, 47);
            this.creditAccountDepositButton.TabIndex = 1;
            this.creditAccountDepositButton.Text = "Deposit";
            this.creditAccountDepositButton.UseVisualStyleBackColor = false;
            this.creditAccountDepositButton.Click += new System.EventHandler(this.savingsAccountDepositButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.creditAccountWithdrawNumericUpDown);
            this.panel3.Controls.Add(this.creditAccountWithdrawButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 47);
            this.panel3.TabIndex = 2;
            // 
            // creditAccountWithdrawNumericUpDown
            // 
            this.creditAccountWithdrawNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.creditAccountWithdrawNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAccountWithdrawNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.creditAccountWithdrawNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.creditAccountWithdrawNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.creditAccountWithdrawNumericUpDown.Name = "creditAccountWithdrawNumericUpDown";
            this.creditAccountWithdrawNumericUpDown.Size = new System.Drawing.Size(209, 47);
            this.creditAccountWithdrawNumericUpDown.TabIndex = 2;
            this.creditAccountWithdrawNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditAccountWithdrawNumericUpDown.ValueChanged += new System.EventHandler(this.savingsAccountDepositNumericUpDown_ValueChanged);
            // 
            // creditAccountWithdrawButton
            // 
            this.creditAccountWithdrawButton.BackColor = System.Drawing.Color.LightCoral;
            this.creditAccountWithdrawButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.creditAccountWithdrawButton.Location = new System.Drawing.Point(209, 0);
            this.creditAccountWithdrawButton.Name = "creditAccountWithdrawButton";
            this.creditAccountWithdrawButton.Size = new System.Drawing.Size(171, 47);
            this.creditAccountWithdrawButton.TabIndex = 1;
            this.creditAccountWithdrawButton.Text = "Withdraw";
            this.creditAccountWithdrawButton.UseVisualStyleBackColor = false;
            this.creditAccountWithdrawButton.Click += new System.EventHandler(this.savingsAccountWithdrawButton_Click);
            // 
            // creditAccountMonthlyInterest
            // 
            this.creditAccountMonthlyInterest.AutoSize = true;
            this.creditAccountMonthlyInterest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAccountMonthlyInterest.ForeColor = System.Drawing.Color.Crimson;
            this.creditAccountMonthlyInterest.Location = new System.Drawing.Point(9, 90);
            this.creditAccountMonthlyInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditAccountMonthlyInterest.Name = "creditAccountMonthlyInterest";
            this.creditAccountMonthlyInterest.Size = new System.Drawing.Size(70, 41);
            this.creditAccountMonthlyInterest.TabIndex = 0;
            this.creditAccountMonthlyInterest.Text = "- 10";
            // 
            // creditAccountBalanceLabel
            // 
            this.creditAccountBalanceLabel.AutoSize = true;
            this.creditAccountBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAccountBalanceLabel.Location = new System.Drawing.Point(9, 49);
            this.creditAccountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditAccountBalanceLabel.Name = "creditAccountBalanceLabel";
            this.creditAccountBalanceLabel.Size = new System.Drawing.Size(134, 41);
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
            this.ClientSize = new System.Drawing.Size(1140, 312);
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
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savingsAccountDepositNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savingsAccountWithdrawNumericUpDown)).EndInit();
            this.studentsAccountPanel.ResumeLayout(false);
            this.studentsAccountPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentSavingsAccountDepositNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentSavingsAccountWithdrawNumericUpDown)).EndInit();
            this.creditAccountPanel.ResumeLayout(false);
            this.creditAccountPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountDepositNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountWithdrawNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Label savingsAccountLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel basicAccountPanel;
        private System.Windows.Forms.Panel studentsAccountPanel;
        private System.Windows.Forms.Label studentSavingsAccountLabel;
        private System.Windows.Forms.Panel creditAccountPanel;
        private System.Windows.Forms.Label creditAccountLabel;
        private System.Windows.Forms.Label savingsAccountBalanceLabel;
        private System.Windows.Forms.Label studentSavingsAccountBalanceLabel;
        private System.Windows.Forms.Label creditAccountBalanceLabel;
        private System.Windows.Forms.Button stopTimeButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown savingsAccountDepositNumericUpDown;
        private System.Windows.Forms.Button savingsAccountDepositButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown savingsAccountWithdrawNumericUpDown;
        private System.Windows.Forms.Button savingsAccountWithdrawButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown studentSavingsAccountDepositNumericUpDown;
        private System.Windows.Forms.Button studentSavingsAccountDepositButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown studentSavingsAccountWithdrawNumericUpDown;
        private System.Windows.Forms.Button studentSavingsAccountWithdrawButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown creditAccountDepositNumericUpDown;
        private System.Windows.Forms.Button creditAccountDepositButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown creditAccountWithdrawNumericUpDown;
        private System.Windows.Forms.Button creditAccountWithdrawButton;
        private System.Windows.Forms.Label savingsAccountMonthlyInterest;
        private System.Windows.Forms.Label studentSavingsAccountMonthlyInterest;
        private System.Windows.Forms.Label creditAccountMonthlyInterest;
    }
}

