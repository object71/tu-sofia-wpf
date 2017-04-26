using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_EF_Mvvm_sample
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        BookStoreDBEntities ctx = new BookStoreDBEntities();

        public MainWindowViewModel()
        {
            FillAuthors();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private List<Author> _authors; public List<Author> Authors
        {
            get
            {
                return _authors;
            }
            set
            {
                _authors = value; NotifyPropertyChanged();
            }
        }
        private List<Book> _books; public List<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value; NotifyPropertyChanged();
            }
        }
        private Book _selectedBook; public Book SelectedBook
        {
            get
            {
                return _selectedBook;
            }
            set
            {
                _selectedBook = value; NotifyPropertyChanged();
            }
        }

        private Author _selectedAuthor;

        public Author SelectedAuthor
        {
            get
            {
                return _selectedAuthor;
            }
            set
            {
                _selectedAuthor = value;
                NotifyPropertyChanged();
                FillBook();
            }
        }

        private void FillAuthors()
        {
            var q = ctx.Authors.ToList();
            this.Authors = q;
        }

        private void FillBook()
        {
            Author author = this.SelectedAuthor;
            var q = ctx.Books.Where(x => x.AuthorId == author.Id).OrderBy(x => x.Title).ToList();
            this.Books = q;
        }

    }
}
