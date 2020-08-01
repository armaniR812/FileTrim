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
    public partial class RmvLettersForm : Form
    {
        //orig will represent for original folder and its directory.
        FolderBrowserDialog let_orig = new FolderBrowserDialog();

        public RmvLettersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void let_browseBtn_Click(object sender, EventArgs e)
        {
            if (let_orig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Display file name if it exists.
                let_filePathTextBox.Text = Path.GetFileNameWithoutExtension(let_orig.SelectedPath);

                //Set selected path to a string, so it may work as a DirectoryInfo parameter.
                string let_parent = let_orig.SelectedPath;

                //Create new object to access parent file, in which the renamed file will be saved to.
                DirectoryInfo directoryInfo = new DirectoryInfo(let_parent);

                //Set current directory to the one selected in the folder browser dialog.
                //Otherwise, renamed file(s) will save in Visual Studio Projects folder.
                Directory.SetCurrentDirectory(directoryInfo.Parent.FullName);

                let_cutBtn.Visible = true;
                let_cutBtn.Focus();
            }
        }

        private void let_cutBtn_Click(object sender, EventArgs e)
        {
            //Allow user to rename file manually should they want to include specifics.
            let_manualBtn.Visible = true;

            //Remove letters from the filename of selected file(s).
            String let_fileName = Regex.Replace(let_filePathTextBox.Text.Trim(), "[^0-9]+", "");
            let_newFileTextBox.Text = let_fileName.Replace(" ", String.Empty);
        }

        private void let_manualBtn_Click(object sender, EventArgs e)
        {
            //Allow user to manually enter a new name for given files.
            let_newFileTextBox.Enabled = true;
            let_newFileTextBox.ReadOnly = false;
        }

        private void let_confBtn_Click(object sender, EventArgs e)
        {
            //Rename file- if file does not exist, display error.
            try
            {
                Directory.Move(let_orig.SelectedPath, let_newFileTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Selected file not found.", "Error");
            }

            let_newFileTextBox.Enabled = false;
        }
    }    
}
