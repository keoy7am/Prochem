namespace Prochem1
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_ComPort = new System.Windows.Forms.ComboBox();
            this.cb_Bitrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LockConnection = new System.Windows.Forms.Button();
            this.btn_UnlockConnection = new System.Windows.Forms.Button();
            this.btn_White = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.btn_Standard = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cb_ComPort
            // 
            this.cb_ComPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_ComPort.Font = new System.Drawing.Font("新細明體", 18F);
            this.cb_ComPort.FormattingEnabled = true;
            this.cb_ComPort.Items.AddRange(new object[] {
            " COM1",
            " COM1"});
            this.cb_ComPort.Location = new System.Drawing.Point(53, 21);
            this.cb_ComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ComPort.Name = "cb_ComPort";
            this.cb_ComPort.Size = new System.Drawing.Size(92, 32);
            this.cb_ComPort.TabIndex = 0;
            this.cb_ComPort.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.cb_ComPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBox1_MouseClick);
            // 
            // cb_Bitrate
            // 
            this.cb_Bitrate.Font = new System.Drawing.Font("新細明體", 18F);
            this.cb_Bitrate.FormattingEnabled = true;
            this.cb_Bitrate.Location = new System.Drawing.Point(53, 58);
            this.cb_Bitrate.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Bitrate.Name = "cb_Bitrate";
            this.cb_Bitrate.Size = new System.Drawing.Size(92, 32);
            this.cb_Bitrate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "連接埠";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // btn_LockConnection
            // 
            this.btn_LockConnection.Location = new System.Drawing.Point(183, 20);
            this.btn_LockConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LockConnection.Name = "btn_LockConnection";
            this.btn_LockConnection.Size = new System.Drawing.Size(82, 35);
            this.btn_LockConnection.TabIndex = 4;
            this.btn_LockConnection.Text = "鎖定連接";
            this.btn_LockConnection.UseVisualStyleBackColor = true;
            this.btn_LockConnection.Click += new System.EventHandler(this.Btn_LockConnection_Click);
            // 
            // btn_UnlockConnection
            // 
            this.btn_UnlockConnection.Enabled = false;
            this.btn_UnlockConnection.Location = new System.Drawing.Point(183, 57);
            this.btn_UnlockConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UnlockConnection.Name = "btn_UnlockConnection";
            this.btn_UnlockConnection.Size = new System.Drawing.Size(82, 35);
            this.btn_UnlockConnection.TabIndex = 5;
            this.btn_UnlockConnection.Text = "解除鎖定";
            this.btn_UnlockConnection.UseVisualStyleBackColor = true;
            this.btn_UnlockConnection.Click += new System.EventHandler(this.Btn_UnlockConnection_Click);
            // 
            // btn_White
            // 
            this.btn_White.Enabled = false;
            this.btn_White.Location = new System.Drawing.Point(272, 57);
            this.btn_White.Margin = new System.Windows.Forms.Padding(2);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(82, 35);
            this.btn_White.TabIndex = 7;
            this.btn_White.Text = "白板校正";
            this.btn_White.UseVisualStyleBackColor = true;
            this.btn_White.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Enabled = false;
            this.btn_Zero.Location = new System.Drawing.Point(272, 20);
            this.btn_Zero.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(82, 35);
            this.btn_Zero.TabIndex = 6;
            this.btn_Zero.Text = "零點校正";
            this.btn_Zero.UseVisualStyleBackColor = true;
            this.btn_Zero.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btn_Compare
            // 
            this.btn_Compare.Enabled = false;
            this.btn_Compare.Location = new System.Drawing.Point(362, 57);
            this.btn_Compare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(82, 35);
            this.btn_Compare.TabIndex = 9;
            this.btn_Compare.Text = "測量比較";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btn_Standard
            // 
            this.btn_Standard.Enabled = false;
            this.btn_Standard.Location = new System.Drawing.Point(362, 20);
            this.btn_Standard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Standard.Name = "btn_Standard";
            this.btn_Standard.Size = new System.Drawing.Size(82, 35);
            this.btn_Standard.TabIndex = 8;
            this.btn_Standard.Text = "測量標準";
            this.btn_Standard.UseVisualStyleBackColor = true;
            this.btn_Standard.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 251);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Compare);
            this.Controls.Add(this.btn_Standard);
            this.Controls.Add(this.btn_White);
            this.Controls.Add(this.btn_Zero);
            this.Controls.Add(this.btn_UnlockConnection);
            this.Controls.Add(this.btn_LockConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Bitrate);
            this.Controls.Add(this.cb_ComPort);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Prochem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ComPort;
        private System.Windows.Forms.ComboBox cb_Bitrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LockConnection;
        private System.Windows.Forms.Button btn_UnlockConnection;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.Button btn_Zero;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.Button btn_Standard;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

