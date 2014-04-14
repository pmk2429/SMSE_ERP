using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Deepak_Xerox.Entities;

namespace Deepak_Xerox
{
    public partial class AdvPanel : Panel , IDataBinder
    {
        public AdvPanel()
        {
            InitializeComponent();
        }

        public AdvPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region IDataBinder Members
        private object ds;
        public object DataSource
        {
            get { return ds; }
            set
            {
                ds = value;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is IDataBinder)
                        (this.Controls[i] as IDataBinder).DataSource = ds;
                }
            }
        }

        public string PropertyName
        {
            get { return string.Empty; }
            set { }
        }

        public string FormatString
        {
            get { return string.Empty; }
            set { }
        }

        #endregion

        #region IDataBinder Members

        object IDataBinder.DataSource
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        string IDataBinder.PropertyName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        string IDataBinder.FormatString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
