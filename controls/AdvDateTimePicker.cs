using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Deepak_Xerox.Entities;

namespace Deepak_Xerox
{
    public partial class AdvDateTimePicker : DateTimePicker, IDataBinder
    {
        public AdvDateTimePicker()
        {
            InitializeComponent();
            this.LostFocus += new EventHandler(AdvDateTimePicker_LostFocus);
        }

        void AdvDateTimePicker_LostFocus(object sender, EventArgs e)
        {
            if (ds != null && propertyName != null && propertyName.Length > 0)
                ((PropertyInfo)ds.GetType().GetProperty(propertyName)).SetValue(ds, this.Text, null);
        }

        #region IDataBindSetter Members
        private string propertyName;
        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; BindData(); }
        }
        private string formatString;
        public string FormatString
        {
            get { return formatString; }
            set { formatString = value; }
        }
        private object ds;
        [System.ComponentModel.Browsable(false)]
        public object DataSource
        {
            get { return ds; }
            set
            {
                ds = value;
                if (ds == null) this.Value = DateTime.Now; 
                BindData();
            }
        }

        private void BindData()
        {
            try
            {
                if (ds != null && propertyName != null && propertyName.Length > 0)
                {
                    PropertyInfo pi = ds.GetType().GetProperty(propertyName);
                    if (pi != null)
                        this.Text = pi.GetValue(ds, null).ToString();
                }
            }
            catch
            {
            }
        }
        #endregion
    }
}
