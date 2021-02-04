using System;
using System.Windows.Forms;

namespace StatementMerge
{
    public partial class optionForm : Form
    {
        
        public string quarterString = null;
        public string asofString = null;

        public optionForm()
        {
            InitializeComponent();
        }

        private void radioChanged(object sender, EventArgs e)
        {
            if(firstButton.Checked)
            {
                quarterString = "1st Qtr";
            }
            if(secondButton.Checked)
            {
                quarterString = "2nd Qtr";
            }
            if(thirdButton.Checked)
            {
                quarterString = "3rd Qtr";
            }
            if(fourthButton.Checked)
            {
                quarterString = "4th Qtr";
            }

            quarterConfirm.Text = quarterString;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void asofPicker_ValueChanged(object sender, EventArgs e)
        {
            asofString = asofPicker.Value.ToLongDateString();
            
            asofConfirm.Text = asofString;
        }
    }
}
