namespace yzslz.yzslz_form
{
    partial class SerialPortForm
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
            this.components = new System.ComponentModel.Container();
            this.combSerialPortOne = new System.Windows.Forms.ComboBox();
            this.btnOpenPortOne = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRateOne = new System.Windows.Forms.TextBox();
            this.txtCheckPositionOne = new System.Windows.Forms.TextBox();
            this.txtDataPositionOne = new System.Windows.Forms.TextBox();
            this.txtStopPositionOne = new System.Windows.Forms.TextBox();
            this.txtSendContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceiveContent = new System.Windows.Forms.RichTextBox();
            this.txtStopPositionTwo = new System.Windows.Forms.TextBox();
            this.txtDataPositionTwo = new System.Windows.Forms.TextBox();
            this.txtCheckPositionTwo = new System.Windows.Forms.TextBox();
            this.txtRateTwo = new System.Windows.Forms.TextBox();
            this.combSerialPortTwo = new System.Windows.Forms.ComboBox();
            this.btnOpenPortTwo = new System.Windows.Forms.Button();
            this.btnPortTwoReceive = new System.Windows.Forms.Button();
            this.btnProtOneSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combSerialPortOne
            // 
            this.combSerialPortOne.FormattingEnabled = true;
            this.combSerialPortOne.Location = new System.Drawing.Point(130, 24);
            this.combSerialPortOne.Name = "combSerialPortOne";
            this.combSerialPortOne.Size = new System.Drawing.Size(170, 20);
            this.combSerialPortOne.TabIndex = 0;
            // 
            // btnOpenPortOne
            // 
            this.btnOpenPortOne.Location = new System.Drawing.Point(242, 416);
            this.btnOpenPortOne.Name = "btnOpenPortOne";
            this.btnOpenPortOne.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPortOne.TabIndex = 1;
            this.btnOpenPortOne.Text = "打开串口";
            this.btnOpenPortOne.UseVisualStyleBackColor = true;
            this.btnOpenPortOne.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProtOneSend);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSendContent);
            this.groupBox1.Controls.Add(this.txtStopPositionOne);
            this.groupBox1.Controls.Add(this.txtDataPositionOne);
            this.groupBox1.Controls.Add(this.txtCheckPositionOne);
            this.groupBox1.Controls.Add(this.txtRateOne);
            this.groupBox1.Controls.Add(this.combSerialPortOne);
            this.groupBox1.Controls.Add(this.btnOpenPortOne);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 445);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPortTwoReceive);
            this.groupBox2.Controls.Add(this.btnOpenPortTwo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtReceiveContent);
            this.groupBox2.Controls.Add(this.txtStopPositionTwo);
            this.groupBox2.Controls.Add(this.txtDataPositionTwo);
            this.groupBox2.Controls.Add(this.txtCheckPositionTwo);
            this.groupBox2.Controls.Add(this.txtRateTwo);
            this.groupBox2.Controls.Add(this.combSerialPortTwo);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 445);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收";
            // 
            // txtRateOne
            // 
            this.txtRateOne.Location = new System.Drawing.Point(130, 59);
            this.txtRateOne.Name = "txtRateOne";
            this.txtRateOne.Size = new System.Drawing.Size(170, 21);
            this.txtRateOne.TabIndex = 2;
            // 
            // txtCheckPositionOne
            // 
            this.txtCheckPositionOne.Location = new System.Drawing.Point(130, 95);
            this.txtCheckPositionOne.Name = "txtCheckPositionOne";
            this.txtCheckPositionOne.Size = new System.Drawing.Size(170, 21);
            this.txtCheckPositionOne.TabIndex = 3;
            // 
            // txtDataPositionOne
            // 
            this.txtDataPositionOne.Location = new System.Drawing.Point(130, 131);
            this.txtDataPositionOne.Name = "txtDataPositionOne";
            this.txtDataPositionOne.Size = new System.Drawing.Size(170, 21);
            this.txtDataPositionOne.TabIndex = 4;
            // 
            // txtStopPositionOne
            // 
            this.txtStopPositionOne.Location = new System.Drawing.Point(130, 167);
            this.txtStopPositionOne.Name = "txtStopPositionOne";
            this.txtStopPositionOne.Size = new System.Drawing.Size(170, 21);
            this.txtStopPositionOne.TabIndex = 5;
            // 
            // txtSendContent
            // 
            this.txtSendContent.Location = new System.Drawing.Point(6, 203);
            this.txtSendContent.Name = "txtSendContent";
            this.txtSendContent.Size = new System.Drawing.Size(311, 200);
            this.txtSendContent.TabIndex = 6;
            this.txtSendContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "波特率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "串口";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "串口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "波特率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "数据位";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "停止位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "校验位";
            // 
            // txtReceiveContent
            // 
            this.txtReceiveContent.Location = new System.Drawing.Point(11, 204);
            this.txtReceiveContent.Name = "txtReceiveContent";
            this.txtReceiveContent.Size = new System.Drawing.Size(311, 200);
            this.txtReceiveContent.TabIndex = 17;
            this.txtReceiveContent.Text = "";
            // 
            // txtStopPositionTwo
            // 
            this.txtStopPositionTwo.Location = new System.Drawing.Point(135, 168);
            this.txtStopPositionTwo.Name = "txtStopPositionTwo";
            this.txtStopPositionTwo.Size = new System.Drawing.Size(170, 21);
            this.txtStopPositionTwo.TabIndex = 16;
            // 
            // txtDataPositionTwo
            // 
            this.txtDataPositionTwo.Location = new System.Drawing.Point(135, 132);
            this.txtDataPositionTwo.Name = "txtDataPositionTwo";
            this.txtDataPositionTwo.Size = new System.Drawing.Size(170, 21);
            this.txtDataPositionTwo.TabIndex = 15;
            // 
            // txtCheckPositionTwo
            // 
            this.txtCheckPositionTwo.Location = new System.Drawing.Point(135, 96);
            this.txtCheckPositionTwo.Name = "txtCheckPositionTwo";
            this.txtCheckPositionTwo.Size = new System.Drawing.Size(170, 21);
            this.txtCheckPositionTwo.TabIndex = 14;
            // 
            // txtRateTwo
            // 
            this.txtRateTwo.Location = new System.Drawing.Point(135, 60);
            this.txtRateTwo.Name = "txtRateTwo";
            this.txtRateTwo.Size = new System.Drawing.Size(170, 21);
            this.txtRateTwo.TabIndex = 13;
            // 
            // combSerialPortTwo
            // 
            this.combSerialPortTwo.FormattingEnabled = true;
            this.combSerialPortTwo.Location = new System.Drawing.Point(135, 25);
            this.combSerialPortTwo.Name = "combSerialPortTwo";
            this.combSerialPortTwo.Size = new System.Drawing.Size(170, 20);
            this.combSerialPortTwo.TabIndex = 12;
            // 
            // btnOpenPortTwo
            // 
            this.btnOpenPortTwo.Location = new System.Drawing.Point(247, 416);
            this.btnOpenPortTwo.Name = "btnOpenPortTwo";
            this.btnOpenPortTwo.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPortTwo.TabIndex = 23;
            this.btnOpenPortTwo.Text = "打开串口";
            this.btnOpenPortTwo.UseVisualStyleBackColor = true;
            this.btnOpenPortTwo.Click += new System.EventHandler(this.btnOpenPortTwo_Click);
            // 
            // btnPortTwoReceive
            // 
            this.btnPortTwoReceive.Location = new System.Drawing.Point(166, 416);
            this.btnPortTwoReceive.Name = "btnPortTwoReceive";
            this.btnPortTwoReceive.Size = new System.Drawing.Size(75, 23);
            this.btnPortTwoReceive.TabIndex = 24;
            this.btnPortTwoReceive.Text = "接收数据";
            this.btnPortTwoReceive.UseVisualStyleBackColor = true;
            // 
            // btnProtOneSend
            // 
            this.btnProtOneSend.Location = new System.Drawing.Point(161, 416);
            this.btnProtOneSend.Name = "btnProtOneSend";
            this.btnProtOneSend.Size = new System.Drawing.Size(75, 23);
            this.btnProtOneSend.TabIndex = 12;
            this.btnProtOneSend.Text = "发送数据";
            this.btnProtOneSend.UseVisualStyleBackColor = true;
            this.btnProtOneSend.Click += new System.EventHandler(this.btnProtOneSend_Click);
            // 
            // SerialPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerialPortForm";
            this.Text = "SerialPortForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combSerialPortOne;
        private System.Windows.Forms.Button btnOpenPortOne;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProtOneSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSendContent;
        private System.Windows.Forms.TextBox txtStopPositionOne;
        private System.Windows.Forms.TextBox txtDataPositionOne;
        private System.Windows.Forms.TextBox txtCheckPositionOne;
        private System.Windows.Forms.TextBox txtRateOne;
        private System.Windows.Forms.Button btnPortTwoReceive;
        private System.Windows.Forms.Button btnOpenPortTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtReceiveContent;
        private System.Windows.Forms.TextBox txtStopPositionTwo;
        private System.Windows.Forms.TextBox txtDataPositionTwo;
        private System.Windows.Forms.TextBox txtCheckPositionTwo;
        private System.Windows.Forms.TextBox txtRateTwo;
        private System.Windows.Forms.ComboBox combSerialPortTwo;
    }
}