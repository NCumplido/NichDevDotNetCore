using NichDevDotNetCore.Data;
using NichDevDotNetCore.Models;
using System.Collections.Generic;

namespace NichDevDotNetCore.Repositories;

public class PostRepository
{
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IReadOnlyList<Comment> GetAllCommentsByPost(int postId)
    {
        var comments = _context.Comments.Where(c => c.PostId == postId).ToList();
        return comments;
    }
}
