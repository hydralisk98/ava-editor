using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ava
{
    public partial class CoreForm : Form
    {
        // Declare global variables
        string path;
        string textualContent = "";
        string targetText;
        // private int aboutClickCounter;


        // Constuctor of CoreForm
        public CoreForm()
        {
            InitializeComponent();

            // Defines some basic properties at initialization
            contentRichTb.WordWrap = true;
            contentRichTb.AcceptsTab = true;
            contentRichTb.EnableAutoDragDrop = true;
            contentRichTb.DetectUrls = true;
            contentRichTb.AutoWordSelection = true;
            // contentRichTb.BulletIndent;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            // Start a new instance of the program
            Process.Start(Application.ProductName);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // Displays a new dialog window to gather the content of a existing file then record the choice in the variable "choice"
            OpenFileDialog openFile1 = new OpenFileDialog();
            DialogResult choice = openFile1.ShowDialog();

            // Record the complete file path to the variable "path"
            path = openFile1.FileName;

            // If the choice is affirmative and that the file contains more than more character, then it shall be saved
            if (choice == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                // Opening the selected file and reads it to the very end
                StreamReader softStreamRead = new StreamReader(openFile1.FileName);
                contentRichTb.Text = softStreamRead.ReadToEnd();

                // Closing the reader to optimkize computer resources and avoid some vulnerabilities
                softStreamRead.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // Give file location choice to the user
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Define the extension nand filters for the types of files that it may save
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Plain text files(*.txt)|*.txt|All files(*.*)|*.*";

            // Stocks the dialog choice and then the complete system path in the variable path
            DialogResult choice = saveFile1.ShowDialog();
            path = saveFile1.FileName;

            // If the choice is affirmative (OK) and that the file contains more than zero characters, then it is saved
            if (choice == DialogResult.OK && saveFile1.FileName.Length > 0) { contentRichTb.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText); /* The StreamType defines the saved file type */ }
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            // Displays a choice dialog to warn the user and then stocks the response in a DialogResult
            DialogResult choice = MessageBox.Show("Are you sure you want to exit the program?\nYou may have unsaved changes.", "Confirm exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user indicates yes to the previous request, we empty the CoreForm content and properly terminates the entire program
            if(choice == DialogResult.Yes)
            {
                contentRichTb.Clear();
                Application.Exit();
            }
        }

        private void contentRichTb_TextChanged(object sender, EventArgs e)
        {
            // Update the nymber of symbols in symbolCounterTSSLb
            int numSymbols = contentRichTb.Text.Length;
            symbolCounterTSSLb.Text = String.Format("Number of symbols: "+numSymbols);

            textualContent = contentRichTb.Text;
        }

        private void previewToolStripButton_Click(object sender, EventArgs e)
        {
            /* Gonna see about that soon enough after some more reading of both the XML documentation and the hyperlink's ReadMe: https://github.com/MindTouch/SGMLReader */
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            // If we can undo instructions, then we simply undo then one step at a time
            if(contentRichTb.CanUndo) { contentRichTb.Undo(); /* contentRichTb.ClearUndo(); /* Only if you want to undo only once, because clearing that buffer may impede productivity */ }
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            // If we can redo instructions that are also not Delete, then we can do the action of Redo
            if (contentRichTb.CanRedo == true) { if (contentRichTb.RedoActionName != "Delete") { contentRichTb.Redo(); } }
        }

        
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            // If there is more than zero charcters to cut, just do the requested Cut
            if(contentRichTb.SelectionLength > 0) { contentRichTb.Cut(); }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            // If there is more than zero charcters to copy, just do the requested Copy
            if(contentRichTb.SelectionLength > 0) { contentRichTb.Copy(); }
        }
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            // When you have text in the clipboard to paste, just do the Pasting
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) { contentRichTb.Paste(); }
        }

        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            // Defines the target string to find out inside "contentRichTb"
            targetText = "KEKE";

            // If textualContent contains targetText, then display a MessageBox with the target text and its position index into the richTextBox accordingly
            if (textualContent.Contains(targetText)) { MessageBox.Show("Found a match for "+"\""+targetText+"\""+" in this document."); }

            if (!textualContent.Contains(targetText)) { MessageBox.Show("Found no match for "+"\""+targetText+"\""+" in this document."); }
        }
        private void replaceToolStripButton_Click(object sender, EventArgs e)
        {
            // Defines the target string to find out inside "contentRichTb", sets the replacing element and imports the text of "contentRichTb" into replacedTextCorpus
            targetText = "KEKE";
            string replaceTextElement = "KWEI";
            string replacedTextCorpus = contentRichTb.Text;

            // If the contentRichTb contains the target string, then replace it accordingly and then updates the overall contentRichTb.Text to his updated content
            if (contentRichTb.Text.Contains(targetText))
            {
                replacedTextCorpus = contentRichTb.Text.Replace(targetText, replaceTextElement);
                contentRichTb.Text = replacedTextCorpus;
            }
        }
        private void appendToolStripButton_Click(object sender, EventArgs e)
        {
            // Appends the string value to the end of the document 
            contentRichTb.Text += "\n(ASHUR;NINEVEH)";
        }
        
        // AWFUL CODE THAT DOESN'T DO ITS INTENDED PURPOSE WELL ENOUGH YET SO I DISABLED IT IN ITS ENTIRETY
        /*
        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            // Counting the number of clicks over this very button is gotta be useful later on
            aboutClickCounter += 1;

            // Mauvaise position
            AboutForm introForm = new AboutForm();
            introForm.Show();
            
            // When there is any other number of instances but one of the AboutForm, then do nothing

            /*
            
            if (AboutForm.numInstances < 1 || AboutForm.numInstances > 1)
            {

                // === When there is any other number of instance of the AboutForm than 1, then do nothing ===
                
            }
            
            */

            // When there 1, then either show or hide the introForm instance

            /*
            
            else if (AboutForm.numInstances == 1)
            {
                // If aboutCountClicks passes the partity check, which is at every even number, the form hides itself until the next click
                if (parityCheck(aboutClickCounter)) { introForm.Hide(); }

                // If aboutCountClicks fails the parity check, which is at every odd number, the form shows until the next click
                else if (!parityCheck(aboutClickCounter)) { introForm.Show(); } // DESIGN ERROR occuring here it seems
            }

            */
    }

        // PARITY-CHECKING CUSTOM METHOD
        /*
        private bool parityCheck(int evalNum)
        {
            float parityEval = evalNum % 2;

            if(parityEval == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
}
