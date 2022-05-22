﻿namespace NichDevDotNetCore.Models.ViewModels
{
    public class PostsViewModel
    {
        public IEnumerable<Post>? Posts { get; set; }   
        public string Content { get; set; }

        public IQueryable<Comment>? Comments { get; set; }
    }
}