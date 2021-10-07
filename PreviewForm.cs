using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ava;

namespace Ava
{
    public partial class PreviewForm : Form
    {
        public static string textualContent;
        public PreviewForm()
        {
            InitializeComponent();
        }

        /*
        private void contentRichTb_Click(object sender, EventArgs e)
        {
            // textualContent = CoreForm.contentRichTb.Text;
            contentRichTb.Text = AvaSystem.AvaEncode(textualContent);
        }
        */
    }
}
