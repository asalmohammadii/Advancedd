using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Midnight Library";
            book.Year = 2020;
            book.Author = " Matt Haig";
            book.ISBN = "978 - 622 - 254 - 343 - 3";
            book.PrintInfo();
            book.Title = " Atomic Habits";
            book.Year = 2018;
            book.Author = "James Clear";
            book.ISBN =" 978 - 622 - 6611 - 78 - 7";
            book.PrintInfo();
            book.Title = "La Nuit DesChandelles";
            book.Year = 1960;
            book.Author = " Pozsgai Zsolt";
            book.ISBN = "978 - 600 - 405 - 316 - 7";
            book.PrintInfo();
            Member member = new Member();
            member.MemberID = 1;
            member.Name = " Asal Mhmdi";
            member.Phone = "905-651-1570";
            member.PrintMemberInfo();
            member.MemberID = 2;
            member.Name = " Ali Zare";
            member.Phone = "917-117-1723";
            member.PrintMemberInfo();
            member.MemberID = 3;
            member.Name = " Neda Monfrd";
            member.Phone = "936-548-1230";
            member.PrintMemberInfo();



        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title},Author:{Author},Year:{Year},ISBN:{ISBN}");

        }
    }
    public class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public string Phone { get; set; }
        public void PrintMemberInfo()
        {
            Console.WriteLine($"MemberID:{MemberID}, Name:{Name},Phone:{Phone}");
        }
    }
}


