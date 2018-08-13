namespace yzslz.yzslz_form
{
    partial class NetTestForm
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(22, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(634, 21);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "www.baidu.com";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(679, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(22, 39);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(732, 605);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // NetTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 656);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtUrl);
            this.Name = "NetTestForm";
            this.Text = "NetTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}