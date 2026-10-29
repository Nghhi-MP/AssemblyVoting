using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssemblyVoting
{
    public partial class ConclusionWindow : Form
    {
        public ConclusionWindow(string text)
        {

            InitializeComponent();

            mainLabel.Text = text;

            if (text == "נגד")
            {
                BackColor = Color.Red;
                ForeColor = Color.White;
            }

        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConclusionWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
