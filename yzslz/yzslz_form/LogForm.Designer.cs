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
            this.SuspendLayout();
            // 
            // btnWriteLog
            // 
            this.btnWriteLog.Location = new System.Drawing.Point(46, 37);
            this.btnWriteLog.Name = "btnWriteLog";
            this.btnWriteLog.Size = new System.Drawing.Size(75, 23);
            this.btnWriteLog.TabIndex = 0;
            this.btnWriteLog.Text = "写txt日志";
            this.btnWriteLog.UseVisualStyleBackColor = true;
            this.btnWriteLog.Click += new System.EventHandler(this.btnWriteLog_Click);
            // 
            // txtLogMsg
            // 
            this.txtLogMsg.Location = new System.Drawing.Point(185, 12);
            this.txtLogMsg.Name = "txtLogMsg";
            this.txtLogMsg.Size = new System.Drawing.Size(336, 337);
            this.txtLogMsg.TabIndex = 1;
            this.txtLogMsg.Text = "";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.txtLogMsg);
            this.Controls.Add(this.btnWriteLog);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWriteLog;
        private System.Windows.Forms.RichTextBox txtLogMsg;
    }
}