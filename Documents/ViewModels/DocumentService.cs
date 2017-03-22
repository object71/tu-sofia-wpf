using Documents.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Documents.ViewModels
{
    public class DocumentService : DependencyObject, INotifyPropertyChanged
    {
        private ObservableCollection<Person> people;

        public ObservableCollection<Person> People
        {
            get { return this.people; }
            set
            {
                this.people = value;
                NotifyChanged(MethodBase.GetCurrentMethod().Name);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public DocumentService()
        {
            people = new ObservableCollection<Person>();

            Document document = new Document()
            {
                DocumentName = "Personal ID",
                DocumentId = "ABCD-666-999",
                CreationDate = DateTime.Now,
                Description = "Simple ID",
            };

            Person person = new Person()
            {
                Name = "Stanley",
            };

            person.Documents.Add(document);

            people.Add(person);


        }
    }
}
