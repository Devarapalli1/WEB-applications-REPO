using System.ComponentModel.DataAnnotations;

namespace WebApiGiris.VievModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}