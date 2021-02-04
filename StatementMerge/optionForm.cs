using System;
using System.Windows.Forms;

namespace StatementMerge
{
    public partial class optionForm : Form
    {
        public int quarter = 0;
        public optionForm()
        {
            InitializeComponent();
        }

        private void radioChanged(object sender, EventArgs e)
        {
            if(firstButton.Checked)
            {
                quarter = 1;
            }
            if(secondButton.Checked)
            {
                quarter = 2;
            }
            if(thirdButton.Checked)
            {
                quarter = 3;
            }
            if(fourthButton.Checked)
            {
                quarter = 4;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(quarter.ToString());
        }

        private void asofPicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(asofPicker.Value.ToShortDateString());
        }
    }
}
