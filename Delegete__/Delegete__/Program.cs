using Delegete__.Models;
using FluentFTP.Helpers;
using System;
using static Utils.Enums.Enum;

namespace Delegete__
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Bir user obyekti yaradılsın və console-dan bütün məlumatları daxil 
          * olunsun əgər olmayan bir role daxil edilsə yenidən role dəyəri istənsin.*/
            string user = Console.ReadLine();
            string email= Console.ReadLine();
            Roler roler = new Roler();
        
            do
            {

            } while (roler!=Roler.Admin&&  roler!=Roler.Member);


        }
    }
}
