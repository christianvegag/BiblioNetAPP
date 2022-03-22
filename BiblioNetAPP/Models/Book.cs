using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int IdEditorial { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaPub { get; set; }
        public int Pages { get; set; }
    }
}
