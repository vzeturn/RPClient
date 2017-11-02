using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iptb;

namespace RPClient
{
    public partial class frmMain : Form
    {
        string sServerIP, sPort, sKey, sIV, sUsername, sPassword;

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbKey.PasswordChar = '\0';
                tbIV.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '○';
                tbKey.PasswordChar = '○';
                tbIV.PasswordChar = '○';
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            sServerIP = tbServerIP.Text;
            sPort = tbPort.Text;
            lbNotice.Text = "Đã kết nối tới máy chủ " + sServerIP +":"+sPort;
        }
    }
}
