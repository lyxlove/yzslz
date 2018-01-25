namespace yzslz.yzslz_form
{
    partial class ThreadForm
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
            this.btnMulitRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMulitRead
            // 
            this.btnMulitRead.Location = new System.Drawing.Point(13, 13);
            this.btnMulitRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMulitRead.Name = "btnMulitRead";
            this.btnMulitRead.Size = new System.Drawing.Size(100, 29);
            this.btnMulitRead.TabIndex = 2;
            this.btnMulitRead.Text = "多线程读取";
            this.btnMulitRead.UseVisualStyleBackColor = true;
            this.btnMulitRead.Click += new System.EventHandler(this.btnMulitRead_Click);
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 375);
            this.Controls.Add(this.btnMulitRead);
            this.Name = "ThreadForm";
            this.Text = "ThreadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMulitRead;
    }
}