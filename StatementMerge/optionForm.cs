using System;
using System.Windows.Forms;

namespace StatementMerge
{
    public partial class optionForm : Form
    {
        
        public string quarterString = null;
        //Give this a default of today so that if nothing gets picked a variable is still passed and is not null.
        public string asofString = DateTime.Today.ToLongDateString();

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

        private void fileButton_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            fileLabel.Text = fd.FileName;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            string startingFolder = @"K:\ACCTING\GENERAL\Qtrly and Annual Forms\Statements\QUARTERLY STATEMENTS";

           FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = startingFolder;
           fd.ShowDialog();

            folderLabel.Text = fd.SelectedPath;
        }
    }
}
