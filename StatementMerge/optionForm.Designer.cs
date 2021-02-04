
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.AutoSize = true;
            this.firstButton.Location = new System.Drawing.Point(0, 27);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(77, 17);
            this.firstButton.TabIndex = 1;
            this.firstButton.TabStop = true;
            this.firstButton.Text = "1st Quarter";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // secondButton
            // 
            this.secondButton.AutoSize = true;
            this.secondButton.Location = new System.Drawing.Point(0, 51);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(81, 17);
            this.secondButton.TabIndex = 2;
            this.secondButton.TabStop = true;
            this.secondButton.Text = "2nd Quarter";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // fourthButton
            // 
            this.fourthButton.AutoSize = true;
            this.fourthButton.Location = new System.Drawing.Point(0, 98);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(78, 17);
            this.fourthButton.TabIndex = 4;
            this.fourthButton.TabStop = true;
            this.fourthButton.Text = "4th Quarter";
            this.fourthButton.UseVisualStyleBackColor = true;
            this.fourthButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // thirdButton
            // 
            this.thirdButton.AutoSize = true;
            this.thirdButton.Location = new System.Drawing.Point(0, 74);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(78, 17);
            this.thirdButton.TabIndex = 3;
            this.thirdButton.TabStop = true;
            this.thirdButton.Text = "3rd Quarter";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.CheckedChanged += new System.EventHandler(this.radioChanged);
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
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondButton);
            this.groupBox1.Controls.Add(this.firstButton);
            this.groupBox1.Controls.Add(this.thirdButton);
            this.groupBox1.Controls.Add(this.fourthButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // optionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asofPicker);
            this.Controls.Add(this.label1);
            this.Name = "optionForm";
            this.Text = "Quarterly Statement Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}