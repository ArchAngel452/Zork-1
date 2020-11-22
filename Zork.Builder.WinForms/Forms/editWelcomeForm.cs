using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms.Forms
{
    public partial class editWelcomeForm : Form
    {
        public string roomDescription 
        {
            get => descriptionTextBox.Text;
            set => descriptionTextBox.Text = value;
        }

        public editWelcomeForm()
        {
            InitializeComponent();
            saveButton.Enabled = false;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = !string.IsNullOrEmpty(roomDescription);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            descriptionTextBox.Text = "";
        }
    }
}
