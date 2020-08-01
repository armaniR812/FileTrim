using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTrim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void letterBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mainConfBtn_Click(object sender, EventArgs e)
        {
            //Open the form according to what was checked on the main form.
            if (letterBtn.Checked == true)
            {
                RmvLettersForm lettersForm = new RmvLettersForm();
                lettersForm.Show();
            }

            else if (numberBtn.Checked == true)
            {
                RmvNumbersForm numbersForm = new RmvNumbersForm();
                numbersForm.Show();
            }

            else
            {
                MessageBox.Show("Please select a method.");
            }
        }
    }
}
