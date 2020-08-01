using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTrim
{
    public partial class RmvNumbersForm : Form
    {
        //orig will represent for original folder and its directory.
        FolderBrowserDialog num_orig = new FolderBrowserDialog();
        public RmvNumbersForm()
        {
            InitializeComponent();
        }

        private void num_browseBtn_Click(object sender, EventArgs e)
        {
            if (num_orig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Display file name if it exists.
                num_filePathTextBox.Text = Path.GetFileNameWithoutExtension(num_orig.SelectedPath);

                //Set selected path to a string, so it may work as a DirectoryInfo parameter.
                string num_parent = num_orig.SelectedPath;

                //Create new object to access parent file, in which the renamed file will be saved to.
                DirectoryInfo directoryInfo = new DirectoryInfo(num_parent);

                //Set current directory to the one selected in the folder browser dialog.
                //Otherwise, renamed file(s) will save in Visual Studio Projects folder.
                Directory.SetCurrentDirectory(directoryInfo.Parent.FullName);

                num_cutBtn.Visible = true;
                num_cutBtn.Focus();
            }
        }

        private void num_cutBtn_Click(object sender, EventArgs e)
        {
            //Allow user to rename file manually should they want to include specifics.
            num_manualBtn.Visible = true;

            //Remove letters from the filename of selected file(s).
            String num_fileName = Regex.Replace(num_filePathTextBox.Text.Trim(), "[^A-Za-z]+", "");
            num_newFileTextBox.Text = num_fileName.Replace(" ", String.Empty);
        }

        private void num_manualBtn_Click(object sender, EventArgs e)
        {
            //Allow user to manually enter a new name for given files.
            num_newFileTextBox.Enabled = true;
            num_newFileTextBox.ReadOnly = false;
        }

        private void num_confBtn_Click(object sender, EventArgs e)
        {
            //Rename file- if file does not exist, display error.
            try
            {
                Directory.Move(num_orig.SelectedPath, num_newFileTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Selected file not found.", "Error");
            }

            num_newFileTextBox.Enabled = false;
        }
    }
}
