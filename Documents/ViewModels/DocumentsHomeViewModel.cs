using Documents.App_Data;
using Documents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Documents.ViewModels
{
    public class DocumentsHomeViewModel : INotifyPropertyChanged
    {
        DocumentsDB ctx = new DocumentsDB();

        public DocumentsHomeViewModel()
        {
            this.Authors = ctx.People.ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private List<Person> _people;
        public List<Person> Authors
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
