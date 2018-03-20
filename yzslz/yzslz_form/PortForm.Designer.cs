namespace yzslz.yzslz_form
{
    partial class PortForm
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
            this.btnProtTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProtTest
            // 
            this.btnProtTest.Location = new System.Drawing.Point(12, 26);
            this.btnProtTest.Name = "btnProtTest";
            this.btnProtTest.Size = new System.Drawing.Size(75, 23);
            this.btnProtTest.TabIndex = 0;
            this.btnProtTest.Text = "端口测试";
            this.btnProtTest.UseVisualStyleBackColor = true;
            this.btnProtTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 349);
            this.Controls.Add(this.btnProtTest);
            this.Name = "PortForm";
            this.Text = "PortForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProtTest;
    }
}