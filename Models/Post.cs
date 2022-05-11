using System.ComponentModel.DataAnnotations;

namespace NichDevDotNetCore.Models
{
    public class Post
    {
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        public IQueryable<Comment>? Comments { get; set; }
    }
}