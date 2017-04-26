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
    public class Document : DependencyObject
    {
        //private string documentName;
        //private string documentId;
        //private string description;
        //private DateTime creationDate;

        //public string DocumentName
        //{
        //    get { return this.documentName; }
        //    set
        //    {
        //        this.documentName = value;
        //        NotifyChanged(MethodBase.GetCurrentMethod().Name);
        //    }
        //}

        public int Id { get; set; }

        public string DocumentId { get; set; }

        public string DocumentName { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
}
}
