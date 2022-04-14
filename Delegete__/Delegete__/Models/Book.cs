using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegete__.Models
{
    internal class Book : IEntity
    {/*Book class (IEntity-ni implement edəcək)
- Name
- AuthorName
- PageCount
- IsDeleted - book obyektinin silinib silinmədiyini göstərən bir statusdur true/false olur default olaraq false olur yəni silinməmiş
- ShowInfo()*/
        public int Id { get;  }
        public Book()
        {
            _id++;
            Id = _id;
        }
      
        private int _id;
        private string muellif;

        public int Count { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public bool IsDelated()

        {  bool result = false;

            return result;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Kitabin adi {Name}\n" +
                $"Muellifin adi {AuthorName}\n" +
               
                $"Id si {Id}\n" +
                $"Kitabin sayi {Count}");
        }/*ps: Name, authorName, pageCount olmadan book obyekti yaratmaq olmaz*/
        public Book(string name,string authorname,int pagecount,int count)
        { Name = name; AuthorName = authorname; PageCount = pagecount; 
            Count = count; 
        }

        public Book(string name, string muellif, int count)
        {
            Name = name;
            this.muellif = muellif;
            Count = count;
        }
    }
}
