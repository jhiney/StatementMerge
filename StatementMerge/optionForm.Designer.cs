
namespace StatementMerge
{
    partial class optionForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.firstButton = new System.Windows.Forms.RadioButton();
            this.secondButton = new System.Windows.Forms.RadioButton();
            this.fourthButton = new System.Windows.Forms.RadioButton();
            this.thirdButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // firstButton
            // 
            this.firstButton.AutoSize = true;
            this.firstButton.Location = new System.Drawing.Point(12, 36);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(77, 17);
            this.firstButton.TabIndex = 1;
            this.firstButton.TabStop = true;
            this.firstButton.Text = "1st Quarter";
            this.firstButton.UseVisualStyleBackColor = true;
            // 
            // secondButton
            // 
            this.secondButton.AutoSize = true;
            this.secondButton.Location = new System.Drawing.Point(12, 60);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(81, 17);
            this.secondButton.TabIndex = 2;
            this.secondButton.TabStop = true;
            this.secondButton.Text = "2nd Quarter";
            this.secondButton.UseVisualStyleBackColor = true;
            // 
            // fourthButton
            // 
            this.fourthButton.AutoSize = true;
            this.fourthButton.Location = new System.Drawing.Point(12, 107);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(78, 17);
            this.fourthButton.TabIndex = 4;
            this.fourthButton.TabStop = true;
            this.fourthButton.Text = "4th Quarter";
            this.fourthButton.UseVisualStyleBackColor = true;
            // 
            // thirdButton
            // 
            this.thirdButton.AutoSize = true;
            this.thirdButton.Location = new System.Drawing.Point(12, 83);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(78, 17);
            this.thirdButton.TabIndex = 3;
            this.thirdButton.TabStop = true;
            this.thirdButton.Text = "3rd Quarter";
            this.thirdButton.UseVisualStyleBackColor = true;
            // 
            // optionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 196);
            this.Controls.Add(this.fourthButton);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "optionForm";
            this.Text = "optionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton firstButton;
        private System.Windows.Forms.RadioButton secondButton;
        private System.Windows.Forms.RadioButton fourthButton;
        private System.Windows.Forms.RadioButton thirdButton;
    }
}