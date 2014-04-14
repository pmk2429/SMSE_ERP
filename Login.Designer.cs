namespace Deepak_Xerox
{
    partial class Login
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
            this.pnlLogin = new Deepak_Xerox.AdvPanel(this.components);
            this.txt_password = new Deepak_Xerox.AdvTextBox();
            this.txt_userid = new Deepak_Xerox.AdvTextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbtnRegister = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtn_login = new System.Windows.Forms.LinkLabel();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lbtn_login);
            this.pnlLogin.Controls.Add(this.txt_password);
            this.pnlLogin.Controls.Add(this.txt_userid);
            this.pnlLogin.Controls.Add(this.btn_Register);
            this.pnlLogin.Controls.Add(this.lbtnRegister);
            this.pnlLogin.Controls.Add(this.lblHeader);
            this.pnlLogin.Controls.Add(this.btn_login);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.DataSource = null;
            this.pnlLogin.FormatString = "";
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.PropertyName = "";
            this.pnlLogin.Size = new System.Drawing.Size(409, 259);
            this.pnlLogin.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.DataSource = null;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.FormatString = null;
            this.txt_password.Location = new System.Drawing.Point(142, 108);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PropertyName = null;
            this.txt_password.Size = new System.Drawing.Size(194, 21);
            this.txt_password.TabIndex = 1;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_userid_KeyDown);
            // 
            // txt_userid
            // 
            this.txt_userid.DataSource = null;
            this.txt_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.FormatString = null;
            this.txt_userid.Location = new System.Drawing.Point(142, 72);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.PropertyName = null;
            this.txt_userid.Size = new System.Drawing.Size(194, 21);
            this.txt_userid.TabIndex = 0;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Register.Location = new System.Drawing.Point(182, 153);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(92, 34);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "REGISTER";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbtnRegister
            // 
            this.lbtnRegister.AutoSize = true;
            this.lbtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnRegister.Location = new System.Drawing.Point(184, 211);
            this.lbtnRegister.Name = "lbtnRegister";
            this.lbtnRegister.Size = new System.Drawing.Size(86, 15);
            this.lbtnRegister.TabIndex = 4;
            this.lbtnRegister.TabStop = true;
            this.lbtnRegister.Text = "Register Here!";
            this.lbtnRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnRegister_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeader.Location = new System.Drawing.Point(187, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(65, 25);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(182, 152);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 34);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID: ";
            // 
            // lbtn_login
            // 
            this.lbtn_login.AutoSize = true;
            this.lbtn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtn_login.Location = new System.Drawing.Point(12, 9);
            this.lbtn_login.Name = "lbtn_login";
            this.lbtn_login.Size = new System.Drawing.Size(34, 15);
            this.lbtn_login.TabIndex = 18;
            this.lbtn_login.TabStop = true;
            this.lbtn_login.Text = "Back";
            this.lbtn_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtn_login_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 292);
            this.Controls.Add(this.pnlLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvPanel pnlLogin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.LinkLabel lbtnRegister;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AdvTextBox txt_userid;
        private AdvTextBox txt_password;
        private System.Windows.Forms.LinkLabel lbtn_login;
    }
}