﻿namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public Author Author { get; set; }
    }
}
