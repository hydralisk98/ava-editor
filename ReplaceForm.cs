using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ava
{
    public partial class ReplaceForm : Form
    {
        // Static global variables
        public static string targetString;
        public static string replacementString;
        public static bool canReplaceValue;

        // Constructor
        public ReplaceForm()
        {
            InitializeComponent();

            // Set default values to the variables
            targetString = "";
            replacementString = "";
            canReplaceValue = false;
        }

        // If the text in tbTarget changes, the targetString variable is updated
        private void tbTarget_TextChanged(object sender, EventArgs e)
        {
            targetString = tbTarget.Text;
        }

        // If the text in tbReplacement changes, the replacementString variable is updated
        private void tbReplacement_TextChanged(object sender, EventArgs e)
        {
            replacementString = tbReplacement.Text;
        }

        // If the btnReplace button is clicked, the targetString and the replacementString variables are updated
        private void btnReplace_Click(object sender, EventArgs e)
        {
            targetString = tbTarget.Text;
            replacementString = tbReplacement.Text;

            if(targetString != "" && replacementString != "")
            {
                canReplaceValue = true;
            }
        }
    }
}
