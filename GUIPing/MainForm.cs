using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace GUIPing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(urlTextBox.Text))
            {
                using (Ping ping = new Ping())
                {
                    try
                    {
                        PingReply reply = ping.Send(urlTextBox.Text);

                        if (reply.Status == IPStatus.Success)
                        {
                            ipTextBox.Text = reply.Address.ToString();
                            timeTextBox.Text = String.Format("{0} ms", reply.RoundtripTime.ToString());

                            Clipboard.SetText(ipTextBox.Text);
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Error Occured: {0}", reply.Status.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (PingException pingEx)
                    {
                        MessageBox.Show(pingEx.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}