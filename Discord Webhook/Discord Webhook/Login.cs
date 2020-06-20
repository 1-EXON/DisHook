﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Webhook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (webhookLink.Text == string.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("WebHook Link를 입력하시지 않았습니다.");

                
            }
        }

        private void webhookLink_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_in.Click += new EventHandler(log_in_Click);
            }
        }



        private void log_in_Click(object sender, EventArgs e)
        {
            if (webhookLink.Text == string.Empty)
            {
                MessageBox.Show("WebHook Link를 입력하시지 않았습니다.");
                return;
            }
            Data.discordLink = webhookLink.Text;
            this.Close();
        }
    }
}
