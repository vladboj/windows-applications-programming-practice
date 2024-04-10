using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_lucrat_pentru_paw.Entities
{
    public class Book : IComparable<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }

        public Book() { }

        public Book(int id, string title, DateTime creationDate)
        {
            Id = id;
            Title = title;
            CreationDate = creationDate;
        }

        public int CompareTo(Book other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
