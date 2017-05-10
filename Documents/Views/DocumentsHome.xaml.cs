using Documents.Models;
using Documents.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Documents.Views
{
    /// <summary>
    /// Interaction logic for DocumentsHome.xaml
    /// </summary>
    public partial class DocumentsHome : Page
    {

        public DocumentsHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DocumentsReportPage documentsReportPage = new DocumentsReportPage(this.peopleListBox.SelectedItem);
            //this.NavigationService.Navigate(documentsReportPage);
        }

        private void addPerson_Click(object sender, RoutedEventArgs e)
        {
            DocumentsHomeViewModel model = (DocumentsHomeViewModel)this.DataContext;
            Person person = new Person();
            person.Name = "Person-" + model.People.Count();
            person.Job = "Unemployed";
            model.People.Add(person);

            model.SelectedPerson = person;
        }
    }
}
