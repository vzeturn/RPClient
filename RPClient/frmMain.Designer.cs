namespace RPClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnConnect = new System.Windows.Forms.Panel();
            this.lbNotice = new System.Windows.Forms.Label();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.cbEncryption = new System.Windows.Forms.CheckBox();
            this.lbServerPort = new System.Windows.Forms.Label();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbIV = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pnConnect.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnConnect
            // 
            this.pnConnect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnConnect.Controls.Add(this.lbNotice);
            this.pnConnect.Controls.Add(this.btDisconnect);
            this.pnConnect.Controls.Add(this.btConnect);
            this.pnConnect.Controls.Add(this.tbPort);
            this.pnConnect.Controls.Add(this.tbServerIP);
            this.pnConnect.Controls.Add(this.cbEncryption);
            this.pnConnect.Controls.Add(this.lbServerPort);
            this.pnConnect.Controls.Add(this.lbServerIP);
            this.pnConnect.Location = new System.Drawing.Point(13, 13);
            this.pnConnect.Name = "pnConnect";
            this.pnConnect.Size = new System.Drawing.Size(433, 128);
            this.pnConnect.TabIndex = 0;
            // 
            // lbNotice
            // 
            this.lbNotice.Location = new System.Drawing.Point(13, 93);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(413, 23);
            this.lbNotice.TabIndex = 7;
            this.lbNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDisconnect.Location = new System.Drawing.Point(344, 5);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 68);
            this.btDisconnect.TabIndex = 6;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = false;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btConnect.Location = new System.Drawing.Point(259, 5);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 68);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(107, 28);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(63, 20);
            this.tbPort.TabIndex = 4;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(106, 5);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(141, 20);
            this.tbServerIP.TabIndex = 3;
            // 
            // cbEncryption
            // 
            this.cbEncryption.AutoSize = true;
            this.cbEncryption.Location = new System.Drawing.Point(6, 53);
            this.cbEncryption.Name = "cbEncryption";
            this.cbEncryption.Size = new System.Drawing.Size(76, 17);
            this.cbEncryption.TabIndex = 2;
            this.cbEncryption.Text = "Encryption";
            this.cbEncryption.UseVisualStyleBackColor = true;
            // 
            // lbServerPort
            // 
            this.lbServerPort.Location = new System.Drawing.Point(3, 26);
            this.lbServerPort.Margin = new System.Windows.Forms.Padding(0);
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(100, 23);
            this.lbServerPort.TabIndex = 1;
            this.lbServerPort.Text = "Server Port";
            this.lbServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbServerIP
            // 
            this.lbServerIP.Location = new System.Drawing.Point(3, 3);
            this.lbServerIP.Margin = new System.Windows.Forms.Padding(0);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(100, 23);
            this.lbServerIP.TabIndex = 0;
            this.lbServerIP.Text = "Server IP";
            this.lbServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLogin.Controls.Add(this.tbIV);
            this.pnLogin.Controls.Add(this.tbKey);
            this.pnLogin.Controls.Add(this.lbIV);
            this.pnLogin.Controls.Add(this.lbKey);
            this.pnLogin.Controls.Add(this.cbShowPass);
            this.pnLogin.Controls.Add(this.btLogout);
            this.pnLogin.Controls.Add(this.btLogin);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.tbUsername);
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Controls.Add(this.lbUsername);
            this.pnLogin.Enabled = false;
            this.pnLogin.Location = new System.Drawing.Point(452, 13);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(433, 128);
            this.pnLogin.TabIndex = 7;
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(107, 75);
            this.tbIV.Name = "tbIV";
            this.tbIV.PasswordChar = '○';
            this.tbIV.Size = new System.Drawing.Size(140, 20);
            this.tbIV.TabIndex = 11;
            this.tbIV.Text = "aAZN15Wkbf4moBDtbLcHqw==";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(106, 52);
            this.tbKey.Name = "tbKey";
            this.tbKey.PasswordChar = '○';
            this.tbKey.Size = new System.Drawing.Size(141, 20);
            this.tbKey.TabIndex = 10;
            this.tbKey.Text = "uqMWRSpeloHI38Uyy6nFsw==";
            // 
            // lbIV
            // 
            this.lbIV.Location = new System.Drawing.Point(3, 73);
            this.lbIV.Margin = new System.Windows.Forms.Padding(0);
            this.lbIV.Name = "lbIV";
            this.lbIV.Size = new System.Drawing.Size(100, 23);
            this.lbIV.TabIndex = 9;
            this.lbIV.Text = "IV";
            this.lbIV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbKey
            // 
            this.lbKey.Location = new System.Drawing.Point(3, 50);
            this.lbKey.Margin = new System.Windows.Forms.Padding(0);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(100, 23);
            this.lbKey.TabIndex = 8;
            this.lbKey.Text = "Key";
            this.lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(3, 99);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbShowPass.TabIndex = 7;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLogout.Location = new System.Drawing.Point(344, 5);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 68);
            this.btLogout.TabIndex = 6;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btLogin.Location = new System.Drawing.Point(259, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 68);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(107, 28);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '○';
            this.tbPassword.Size = new System.Drawing.Size(140, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(106, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(141, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(3, 26);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 23);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(3, 3);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(100, 23);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 525);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "RPClient";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnConnect.ResumeLayout(false);
            this.pnConnect.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.CheckBox cbEncryption;
        private System.Windows.Forms.Label lbServerPort;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lbIV;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Label lbNotice;
    }
}

