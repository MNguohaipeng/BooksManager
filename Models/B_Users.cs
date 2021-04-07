


using System.ComponentModel.DataAnnotations;

namespace BooksManager.Models
{

    public class B_Users
    {
        public int ID { get; set; }
        [MaxLength(100)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(100)]
        [Required]
        public string Password { get; set; }


    }




}