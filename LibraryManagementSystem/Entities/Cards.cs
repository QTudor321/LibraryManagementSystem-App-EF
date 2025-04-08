using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibraryManagementSystem.Entities
{
    public class Cards
    {
        [Key]
        public int cardID { get; set; }
        [ForeignKey("Users")]
        public int userID { get; set; }
        [Required, MaxLength(20)]
        public string number { get; set; }
        [Required]
        public DateTime expiration { get; set; }
        [Required, MaxLength(3)]
        public string cvv { get; set; }
        [Required]
        public decimal credit { get; set; }
        public Users Users { get; set; }
    }
}
