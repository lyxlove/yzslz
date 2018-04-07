namespace yzslz.Tools
{
    partial class TxtWithLab
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labHead = new System.Windows.Forms.Label();
            this.txtContant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Dock = System.Windows.Forms.DockStyle.Left;
            this.labHead.Location = new System.Drawing.Point(0, 0);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(41, 12);
            this.labHead.TabIndex = 0;
            this.labHead.Text = "label1";
            // 
            // txtContant
            // 
            this.txtContant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContant.Location = new System.Drawing.Point(41, 0);
            this.txtContant.Name = "txtContant";
            this.txtContant.Size = new System.Drawing.Size(192, 21);
            this.txtContant.TabIndex = 1;
            // 
            // TxtWithLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContant);
            this.Controls.Add(this.labHead);
            this.Name = "TxtWithLab";
            this.Size = new System.Drawing.Size(233, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHead;
        private System.Windows.Forms.TextBox txtContant;
    }
}
