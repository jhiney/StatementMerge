
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
            this.firstButton = new System.Windows.Forms.RadioButton();
            this.secondButton = new System.Windows.Forms.RadioButton();
            this.fourthButton = new System.Windows.Forms.RadioButton();
            this.thirdButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.asofPicker = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Select a Quarter";
            // 
            // asofPicker
            // 
            this.asofPicker.Location = new System.Drawing.Point(178, 36);
            this.asofPicker.Name = "asofPicker";
            this.asofPicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please Select a \"As Of\" Date";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(459, 107);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(115, 23);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // optionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 207);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asofPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourthButton);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Name = "optionForm";
            this.Text = "Quarterly Statement Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton firstButton;
        private System.Windows.Forms.RadioButton secondButton;
        private System.Windows.Forms.RadioButton fourthButton;
        private System.Windows.Forms.RadioButton thirdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar asofPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runButton;
    }
}