namespace NichDevDotNetCore.Models.ViewModels
{
    public class PostsViewModel
    {
        public string Content { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}