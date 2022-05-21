namespace NichDevDotNetCore.Models.ViewModels
{
    public class PostsViewModel
    {
        public string Content { get; set; }

        public IQueryable<Comment>? Comments { get; set; }
    }
}