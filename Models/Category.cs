using System.ComponentModel.DataAnnotations;

namespace bulkyweb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplaOrder { get; set; }
    }
}
