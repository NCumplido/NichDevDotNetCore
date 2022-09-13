using NichDevDotNetCore.Data;
using NichDevDotNetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace NichDevDotNetCore.Repositories;

public class PostRepository
{
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IReadOnlyList<Post> GetAll()
    {
        var posts = _context.Posts.ToList();
        return posts;
    }

    public IReadOnlyList<Comment> GetAllCommentsByPost(int postId)
    {
        var comments = _context.Comments.Where(c => c.PostId == postId).ToList();
        return comments;
    }
}
