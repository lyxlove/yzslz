﻿namespace yzslz
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLog = new System.Windows.Forms.Button();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnSerialPort = new System.Windows.Forms.Button();
            this.btnDBTest = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.txtRegx = new System.Windows.Forms.Button();
            this.btnRegistry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(23, 29);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "日志";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Location = new System.Drawing.Point(23, 71);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDB.TabIndex = 1;
            this.btnConnectDB.Text = "数据库链接";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(23, 110);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(75, 23);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "线程";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(23, 152);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(75, 23);
            this.btnPort.TabIndex = 3;
            this.btnPort.Text = "端口测试";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // btnSerialPort
            // 
            this.btnSerialPort.Location = new System.Drawing.Point(23, 196);
            this.btnSerialPort.Name = "btnSerialPort";
            this.btnSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPort.TabIndex = 4;
            this.btnSerialPort.Text = "串口测试";
            this.btnSerialPort.UseVisualStyleBackColor = true;
            this.btnSerialPort.Click += new System.EventHandler(this.btnSerialPort_Click);
            // 
            // btnDBTest
            // 
            this.btnDBTest.Location = new System.Drawing.Point(23, 237);
            this.btnDBTest.Name = "btnDBTest";
            this.btnDBTest.Size = new System.Drawing.Size(75, 23);
            this.btnDBTest.TabIndex = 5;
            this.btnDBTest.Text = "数据库测试";
            this.btnDBTest.UseVisualStyleBackColor = true;
            this.btnDBTest.Click += new System.EventHandler(this.btnDBTest_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(23, 278);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "文件操作";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnNet
            // 
            this.btnNet.Location = new System.Drawing.Point(23, 316);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(75, 23);
            this.btnNet.TabIndex = 8;
            this.btnNet.Text = "网络编程";
            this.btnNet.UseVisualStyleBackColor = true;
            this.btnNet.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // txtRegx
            // 
            this.txtRegx.Location = new System.Drawing.Point(127, 29);
            this.txtRegx.Name = "txtRegx";
            this.txtRegx.Size = new System.Drawing.Size(75, 23);
            this.txtRegx.TabIndex = 9;
            this.txtRegx.Text = "正则";
            this.txtRegx.UseVisualStyleBackColor = true;
            this.txtRegx.Click += new System.EventHandler(this.txtRegx_Click);
            // 
            // btnRegistry
            // 
            this.btnRegistry.Location = new System.Drawing.Point(127, 71);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(75, 23);
            this.btnRegistry.TabIndex = 10;
            this.btnRegistry.Text = "注册表";
            this.btnRegistry.UseVisualStyleBackColor = true;
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.btnRegistry);
            this.Controls.Add(this.txtRegx);
            this.Controls.Add(this.btnNet);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnDBTest);
            this.Controls.Add(this.btnSerialPort);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnConnectDB);
            this.Controls.Add(this.btnLog);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnSerialPort;
        private System.Windows.Forms.Button btnDBTest;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnNet;
        private System.Windows.Forms.Button txtRegx;
        private System.Windows.Forms.Button btnRegistry;
    }
}

