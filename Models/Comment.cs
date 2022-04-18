using System.ComponentModel.DataAnnotations;

namespace NichDevDotNetCore.Models
{
    public class Comment
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
        public int PostId { get; set; }
        [Required]
        [MinLength(2), MaxLength(60)]
        public string Content { get; set; }
    }
}