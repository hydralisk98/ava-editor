using System;
using System.Windows.Forms;

namespace Ava
{
    public partial class SeekForm : Form
    {
        // Static global variables
        public static string seekedString;
        public static bool hasValidValue;

        // Constructor
        public SeekForm()
        {
            InitializeComponent();

            // Set default values to the variables
            seekedString = "";
            hasValidValue = false;
        }

        private void tbTarget_TextChanged(object sender, EventArgs e)
        {
            seekedString = tbTarget.Text;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            seekedString = tbTarget.Text;

            if(seekedString != "")
            {
                hasValidValue = true;
            }
        }

        protected void SeekForm_OnFormClosing(object sender, FormClosingEventArgs e) { Hide(); }
    }
}
