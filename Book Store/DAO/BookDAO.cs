using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance 
        {
            get { if (instance == null) instance = new BookDAO(); return instance; } 
            private set => instance = value; 
        }

        private BookDAO() { }

        public List<Book> LoadBookList()
        {
            List<Book> bookList = new List<Book>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBookList");

            foreach (DataRow row in data.Rows)
            {
                Book book = new Book(row);  
                bookList.Add(book);
            }
            return bookList;
        }
    }
}
