
namespace Ava
{
    partial class ReplaceForm
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.lbTargetTitle = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.tbReplacement = new System.Windows.Forms.TextBox();
            this.lbReplaceTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplace.Location = new System.Drawing.Point(11, 166);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(279, 60);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lbTargetTitle
            // 
            this.lbTargetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTargetTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTargetTitle.Name = "lbTargetTitle";
            this.lbTargetTitle.Size = new System.Drawing.Size(278, 40);
            this.lbTargetTitle.TabIndex = 4;
            this.lbTargetTitle.Text = "Target string";
            this.lbTargetTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbTarget
            // 
            this.tbTarget.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTarget.Location = new System.Drawing.Point(11, 52);
            this.tbTarget.MaxLength = 254;
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(279, 31);
            this.tbTarget.TabIndex = 3;
            this.tbTarget.TextChanged += new System.EventHandler(this.tbTarget_TextChanged);
            // 
            // tbReplacement
            // 
            this.tbReplacement.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplacement.Location = new System.Drawing.Point(11, 129);
            this.tbReplacement.MaxLength = 254;
            this.tbReplacement.Name = "tbReplacement";
            this.tbReplacement.Size = new System.Drawing.Size(279, 31);
            this.tbReplacement.TabIndex = 3;
            this.tbReplacement.TextChanged += new System.EventHandler(this.tbReplacement_TextChanged);
            // 
            // lbReplaceTitle
            // 
            this.lbReplaceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbReplaceTitle.Location = new System.Drawing.Point(11, 86);
            this.lbReplaceTitle.Name = "lbReplaceTitle";
            this.lbReplaceTitle.Size = new System.Drawing.Size(279, 40);
            this.lbReplaceTitle.TabIndex = 4;
            this.lbReplaceTitle.Text = "Replacement string";
            this.lbReplaceTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 242);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lbReplaceTitle);
            this.Controls.Add(this.lbTargetTitle);
            this.Controls.Add(this.tbReplacement);
            this.Controls.Add(this.tbTarget);
            this.Name = "ReplaceForm";
            this.Text = "ReplaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label lbTargetTitle;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbReplacement;
        private System.Windows.Forms.Label lbReplaceTitle;
    }
}