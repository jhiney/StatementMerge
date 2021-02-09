
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
            this.label2 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asofPicker = new System.Windows.Forms.DateTimePicker();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.quarterLabel = new System.Windows.Forms.Label();
            this.asofLabel = new System.Windows.Forms.Label();
            this.quarterConfirm = new System.Windows.Forms.Label();
            this.asofConfirm = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.AutoSize = true;
            this.firstButton.Location = new System.Drawing.Point(0, 27);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(39, 17);
            this.firstButton.TabIndex = 1;
            this.firstButton.TabStop = true;
            this.firstButton.Text = "Q1";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // secondButton
            // 
            this.secondButton.AutoSize = true;
            this.secondButton.Location = new System.Drawing.Point(0, 51);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(39, 17);
            this.secondButton.TabIndex = 2;
            this.secondButton.TabStop = true;
            this.secondButton.Text = "Q2";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // fourthButton
            // 
            this.fourthButton.AutoSize = true;
            this.fourthButton.Location = new System.Drawing.Point(0, 98);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(39, 17);
            this.fourthButton.TabIndex = 4;
            this.fourthButton.TabStop = true;
            this.fourthButton.Text = "Q4";
            this.fourthButton.UseVisualStyleBackColor = true;
            this.fourthButton.CheckedChanged += new System.EventHandler(this.radioChanged);
            // 
            // thirdButton
            // 
            this.thirdButton.AutoSize = true;
            this.thirdButton.Location = new System.Drawing.Point(0, 74);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(39, 17);
            this.thirdButton.TabIndex = 3;
            this.thirdButton.TabStop = true;
            this.thirdButton.Text = "Q3";
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
            this.runButton.BackColor = System.Drawing.Color.Maroon;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.SystemColors.Window;
            this.runButton.Location = new System.Drawing.Point(701, 12);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(115, 32);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
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
            // asofPicker
            // 
            this.asofPicker.Location = new System.Drawing.Point(165, 36);
            this.asofPicker.Name = "asofPicker";
            this.asofPicker.Size = new System.Drawing.Size(200, 20);
            this.asofPicker.TabIndex = 10;
            this.asofPicker.ValueChanged += new System.EventHandler(this.asofPicker_ValueChanged);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(417, 20);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(154, 13);
            this.confirmationLabel.TabIndex = 11;
            this.confirmationLabel.Text = "Please Confirm Your Selections";
            // 
            // quarterLabel
            // 
            this.quarterLabel.AutoSize = true;
            this.quarterLabel.Location = new System.Drawing.Point(420, 37);
            this.quarterLabel.Name = "quarterLabel";
            this.quarterLabel.Size = new System.Drawing.Size(45, 13);
            this.quarterLabel.TabIndex = 12;
            this.quarterLabel.Text = "Quarter:";
            // 
            // asofLabel
            // 
            this.asofLabel.AutoSize = true;
            this.asofLabel.Location = new System.Drawing.Point(420, 54);
            this.asofLabel.Name = "asofLabel";
            this.asofLabel.Size = new System.Drawing.Size(105, 13);
            this.asofLabel.TabIndex = 13;
            this.asofLabel.Text = "As Of Date for Email:";
            // 
            // quarterConfirm
            // 
            this.quarterConfirm.AutoSize = true;
            this.quarterConfirm.Location = new System.Drawing.Point(472, 37);
            this.quarterConfirm.Name = "quarterConfirm";
            this.quarterConfirm.Size = new System.Drawing.Size(0, 13);
            this.quarterConfirm.TabIndex = 14;
            // 
            // asofConfirm
            // 
            this.asofConfirm.AutoSize = true;
            this.asofConfirm.Location = new System.Drawing.Point(532, 54);
            this.asofConfirm.Name = "asofConfirm";
            this.asofConfirm.Size = new System.Drawing.Size(0, 13);
            this.asofConfirm.TabIndex = 15;
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(165, 110);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 16;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(165, 140);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 17;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(247, 144);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(0, 13);
            this.fileLabel.TabIndex = 18;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(247, 119);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(0, 13);
            this.folderLabel.TabIndex = 19;
            // 
            // optionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 188);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.asofConfirm);
            this.Controls.Add(this.quarterConfirm);
            this.Controls.Add(this.asofLabel);
            this.Controls.Add(this.quarterLabel);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.asofPicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker asofPicker;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Label quarterLabel;
        private System.Windows.Forms.Label asofLabel;
        private System.Windows.Forms.Label quarterConfirm;
        private System.Windows.Forms.Label asofConfirm;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label folderLabel;
    }
}