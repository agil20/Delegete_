using Delegete__.Models;
using FluentFTP.Helpers;
using System;
using static Utils.Enums.Enum;

namespace Delegete__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rolerr;
            do
            {
                Console.WriteLine("Zehmet olmasa user daxil edin"); string user = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa email daxil edin"); string email = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa roler daxil edin\n" +
                    "Admin ve ya Member secin");  rolerr = Console.ReadLine();
            } while (Rollers(rolerr) == false);
            do
                {
                    Console.WriteLine("1.Add book\n" +
                      "2. Get book by id\n" +
                      "3. Get all books\n" +
                      "4. Delete book by id\n" +
                      "5. Edit book name\n" +
                      "6. Filter by page count\n" +
                      "0. Quit");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    Library library = new Library();

                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Kitabin adini daxil edin");
                            string name = Console.ReadLine();
                            Console.WriteLine("Muelifi qeyd edin");
                            string muellif = Console.ReadLine();
                            Console.WriteLine("Sayi daxil edin qeyd edin");
                            int count = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(name, muellif, count);
                            library.AddBook(book);
                            break;
                            case 2:
                            Console.WriteLine("Id ni daxil edin");
                            int id=Convert.ToInt32(Console.ReadLine());
                            library.GetBookById(id);
                            
                            
                            break;
                        default:
                            break;
                    }


                } while (true); 

              
          


    }    
        
        //roller icin elave bir methot yaratdim
        public static  bool Rollers(string roler)
        {
            bool loop;
            Roler rolerr;
            
                if (roler == "Admin")
                { 
                    rolerr = Roler.Admin; loop = true;
                  
                }
                else if (roler == "Member")
                {
                    rolerr = Roler.Member; loop = true; 
                }
             
                else
                { loop = false; }

            return loop;
           

        }
    }
    }