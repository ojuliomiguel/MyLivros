using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCBookManager.Data;
using System.Linq;

namespace MVCBookManager.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
               serviceProvider
                .GetRequiredService<DbContextOptions<MvcBookContext>>()
                 )
             )
            {
                if (context.Book.Any())
                {
                    return; //DB has datas
                }

                context.Book.AddRange(
                    new Book
                    {
                        Name = "O Hobbit",
                        Author = "J.R.R Tolkien",
                        Category = "Fantasia",
                        Year = DateTime.Parse("1937-9-21"),
                        Isbn = 9781234567897,
                        PublishingHouse = "WMF Martins Fontes"

                    },
                    new Book
                    {
                        Name = "Além do Planeta Silencioso",
                        Author = "C. S. Lewis",
                        Category = "Ficção Científica",
                        Year = DateTime.Parse("1938-10-22"),
                        Isbn = 7891234567456,
                        PublishingHouse = "WMF Martins Fontes"

                    },
                    new Book
                    {
                        Name = "The Call of Cthulhu",
                        Author = "H. P Lovecraft",
                        Category = "Terror",
                        Year = DateTime.Parse("1928-11-01"),
                        Isbn = 1531275967456,
                        PublishingHouse = "Companhia das Letras"
                    },
                    new Book
                    {
                        Name = "O milagre da manhã",
                        Author = "Hal Elrod",
                        Category = "Desenvolvimento Pessoal",
                        Year = DateTime.Parse("2016-09-01"),
                        Isbn = 1531275967456,
                        PublishingHouse = "Alta book"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
