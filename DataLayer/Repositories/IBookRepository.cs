using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    interface IBookRepository
    {
        void Add(Book book);
        bool Delete(int id);
        Book Find(int id);
        Book Find(int id, string authorName, string publisherName, string yearPublished);
        bool Update(Book book);
        IList<Book> GetAll();

        IList<Book> Find(IList<SearchParam> searchParams);
        IList<Book> Find(IList<SearchParam> searchParams, int pageNum, int pageSize);
        

    }


    

}
