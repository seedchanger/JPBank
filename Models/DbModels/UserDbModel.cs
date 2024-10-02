using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JPBank.Models.DbModels
{
    public class UserDbModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string? Name { get; set; } 
        [Required]
        public string? Email { get; set; } 
        [Required]
        public string? Password { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}
