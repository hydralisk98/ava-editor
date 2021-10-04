
namespace Ava
{
    partial class SeekForm
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
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lbTargetTitle = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTarget
            // 
            this.tbTarget.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTarget.Location = new System.Drawing.Point(12, 64);
            this.tbTarget.MaxLength = 254;
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(280, 31);
            this.tbTarget.TabIndex = 0;
            this.tbTarget.TextChanged += new System.EventHandler(this.tbTarget_TextChanged);
            // 
            // lbTargetTitle
            // 
            this.lbTargetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTargetTitle.Location = new System.Drawing.Point(13, 9);
            this.lbTargetTitle.Name = "lbTargetTitle";
            this.lbTargetTitle.Size = new System.Drawing.Size(279, 52);
            this.lbTargetTitle.TabIndex = 1;
            this.lbTargetTitle.Text = "Target string";
            this.lbTargetTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(13, 102);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(279, 47);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbTargetTitle);
            this.Controls.Add(this.tbTarget);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Label lbTargetTitle;
        private System.Windows.Forms.Button btnFind;
    }
}