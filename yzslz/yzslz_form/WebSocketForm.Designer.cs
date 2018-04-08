namespace yzslz.yzslz_form
{
    partial class WebSocketForm
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
            this.btnOpenWebSocket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenWebSocket
            // 
            this.btnOpenWebSocket.Location = new System.Drawing.Point(394, 35);
            this.btnOpenWebSocket.Name = "btnOpenWebSocket";
            this.btnOpenWebSocket.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWebSocket.TabIndex = 0;
            this.btnOpenWebSocket.Text = "开启侦听";
            this.btnOpenWebSocket.UseVisualStyleBackColor = true;
            this.btnOpenWebSocket.Click += new System.EventHandler(this.btnOpenWebSocket_Click);
            // 
            // WebSocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 373);
            this.Controls.Add(this.btnOpenWebSocket);
            this.Name = "WebSocketForm";
            this.Text = "WebSocketForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenWebSocket;
    }
}