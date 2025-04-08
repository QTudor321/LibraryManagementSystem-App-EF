using System.ComponentModel.DataAnnotations;
namespace LibraryManagementSystem.Entities
{
    public class Books
    {
        [Key]
        public int bookID { get; set; }
        [Required, MaxLength(50)]
        public string theme { get; set; }
        [Required, MaxLength(50)]
        public string title { get; set; }
        [Required, MaxLength(50)]
        public string author { get; set; }
        [Required, MaxLength(30)]
        public string identifier { get; set; }
        [Required]
        public int copies { get; set; }
        [Required]
        public decimal price { get; set; }
    }
}
