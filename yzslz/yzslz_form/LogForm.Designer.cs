namespace yzslz.yzslz_form
{
    partial class LogForm
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
            this.btnWriteLog = new System.Windows.Forms.Button();
            this.txtLogMsg = new System.Windows.Forms.RichTextBox();
            this.txtReadTxt = new System.Windows.Forms.RichTextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWriteLog
            // 
            this.btnWriteLog.Location = new System.Drawing.Point(12, 10);
            this.btnWriteLog.Name = "btnWriteLog";
            this.btnWriteLog.Size = new System.Drawing.Size(75, 23);
            this.btnWriteLog.TabIndex = 0;
            this.btnWriteLog.Text = "写txt日志";
            this.btnWriteLog.UseVisualStyleBackColor = true;
            this.btnWriteLog.Click += new System.EventHandler(this.btnWriteLog_Click);
            // 
            // txtLogMsg
            // 
            this.txtLogMsg.Location = new System.Drawing.Point(12, 203);
            this.txtLogMsg.Name = "txtLogMsg";
            this.txtLogMsg.Size = new System.Drawing.Size(336, 337);
            this.txtLogMsg.TabIndex = 1;
            this.txtLogMsg.Text = "";
            // 
            // txtReadTxt
            // 
            this.txtReadTxt.Location = new System.Drawing.Point(357, 12);
            this.txtReadTxt.Name = "txtReadTxt";
            this.txtReadTxt.Size = new System.Drawing.Size(681, 528);
            this.txtReadTxt.TabIndex = 2;
            this.txtReadTxt.Text = "";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 163);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(259, 21);
            this.txtFilePath.TabIndex = 3;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(273, 163);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFile.TabIndex = 4;
            this.btnSearchFile.Text = "浏览";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 552);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtReadTxt);
            this.Controls.Add(this.txtLogMsg);
            this.Controls.Add(this.btnWriteLog);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteLog;
        private System.Windows.Forms.RichTextBox txtLogMsg;
        private System.Windows.Forms.RichTextBox txtReadTxt;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSearchFile;
    }
}