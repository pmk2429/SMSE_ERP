using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Deepak_Xerox.Properties;
using Deepak_Xerox.Entities;
using Deepak_Xerox.DAL;

namespace Deepak_Xerox
{

    public partial class Login : Form
    {
        Client clnt;
        public Login()
        {
            InitializeComponent();
            auth = false;
        }
        bool auth;

        private void Login_Load(object sender, EventArgs e)
        {
            ResetLogin(true,false);
            txt_userid.Focus();
            txt_password.PasswordChar = '*';
            btn_login.Focus();
            btn_Register.Visible = false;
        }

        private void txt_userid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AuthenticateUser();
        }

        private void AuthenticateUser()
        {
            if (txt_userid.Text == "" && txt_password.Text == "")
            {
                auth = false;
                MessageBox.Show("Please enter User Name/Password!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.DialogResult = DialogResult.OK;


            }
            else
            {
                if (txt_userid.Text.Trim().Length > 0 && txt_password.Text.Trim().Length > 0)
                {
                    string Query = "SELECT COUNT(*) from Client_login where user_name = '" + txt_userid.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "'";
                    int Count = new LoginManager().GetCount(Query);
                    if (Count > 0)
                    {
                        auth = true;
                        this.DialogResult = DialogResult.OK;
                        Personal_Details pd = new Personal_Details();
                        pd.Show();
                        this.Hide();
                    }
                    else
                    {
                        auth = false;
                        MessageBox.Show("Invalid User Name/Password!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_userid.Focus();
                    }
                }


            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!auth)
            {
                if (MessageBox.Show("You haven't logged in! Would you like to quit?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;

                }
                else
                {
                    e.Cancel = true;
                    txt_userid.Focus();
                }
            }
        }



        private void lbtnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblHeader.Text = "Register";
            btn_login.Visible = false;
            btn_Register.Visible = true;
            clnt = new Client();
            ResetLogin(true, true);
            

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            AuthenticateUser();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txt_userid.Text.Trim().Length > 0 && txt_password.Text.Trim().Length > 0)
            {
                clnt.Name = txt_userid.Text;
                clnt.Pass = txt_password.Text;
                clnt.Active = Convert.ToBoolean(false);
                if (new LoginManager().InsertClient(clnt) > 0)
                {
                    MessageBox.Show("Client Registered!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetLogin(true,false);

                }
                else
                {
                    MessageBox.Show("Client registration failed!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetLogin(bool isEnabled, bool isActive)
        {
            pnlLogin.Enabled = isEnabled;
            btn_Register.Enabled = isActive;
            btn_login.Enabled = isEnabled;
            txt_userid.Enabled = isEnabled;
            txt_password.Enabled = isEnabled;
            lbtn_login.Visible = isActive;
            txt_userid.Focus();
        }

        private void lbtn_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            lblHeader.Text = "Login";
            btn_login.Visible = true;
            btn_Register.Visible = false;
            ResetLogin(true, false);
        }

        
    }
}
