using System;
using System.Collections.Generic;
using System.Text;

namespace Deepak_Xerox
{
    interface INotifyPropertyChanged
    {
        event PropertyChangeHandler PropertyChanged;
    }
    public delegate void PropertyChangeHandler(object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        string propertyName;
        public string PropertyName
        {
            get { return propertyName; }
        }
        public PropertyEventArgs(string PropertyName)
        {
            propertyName = PropertyName;
        }
    }
}
