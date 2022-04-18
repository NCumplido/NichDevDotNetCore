using System.ComponentModel.DataAnnotations;

namespace NichDevDotNetCore.Models.ViewModels
{
    public class EditPostViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
