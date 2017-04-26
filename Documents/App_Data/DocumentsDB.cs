namespace Documents.App_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class DocumentsDB : DbContext
    {
        public DocumentsDB()
            : base("name=DocumentsDB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Document> Documents { get; set; }

    }
}
