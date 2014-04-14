using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Deepak_Xerox.Entities
{
    internal class Client : INotifyPropertyChanged
    {
        public Client()
        {
            client_id = 0;
            user_name = password = string.Empty;
            active = Convert.ToBoolean(0);
        }

        private int client_id;
        public int ID
        {
            get { return client_id; }
            set { client_id = value; }
        }

        private string user_name;
        public string Name
        {
            get { return user_name; }
            set { user_name = value; }
        }

        private string password;
        public string Pass
        {
            get { return password; }
            set { password = value; }
        }

        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        void FirePropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangeHandler PropertyChanged;

        #endregion
    }
}
