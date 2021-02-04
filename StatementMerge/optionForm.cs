using System;
using System.Windows.Forms;

namespace StatementMerge
{
    public partial class optionForm : Form
    {
        
        public string quarterString = null;

        public optionForm()
        {
            InitializeComponent();
        }

        private void radioChanged(object sender, EventArgs e)
        {
            if(firstButton.Checked)
            {
                quarterString = "1st";
            }
            if(secondButton.Checked)
            {
                quarterString = "2nd";
            }
            if(thirdButton.Checked)
            {
                quarterString = "3rd";
            }
            if(fourthButton.Checked)
            {
                quarterString = "4th";
            }

            quarterConfirm.Text = quarterString;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(quarterString.ToString());
        }

        private void asofPicker_ValueChanged(object sender, EventArgs e)
        {
            asofConfirm.Text = asofPicker.Value.ToLongDateString();
        }
    }
}
