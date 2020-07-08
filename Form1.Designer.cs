namespace HoursAuditing
{
    partial class Hours
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TasksLabel = new System.Windows.Forms.Label();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.CurrentTaskBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(609, 39);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 35);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start time";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.AutoSize = true;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(609, 80);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 35);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset time";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(40, 80);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(124, 25);
            this.CurrentTime.TabIndex = 4;
            this.CurrentTime.Text = "Current time:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(40, 45);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(103, 25);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total time:";
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoSize = true;
            this.TasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksLabel.Location = new System.Drawing.Point(51, 224);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new System.Drawing.Size(0, 31);
            this.TasksLabel.TabIndex = 6;
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTaskLabel.Location = new System.Drawing.Point(486, 127);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(124, 25);
            this.CurrentTaskLabel.TabIndex = 7;
            this.CurrentTaskLabel.Text = "Current task:";
            // 
            // CurrentTaskBox
            // 
            this.CurrentTaskBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentTaskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTaskBox.Location = new System.Drawing.Point(616, 127);
            this.CurrentTaskBox.Name = "CurrentTaskBox";
            this.CurrentTaskBox.Size = new System.Drawing.Size(123, 23);
            this.CurrentTaskBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.AutoSize = true;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(455, 39);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 35);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CurrentTaskBox);
            this.Controls.Add(this.CurrentTaskLabel);
            this.Controls.Add(this.TasksLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Hours";
            this.Text = "Hours";
            this.Load += new System.EventHandler(this.Hours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TasksLabel;
        private System.Windows.Forms.Label CurrentTaskLabel;
        private System.Windows.Forms.TextBox CurrentTaskBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

