using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]

        public int IdEditorial { get; set; }
        public string Title { get; set; }
        public DateOnly FechaPub { get; set; }
        public int Pages { get; set; }
    }
}
