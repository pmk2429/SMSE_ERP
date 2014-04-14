using System;
using System.Collections.Generic;
using System.Text;

namespace Deepak_Xerox.Entities
{
    internal class Customer : INotifyPropertyChanged
    {
        public Customer()
        {
            user_id = 0;
            first_name = last_name = address = name_of_com = mobile = contact_no = email_id = string.Empty;

        }
        private int user_id;
        [System.ComponentModel.Bindable(false)]
        public int Id { get { return user_id; } set { user_id = value; /*FirePropertyChanged("Id");*/ } }
        
        private string first_name;
        public string Name { get { return first_name; } set { first_name = value; } }

        private string last_name;
        public string Surname { get { return last_name; } set { last_name = value; } }

        private string address;
        public string Add { get { return address; } set { address = value; } }

        private string name_of_com;
        public string NameOfCom { get { return name_of_com; } set { name_of_com = value; } }

        private string contact_no;
        public string Contact { get { return contact_no; } set { contact_no = value; } }

        private string mobile;
        public string Mobile { get { return mobile; } set { mobile = value; } }

        private string email_id;
        public string Email { get { return email_id; } set { email_id = value; } }

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

