namespace Second_Task
{
    partial class TaskForm
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
            this.taskLable = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.nInput = new System.Windows.Forms.TextBox();
            this.solveLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskLable
            // 
            this.taskLable.AutoSize = true;
            this.taskLable.Location = new System.Drawing.Point(12, 9);
            this.taskLable.Name = "taskLable";
            this.taskLable.Size = new System.Drawing.Size(368, 15);
            this.taskLable.TabIndex = 0;
            this.taskLable.Text = "Среди чисел 1, 4, 9, 16, 25, ... найти первое число, большее чем N";
            // 
            // solveButton
            // 
            this.solveButton.Enabled = false;
            this.solveButton.Location = new System.Drawing.Point(305, 36);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 2;
            this.solveButton.Text = "Найти";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(12, 36);
            this.nInput.MaxLength = 9;
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(281, 23);
            this.nInput.TabIndex = 1;
            this.nInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nInput.TextChanged += new System.EventHandler(this.nInput_TextChanged);
            // 
            // solveLable
            // 
            this.solveLable.AutoSize = true;
            this.solveLable.Location = new System.Drawing.Point(15, 77);
            this.solveLable.Name = "solveLable";
            this.solveLable.Size = new System.Drawing.Size(0, 15);
            this.solveLable.TabIndex = 3;
            // 
            // TaskForm
            // 
            this.AcceptButton = this.solveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 111);
            this.Controls.Add(this.solveLable);
            this.Controls.Add(this.nInput);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.taskLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача на for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLable;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox nInput;
        private System.Windows.Forms.Label solveLable;
    }
}

