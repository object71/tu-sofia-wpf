using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExampleMVVM
{
    public class MainWindowViewModel : DependencyObject, INotifyPropertyChanged
    {
        private ICommand hiButtonCommand;
        private ICommand toggleExecuteCommand { get; set; }
        private bool canExecute = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public void PropChanged(String propertyName)
        {
            //Did WPF registerd to listen to this event
            if (PropertyChanged != null)
            {
                //Tell WPF that this property changed
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string outputContent;

        public string OutputContent { get { return outputContent; } set { this.outputContent = value; PropChanged("OutputContent"); } }

        public string HiButtonContent { get { return "Click to hi"; } }
        public bool CanExecute
        {
            get { return this.canExecute; }
            set
            {
                if (this.canExecute == value) { return; }
                this.canExecute = value;
            }
        }
        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand;
            }
            set
            {
                toggleExecuteCommand = value;
            }
        }
        public ICommand HiButtonCommand
        {
            get
            {
                return hiButtonCommand;
            }
            set
            {
                hiButtonCommand = value;
            }
        }
        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }
        public void ShowMessage(object obj)
        {
            //it is good we do this with binding to some control
            //System.Windows.MessageBox.Show(obj.ToString());
            this.OutputContent = "" + DateTime.Now.ToLongTimeString() + " Program said: Hi ";
        }
        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }

    }
}
