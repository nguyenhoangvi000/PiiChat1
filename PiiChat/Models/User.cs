using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiiChat.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _username;
        public event PropertyChangedEventHandler PropertyChanged;

        public User(string name)
        {
            this.Title = name;
        }

        public string Title
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged("Title");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        
    }
}
