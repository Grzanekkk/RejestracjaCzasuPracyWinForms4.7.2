
namespace RejestracjaCzasuPracyWinForms
{
    partial class AllUserSummaryForm
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
            this.summaryGridView = new System.Windows.Forms.DataGridView();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // summaryGridView
            // 
            this.summaryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.summaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGridView.Location = new System.Drawing.Point(58, 88);
            this.summaryGridView.Name = "summaryGridView";
            this.summaryGridView.Size = new System.Drawing.Size(672, 268);
            this.summaryGridView.TabIndex = 0;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SummaryLabel.Location = new System.Drawing.Point(236, 9);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(279, 32);
            this.SummaryLabel.TabIndex = 1;
            this.SummaryLabel.Text = "Sumamry of all users";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(317, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goBackButton.Location = new System.Drawing.Point(691, 399);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(97, 39);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // AllUserSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.summaryGridView);
            this.Name = "AllUserSummaryForm";
            this.Text = "AllUserSummaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.summaryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView summaryGridView;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goBackButton;
    }
}