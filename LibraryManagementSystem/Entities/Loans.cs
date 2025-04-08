using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    public class Loans
    {
        [Key]
        public int loanID { get; set; }
        [ForeignKey("Users")]
        public int userID { get; set; }
        [ForeignKey("Books")]
        public int bookID { get; set; }
        [Required]
        public DateTime loandate { get; set; }
        [Required]
        public DateTime duedate { get; set; }
        public DateTime? returndate { get; set; }
        [Required, MaxLength(20)]
        public string loanstatus { get; set; }
        public Users Users { get; set; }
        public Books Books { get; set; }
    }
}
