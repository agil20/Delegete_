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
            
            
            
                foreach (var item in Books)
            {
                if (item.IsDelated())
                {
                   
                }
                else
                {
                    if (book.Name == item.Name)
                    {
                        Exceptions.Alread();

                    }
                    else
                    {
                        if (book.Count <= BookLimit)
                        {
                            Books.Add(book);
                            Console.WriteLine($"{item.Name} adli kitab elave olundu");
                        }
                        else
                        {
                            Exceptions.Capasit();

                        }

                    }
                }
                   

                }
           




      }
        /*- GetBookById() - parametr olaraq nullable int tipindən bir id qəbul edəcək həmin id-li və isDeleted 
         * statusu false olan Book obyketini tapıb geriyə 
         * qaytaracaq əgər id null gələrsə NullReferenceException
         * qaytaracaq əgər heç bir kitab tapmasa null  qaytaracaq.*/
        public void GetBookById(int ? id)
        {
            foreach (var item in Books)
            {
                if (item.IsDelated())
                {

                }
                else
                {
                    if (id==item.Id)
                    {
                        item.ShowInfo(); return;
                    }
                    

                    
                }

            }
            if (id==null)
            {
                throw new Exception("NullReferenceException");
            }

   



        }
        /*EditBookName() - parametr olaraq int tipindən nullable bir id qəbul edəcək həmin id-li
    * book-u tapıb name-ni dəyişəcək əgər id null olarsa NullReferenceException qaytaracaq əgər elə bir
    * book tapmasa NotFoundException qaytaracaq.
    *
*/    public void EditBookName(int? id)
        {
            foreach (var item in Books)
            {
                if (item.Id==id)
                { 
                    
              item.Name = null;
                    item.Name = Console.ReadLine();
                    Console.WriteLine($"Elave olundu {item.Name}");
                    item.ShowInfo(); return;

                }
                else
                {
                    Exceptions.NotFaund();
                }
                if (id==null)
                {
                   throw new Exception("NullReferenceException");

                }
            }
        }
        /*- FilterByPageCount() - parametr olaraq minPageCount və maxPageCount qəbul
         * edəcək bu aralıqda olan və isDeleted
         * statusu false olan book obyektlərini tapıb geriyə qaytaracaq.*/

        public void FilterByPageCount(int minPageCount,int maxPageCount)
        {
            foreach (var item in Books)
            {
                if (!(item.Count<=minPageCount&& item.Count>=maxPageCount&& item.IsDelated()))
                {
                    item.ShowInfo();

                }

            }
        }
    }
}
