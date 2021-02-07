using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCBookManager.Models
{
    public class Book
    {
        public Book()
        {
            IsAvailable = true;
        }
        public int Id { get; set; }
        [Display(Name = "Nome"), StringLength(60, MinimumLength = 6), Required]
        public string Name { get; set; }
        
        [Display(Name = "Autor"), Required]
        public string Author { get; set; }
       
        [DataType(DataType.Date), Display(Name = "Publicação")]
        public DateTime Year { get; set; }
       
        [Display(Name = "Categoria")]
        public string Category { get; set; }

        [Display(Name = "ISBN"), Required]
        public long Isbn { get; set; }

        [Display(Name = "Editora"), Required]
        public string PublishingHouse { get; set; }
        
        public bool IsAvailable { get; set; }
    }
}
