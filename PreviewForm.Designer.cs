
namespace Ava
{
    partial class PreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentRichTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contentRichTb
            // 
            this.contentRichTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentRichTb.Location = new System.Drawing.Point(0, 0);
            this.contentRichTb.Name = "contentRichTb";
            this.contentRichTb.ReadOnly = true;
            this.contentRichTb.Size = new System.Drawing.Size(464, 281);
            this.contentRichTb.TabIndex = 0;
            this.contentRichTb.Text = "";
            // this.contentRichTb.Click += new System.EventHandler(this.contentRichTb_Click);

            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.contentRichTb);
            this.Name = "PreviewForm";
            this.Text = "Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentRichTb;
    }
}