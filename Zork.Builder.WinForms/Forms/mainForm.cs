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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void editWelcomeMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (editWelcomeForm editWelcomeForm = new editWelcomeForm()) 
            { 
                if (editWelcomeForm.ShowDialog() == DialogResult.OK) 
                { 
                
                }
            }
        }

        private void editStartingLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
