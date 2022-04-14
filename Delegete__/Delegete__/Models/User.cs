
using System;
using static Utils.Enums.Enum;

namespace Delegete__.Models
{
    internal class User : IEntity
    {

        public string UserName { get; set; }
        public string Email { get; set; }

        public int Id
        {
           get { return Id; }
        }

        Roler Roler { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"User Name {UserName}\n" +
                $"Email {Email}\n" +
                $"id {Id}");
        }
        /*ps: Username, email, role olmadan user obyekti yaratmaq olmaz
*/      public User(string username,string email,Roler roler)

        {
            UserName = username; Email = email; Roler = roler; 
        }


    }
}