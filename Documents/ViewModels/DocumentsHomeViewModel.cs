using Documents.App_Data;
using Documents.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Documents.ViewModels
{
    public class DocumentsHomeViewModel : DependencyObject, INotifyPropertyChanged
    {
        DocumentsDB ctx = new DocumentsDB();

        public DocumentsHomeViewModel()
        {
            this.People = new ObservableCollection<Person>();
            foreach(Person p in ctx.People.ToArray())
            {
                this.People.Add(p);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value;
                NotifyPropertyChanged();
            }
        }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                NotifyPropertyChanged();
            }
        }
    }
}
