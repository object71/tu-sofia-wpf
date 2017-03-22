using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Documents.Models
{
    public class Document : DependencyObject, INotifyPropertyChanged
    {
        private string documentName;
        private string documentId;
        private string description;
        private DateTime creationDate;

        public string DocumentName
        {
            get { return this.documentName; }
            set
            {
                this.documentName = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        public string DocumentId
        {
            get { return this.documentId; }
            set
            {
                this.documentId = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        public DateTime CreationDate
        {
            get { return this.creationDate; }
            set
            {
                this.creationDate = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged(string propertyName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
