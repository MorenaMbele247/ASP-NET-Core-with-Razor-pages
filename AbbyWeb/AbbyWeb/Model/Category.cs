using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }//enitiy framwork will automatically make this a primary key
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
       
    }
}
