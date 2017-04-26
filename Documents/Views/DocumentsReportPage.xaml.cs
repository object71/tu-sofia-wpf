using Documents.Models;
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
    /// Interaction logic for DocumentsReportPage.xaml
    /// </summary>
    public partial class DocumentsReportPage : Page
    {
        public DocumentsReportPage()
        {
            InitializeComponent();
        }

        // Custom constructor to pass expense report data 
        public DocumentsReportPage(object data):this() {
            Person person = data as Person;
            // Bind to expense report data. 
            this.DataContext = person;
        }
    }
}
