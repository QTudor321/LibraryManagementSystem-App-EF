using System.ComponentModel.DataAnnotations;
namespace LibraryManagementSystem.Entities
{
    public class Users
    {
        [Key]
        public int userID { get; set; }
        [Required, MaxLength(50)]
        public string username { get; set; }
        [Required, MaxLength(50)]
        public string lastname { get; set; }
        [Required, MaxLength(50)]
        public string firstname { get; set; }
        [Required, MaxLength(50)]
        public string address { get; set; }
        [Required, MaxLength(50)]
        public string password { get; set; }
        [Required]
        public byte subscriptionstatus { get; set; }
        [Required]
        public byte isLibrarian { get; set; }
        public ICollection<Cards> Cards { get; set; }

    }
}
