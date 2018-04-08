namespace yzslz.yzslz_form.ChildForm
{
    partial class TestPortForm
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIsUse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(180, 25);
            this.txtPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            // 
            // btnIsUse
            // 
            this.btnIsUse.Location = new System.Drawing.Point(305, 31);
            this.btnIsUse.Name = "btnIsUse";
            this.btnIsUse.Size = new System.Drawing.Size(141, 23);
            this.btnIsUse.TabIndex = 2;
            this.btnIsUse.Text = "占用测试";
            this.btnIsUse.UseVisualStyleBackColor = true;
            this.btnIsUse.Click += new System.EventHandler(this.btnIsUse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 397);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnGetIP
            // 
            this.btnGetIP.Location = new System.Drawing.Point(305, 60);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(141, 23);
            this.btnGetIP.TabIndex = 4;
            this.btnGetIP.Text = "获取本机ip";
            this.btnGetIP.UseVisualStyleBackColor = true;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // TestPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.btnGetIP);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnIsUse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Name = "TestPortForm";
            this.Text = "TestPortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIsUse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGetIP;
    }
}