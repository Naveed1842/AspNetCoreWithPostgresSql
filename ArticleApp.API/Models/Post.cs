using System;
namespace ArticleApp.API.Models{
    public class Post{
        public int Id{get;set;}
        public string Name{get;set;}
        public DateTime PostDate{get;set;}

        public string PostWriter{get;set;}
    }
}