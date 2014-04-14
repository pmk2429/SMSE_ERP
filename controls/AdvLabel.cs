using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Deepak_Xerox
{
    public partial class AdvLabel : Label, IDataBinder
    {
        public AdvLabel()
        {
            InitializeComponent();            
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
                if (ds == null) this.Text = string.Empty;
                BindData();
            }
        }

        private void BindData()
        {
            if (ds != null && propertyName.Length > 0)
            {
                foreach (PropertyInfo pi in ds.GetType().GetProperties())
                {
                    if (pi.Name == propertyName)
                        this.Text = pi.GetValue(ds, null).ToString();
                }
            }
        }
        #endregion
    }
}
