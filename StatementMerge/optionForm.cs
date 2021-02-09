using System;
using System.Windows.Forms;

namespace StatementMerge
{
    public partial class optionForm : Form
    {
        
        
        //Give this a default of today so that if nothing gets picked a variable is still passed and is not null.
        public string asofString = DateTime.Today.ToLongDateString();

        //Quarter string and fiscalYear combine to form subjectString
        public string quarterString = null;
        public string fiscalYear = DateTime.Today.Year.ToString();

        public string subjectString = null;

        public string statementFolder = null;

        public string listFile = null;

        public optionForm()
        {
            InitializeComponent();
        }

        private void radioChanged(object sender, EventArgs e)
        {
            if(firstButton.Checked)
            {
                quarterString = "Q1";
            }
            if(secondButton.Checked)
            {
                quarterString = "Q2";
            }
            if(thirdButton.Checked)
            {
                quarterString = "Q3";
            }
            if(fourthButton.Checked)
            {
                quarterString = "Q4";
            }

            subjectString = fiscalYear + " " + quarterString;
            quarterConfirm.Text = subjectString;
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

            listFile = fd.FileName;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
           string startingFolder = @"K:\ACCTING\GENERAL\Qtrly and Annual Forms\Statements\QUARTERLY STATEMENTS";
           FolderBrowserDialog fd = new FolderBrowserDialog();
           fd.SelectedPath = startingFolder;
           fd.ShowDialog();
           folderLabel.Text = fd.SelectedPath;

            statementFolder = fd.SelectedPath;
        }

        private void fiscalYearBox_TextChanged(object sender, EventArgs e)
        {
            fiscalYear = fiscalYearBox.Text;
            subjectString = fiscalYear + " " + quarterString;
            quarterConfirm.Text = subjectString;
        }
    }
}
