namespace Deepak_Xerox
{
    partial class View_Billing
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
            this.panel_viewbilling = new System.Windows.Forms.Panel();
            this.pb_logo3 = new System.Windows.Forms.PictureBox();
            this.lbl_viewbill = new System.Windows.Forms.Label();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.lbl_searchmonth = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_searchorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvw_orderdetail = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.deepakXeroxDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deepakXeroxDataSource = new Deepak_Xerox.DeepakXeroxDataSource();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.customer_DetailsTableAdapter = new Deepak_Xerox.DeepakXeroxDataSourceTableAdapters.Customer_DetailsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dtp_enddate = new Deepak_Xerox.AdvDateTimePicker();
            this.txt_searchfield = new Deepak_Xerox.AdvTextBox();
            this.dtp_startdate = new Deepak_Xerox.AdvDateTimePicker();
            this.panel_viewbilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_viewbilling
            // 
            this.panel_viewbilling.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_viewbilling.Controls.Add(this.pb_logo3);
            this.panel_viewbilling.Controls.Add(this.lbl_viewbill);
            this.panel_viewbilling.Location = new System.Drawing.Point(1, 1);
            this.panel_viewbilling.Margin = new System.Windows.Forms.Padding(5);
            this.panel_viewbilling.Name = "panel_viewbilling";
            this.panel_viewbilling.Size = new System.Drawing.Size(940, 95);
            this.panel_viewbilling.TabIndex = 1;
            // 
            // pb_logo3
            // 
            this.pb_logo3.Location = new System.Drawing.Point(16, 8);
            this.pb_logo3.Margin = new System.Windows.Forms.Padding(5);
            this.pb_logo3.Name = "pb_logo3";
            this.pb_logo3.Size = new System.Drawing.Size(98, 79);
            this.pb_logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo3.TabIndex = 2;
            this.pb_logo3.TabStop = false;
            // 
            // lbl_viewbill
            // 
            this.lbl_viewbill.AutoSize = true;
            this.lbl_viewbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewbill.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_viewbill.Location = new System.Drawing.Point(430, 34);
            this.lbl_viewbill.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_viewbill.Name = "lbl_viewbill";
            this.lbl_viewbill.Size = new System.Drawing.Size(118, 22);
            this.lbl_viewbill.TabIndex = 1;
            this.lbl_viewbill.Text = "Billing Details\r\n";
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToDeleteRows = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.btndelete});
            this.dgv_order.Location = new System.Drawing.Point(9, 293);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersVisible = false;
            this.dgv_order.Size = new System.Drawing.Size(921, 173);
            this.dgv_order.TabIndex = 2;
            this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Width = 70;
            // 
            // btndelete
            // 
            this.btndelete.HeaderText = "Delete";
            this.btndelete.Name = "btndelete";
            this.btndelete.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By:";
            // 
            // cb_search
            // 
            this.cb_search.DisplayMember = "First Name";
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "First_Name",
            "Last_Name",
            "Mobile Number",
            "Company Name"});
            this.cb_search.Location = new System.Drawing.Point(172, 144);
            this.cb_search.Margin = new System.Windows.Forms.Padding(4);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(141, 23);
            this.cb_search.TabIndex = 1;
            // 
            // lbl_searchmonth
            // 
            this.lbl_searchmonth.AutoSize = true;
            this.lbl_searchmonth.Location = new System.Drawing.Point(96, 193);
            this.lbl_searchmonth.Name = "lbl_searchmonth";
            this.lbl_searchmonth.Size = new System.Drawing.Size(73, 15);
            this.lbl_searchmonth.TabIndex = 20;
            this.lbl_searchmonth.Text = "Start Month:";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(430, 487);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(100, 30);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "&PRINT";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select the options mentioned below:\r\n";
            // 
            // btn_searchorder
            // 
            this.btn_searchorder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_searchorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_searchorder.Location = new System.Drawing.Point(430, 236);
            this.btn_searchorder.Name = "btn_searchorder";
            this.btn_searchorder.Size = new System.Drawing.Size(100, 30);
            this.btn_searchorder.TabIndex = 5;
            this.btn_searchorder.Text = "Search";
            this.btn_searchorder.UseVisualStyleBackColor = false;
            this.btn_searchorder.Click += new System.EventHandler(this.btn_searchorder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "Specify the selected Option:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "End Month:";
            // 
            // lvw_orderdetail
            // 
            this.lvw_orderdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_orderdetail.GridLines = true;
            this.lvw_orderdetail.Location = new System.Drawing.Point(17, 325);
            this.lvw_orderdetail.Name = "lvw_orderdetail";
            this.lvw_orderdetail.Size = new System.Drawing.Size(902, 133);
            this.lvw_orderdetail.TabIndex = 77;
            this.lvw_orderdetail.UseCompatibleStateImageBehavior = false;
            this.lvw_orderdetail.View = System.Windows.Forms.View.Details;
            this.lvw_orderdetail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 80;
            // 
            // deepakXeroxDataSourceBindingSource
            // 
            this.deepakXeroxDataSourceBindingSource.DataSource = this.deepakXeroxDataSource;
            this.deepakXeroxDataSourceBindingSource.Position = 0;
            // 
            // deepakXeroxDataSource
            // 
            this.deepakXeroxDataSource.DataSetName = "DeepakXeroxDataSource";
            this.deepakXeroxDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "Customer_Details";
            this.customerDetailsBindingSource.DataSource = this.deepakXeroxDataSource;
            // 
            // customer_DetailsTableAdapter
            // 
           // this.customer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.CausesValidation = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(508, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 109);
            this.listBox1.TabIndex = 81;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.DataSource = null;
            this.dtp_enddate.FormatString = null;
            this.dtp_enddate.Location = new System.Drawing.Point(508, 193);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.PropertyName = null;
            this.dtp_enddate.Size = new System.Drawing.Size(140, 21);
            this.dtp_enddate.TabIndex = 4;
            this.dtp_enddate.Value = new System.DateTime(2013, 5, 3, 0, 0, 0, 0);
            // 
            // txt_searchfield
            // 
            this.txt_searchfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_searchfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_searchfield.DataSource = null;
            this.txt_searchfield.FormatString = null;
            this.txt_searchfield.Location = new System.Drawing.Point(508, 143);
            this.txt_searchfield.Name = "txt_searchfield";
            this.txt_searchfield.PropertyName = null;
            this.txt_searchfield.Size = new System.Drawing.Size(250, 21);
            this.txt_searchfield.TabIndex = 2;
            this.txt_searchfield.TextChanged += new System.EventHandler(this.txt_searchfield_TextChanged);
            this.txt_searchfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchfield_KeyDown);
            this.txt_searchfield.Leave += new System.EventHandler(this.txt_searchfield_Leave);
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.DataSource = null;
            this.dtp_startdate.FormatString = null;
            this.dtp_startdate.Location = new System.Drawing.Point(172, 193);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.PropertyName = null;
            this.dtp_startdate.Size = new System.Drawing.Size(141, 21);
            this.dtp_startdate.TabIndex = 3;
            this.dtp_startdate.Value = new System.DateTime(2013, 5, 3, 0, 0, 0, 0);
            // 
            // View_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 530);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_enddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvw_orderdetail);
            this.Controls.Add(this.txt_searchfield);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_startdate);
            this.Controls.Add(this.btn_searchorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_searchmonth);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.panel_viewbilling);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "View_Billing";
            this.Text = "View_Billing";
            this.Load += new System.EventHandler(this.View_Billing_Load);
            this.panel_viewbilling.ResumeLayout(false);
            this.panel_viewbilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_viewbilling;
        private System.Windows.Forms.PictureBox pb_logo3;
        private System.Windows.Forms.Label lbl_viewbill;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Label lbl_searchmonth;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_searchorder;
        private AdvDateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label5;
        private AdvTextBox txt_searchfield;
        private AdvDateTimePicker dtp_enddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvw_orderdetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btndelete;
        private System.Windows.Forms.BindingSource deepakXeroxDataSourceBindingSource;
        private DeepakXeroxDataSource deepakXeroxDataSource;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        //private Deepak_Xerox.DeepakXeroxDataSourceTableAdapters.Customer_DetailsTableAdapter customer_DetailsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}