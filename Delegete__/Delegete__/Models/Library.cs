using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Exceptions;

namespace Delegete__.Models
{
    internal class Library : IEntity
    {
        public int Id { get { return Id; } }
        /*- BookLimit
- Books - Book obyektlərini özündə saxlayan bir list olacaq və private olacaq*/
        public int BookLimit { get; set; }
        private List<Book> Books = new List<Book>();
  /*- AddBook() - parametr olaraq bir Book obyekti qəbul edəcək ilk olaraq yoxlayacaq ki 
   * listdə həmin book-un name-i ilə eyni name-də olan başqa book obyekti varsa əlavə etməyəcək
   * həmçinin bu yoxlanışda baxmaq lazımdıki isDeleted dəyəri false olanlara baxsın true olanları 
   * yoxlamasın əgər həmin name-də book varsa AlreadyExistsException geriyə qaytarılsın 
 * əks halda Book obyektini books listinə əlavə etsin əgər limir aşılarsa CapacityLimitException baş versin.*/
  public void AddBook(Book book)
        {
            if (book.IsDelated( book))
            {

            }
            else
            {
                foreach (var item in Books)
                {
                    if (book.Name == item.Name)
                    {
                        Exceptions.Alread();

                    }
                    else
                    {

                        
                    }

                }


            }



        }

    }
}
