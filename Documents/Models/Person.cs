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
    public class Person : DependencyObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public virtual ICollection<Document> Documents { get; set; }

        public Person()
        {
            Documents = new List<Document>();
        }
    }
}
