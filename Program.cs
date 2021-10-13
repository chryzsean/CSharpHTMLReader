using System;
using HtmlAgilityPack;
using System.Linq;
namespace CSharpHTMLReader


{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://en.wikipedia.org/wiki/HTML"); // View page source


            var title = document.DocumentNode.SelectNodes("//*[@id=\"firstHeading\"]").First().InnerText; // scraping h1 inside div
            var paragraphs = document.DocumentNode.SelectNodes("//*[@id=\"mw-content-text\"]/div[1]/p");
            
            Console.WriteLine(title);
            Console.WriteLine();
            //Console.WriteLine(paragraphs);
            paragraphs.ToList().ForEach(i => Console.WriteLine(i.InnerText));


        }
    }
}
