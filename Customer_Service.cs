using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deepak_Xerox
{
    public partial class Customer_Service : Form
    {
        public Customer_Service()
        {
            InitializeComponent();
        }

        private void Customer_Service_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            View_Billing vb = new View_Billing();
            vb.Show();
            this.Close();
        }

        
    }
}
