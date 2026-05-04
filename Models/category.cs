
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.Hosting;

namespace bulkybookweb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
      [Display(Name = "Display order")]
      [Range(1,100,ErrorMessage="display order must be between 1 and 100")]
              public int DisplayOrder { get; set; }
    }
}