namespace yzslz.yzslz_form
{
    partial class FileForm
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(21, 21);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(135, 21);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(822, 310);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 352);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}