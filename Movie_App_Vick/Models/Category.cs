using System.ComponentModel.DataAnnotations;

namespace Movie_App_Vick.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
