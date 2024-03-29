﻿
namespace RejestracjaCzasuPracyWinForms
{
    partial class HomePage
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
            this.minutesToCatchUpLabel = new System.Windows.Forms.Label();
            this.minutesToCatchUpTextBox = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addNewEventTextBox = new System.Windows.Forms.TextBox();
            this.addNewEventButton = new System.Windows.Forms.Button();
            this.eventsGridView = new System.Windows.Forms.DataGridView();
            this.LoguotButton = new System.Windows.Forms.Button();
            this.workHoursLabel = new System.Windows.Forms.Label();
            this.finishHourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startHourTextBox = new System.Windows.Forms.TextBox();
            this.goHomeButton = new System.Windows.Forms.Button();
            this.GoToSummaryButton = new System.Windows.Forms.Button();
            this.UpdateRecordsButton = new System.Windows.Forms.Button();
            this.TimeInWorkCounterButton = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Label();
            this.BreakButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minutesToCatchUpLabel
            // 
            this.minutesToCatchUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesToCatchUpLabel.Location = new System.Drawing.Point(12, 38);
            this.minutesToCatchUpLabel.Name = "minutesToCatchUpLabel";
            this.minutesToCatchUpLabel.Size = new System.Drawing.Size(156, 57);
            this.minutesToCatchUpLabel.TabIndex = 0;
            this.minutesToCatchUpLabel.Text = "Your Minutes To CatchUp";
            this.minutesToCatchUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesToCatchUpTextBox
            // 
            this.minutesToCatchUpTextBox.Location = new System.Drawing.Point(31, 98);
            this.minutesToCatchUpTextBox.Name = "minutesToCatchUpTextBox";
            this.minutesToCatchUpTextBox.ReadOnly = true;
            this.minutesToCatchUpTextBox.Size = new System.Drawing.Size(111, 20);
            this.minutesToCatchUpTextBox.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WelcomeLabel.Location = new System.Drawing.Point(235, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(313, 31);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome To Your Profile";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(344, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // addNewEventTextBox
            // 
            this.addNewEventTextBox.Location = new System.Drawing.Point(212, 146);
            this.addNewEventTextBox.Name = "addNewEventTextBox";
            this.addNewEventTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNewEventTextBox.TabIndex = 4;
            // 
            // addNewEventButton
            // 
            this.addNewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewEventButton.Location = new System.Drawing.Point(318, 137);
            this.addNewEventButton.Name = "addNewEventButton";
            this.addNewEventButton.Size = new System.Drawing.Size(138, 36);
            this.addNewEventButton.TabIndex = 5;
            this.addNewEventButton.Text = "Add new record";
            this.addNewEventButton.UseVisualStyleBackColor = true;
            this.addNewEventButton.Click += new System.EventHandler(this.AddNewEventButton_Click);
            // 
            // eventsGridView
            // 
            this.eventsGridView.AllowUserToAddRows = false;
            this.eventsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsGridView.Location = new System.Drawing.Point(149, 197);
            this.eventsGridView.Name = "eventsGridView";
            this.eventsGridView.Size = new System.Drawing.Size(493, 241);
            this.eventsGridView.TabIndex = 6;
            // 
            // LoguotButton
            // 
            this.LoguotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoguotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoguotButton.Location = new System.Drawing.Point(775, 461);
            this.LoguotButton.Name = "LoguotButton";
            this.LoguotButton.Size = new System.Drawing.Size(94, 37);
            this.LoguotButton.TabIndex = 7;
            this.LoguotButton.Text = "Logout";
            this.LoguotButton.UseVisualStyleBackColor = false;
            this.LoguotButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // workHoursLabel
            // 
            this.workHoursLabel.AutoSize = true;
            this.workHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workHoursLabel.Location = new System.Drawing.Point(708, 28);
            this.workHoursLabel.Name = "workHoursLabel";
            this.workHoursLabel.Size = new System.Drawing.Size(116, 25);
            this.workHoursLabel.TabIndex = 8;
            this.workHoursLabel.Text = "Work Hours";
            // 
            // finishHourTextBox
            // 
            this.finishHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishHourTextBox.Location = new System.Drawing.Point(775, 58);
            this.finishHourTextBox.Name = "finishHourTextBox";
            this.finishHourTextBox.ReadOnly = true;
            this.finishHourTextBox.Size = new System.Drawing.Size(49, 26);
            this.finishHourTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(755, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // startHourTextBox
            // 
            this.startHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startHourTextBox.Location = new System.Drawing.Point(701, 59);
            this.startHourTextBox.Name = "startHourTextBox";
            this.startHourTextBox.ReadOnly = true;
            this.startHourTextBox.Size = new System.Drawing.Size(48, 26);
            this.startHourTextBox.TabIndex = 12;
            // 
            // goHomeButton
            // 
            this.goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goHomeButton.Location = new System.Drawing.Point(705, 105);
            this.goHomeButton.Name = "goHomeButton";
            this.goHomeButton.Size = new System.Drawing.Size(119, 58);
            this.goHomeButton.TabIndex = 13;
            this.goHomeButton.Text = "Go Home";
            this.goHomeButton.UseVisualStyleBackColor = true;
            this.goHomeButton.Click += new System.EventHandler(this.goHomeButton_Click);
            // 
            // GoToSummaryButton
            // 
            this.GoToSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToSummaryButton.Location = new System.Drawing.Point(17, 449);
            this.GoToSummaryButton.Name = "GoToSummaryButton";
            this.GoToSummaryButton.Size = new System.Drawing.Size(125, 49);
            this.GoToSummaryButton.TabIndex = 14;
            this.GoToSummaryButton.Text = "Go to summary of all users";
            this.GoToSummaryButton.UseVisualStyleBackColor = true;
            this.GoToSummaryButton.Click += new System.EventHandler(this.GoToSummaryButton_Click);
            // 
            // UpdateRecordsButton
            // 
            this.UpdateRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateRecordsButton.Location = new System.Drawing.Point(318, 449);
            this.UpdateRecordsButton.Name = "UpdateRecordsButton";
            this.UpdateRecordsButton.Size = new System.Drawing.Size(138, 49);
            this.UpdateRecordsButton.TabIndex = 15;
            this.UpdateRecordsButton.Text = "Update Records";
            this.UpdateRecordsButton.UseVisualStyleBackColor = true;
            this.UpdateRecordsButton.Click += new System.EventHandler(this.UpdateRecordsButton_Click);
            // 
            // TimeInWorkCounterButton
            // 
            this.TimeInWorkCounterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimeInWorkCounterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeInWorkCounterButton.Location = new System.Drawing.Point(705, 215);
            this.TimeInWorkCounterButton.Name = "TimeInWorkCounterButton";
            this.TimeInWorkCounterButton.Size = new System.Drawing.Size(119, 52);
            this.TimeInWorkCounterButton.TabIndex = 16;
            this.TimeInWorkCounterButton.Text = "Start Working";
            this.TimeInWorkCounterButton.UseVisualStyleBackColor = false;
            this.TimeInWorkCounterButton.Click += new System.EventHandler(this.TimeInWorkCounterButton_Click);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(686, 176);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(150, 13);
            this.Line.TabIndex = 17;
            this.Line.Text = "▬▬▬▬▬▬▬▬▬▬▬▬▬";
            // 
            // BreakButton
            // 
            this.BreakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BreakButton.Location = new System.Drawing.Point(705, 291);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(119, 48);
            this.BreakButton.TabIndex = 18;
            this.BreakButton.Text = "Finish Your Break";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.Click += new System.EventHandler(this.BreakButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 510);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.TimeInWorkCounterButton);
            this.Controls.Add(this.UpdateRecordsButton);
            this.Controls.Add(this.GoToSummaryButton);
            this.Controls.Add(this.goHomeButton);
            this.Controls.Add(this.startHourTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishHourTextBox);
            this.Controls.Add(this.workHoursLabel);
            this.Controls.Add(this.LoguotButton);
            this.Controls.Add(this.eventsGridView);
            this.Controls.Add(this.addNewEventButton);
            this.Controls.Add(this.addNewEventTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.minutesToCatchUpTextBox);
            this.Controls.Add(this.minutesToCatchUpLabel);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minutesToCatchUpLabel;
        private System.Windows.Forms.TextBox minutesToCatchUpTextBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox addNewEventTextBox;
        private System.Windows.Forms.Button addNewEventButton;
        private System.Windows.Forms.DataGridView eventsGridView;
        private System.Windows.Forms.Button LoguotButton;
        private System.Windows.Forms.Label workHoursLabel;
        private System.Windows.Forms.TextBox finishHourTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startHourTextBox;
        private System.Windows.Forms.Button goHomeButton;
        private System.Windows.Forms.Button GoToSummaryButton;
        private System.Windows.Forms.Button UpdateRecordsButton;
        private System.Windows.Forms.Button TimeInWorkCounterButton;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Button BreakButton;
    }
}