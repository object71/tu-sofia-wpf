using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Documents.Models
{
    public class Person : DependencyObject, INotifyPropertyChanged
    {
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        private void NotifyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<Document> Documents { get; set; }

        public Person()
        {
            Documents = new ObservableCollection<Document>();
        }
    }
}
