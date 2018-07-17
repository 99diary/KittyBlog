using System;
using System.Collections.Generic;
using System.Text;
using KittyBlog.Model;
using KittyBlog.IDAL;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.EntityFrameworkCore; //EF

namespace KittyBlog.DAL
{
    public class PostProvider : IPostProvider
    {
        private readonly PostContext _context;
        private readonly ILogger _logger;


        public PostProvider(PostContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("PostProvider");
        }

        public bool AddOnePost(Post post)
        {
            _context.Post.Add(post);
            return _context.SaveChanges() == 1;
        }

        public bool DelOnePost(long id)
        {
            var entity = _context.Post.First(t => t.ID == id);
            _context.Post.Remove(entity);
            return _context.SaveChanges() == 1;
        }

        public bool UpdateOnePost(Post post)
        {
            _context.Post.Update(post);
            return _context.SaveChanges() == 1;
        }

        public Post GetOnePostByID(long id)
        {
            return _context.Post.First(t => t.ID == id);
        }

        public List<Post> GetPostsByAuthorID(long authorID)
        {
            return _context.Post.OrderByDescending(post => EF.Property<Int64>(post, "PublishTimeStamp")).Where(post => post.AuthorID == authorID).ToList();
            //return _context.Post.Where(post => post.AuthorID == authorID).ToList();
        }

        public List<Post> GetAllPosts()
        {
            // Using the shadow property EF.Property<DateTime>(dataEventRecord)
            return _context.Post.OrderByDescending(post => EF.Property<Int64>(post, "PublishTimeStamp")).ToList();
            //return _context.Post.ToList();
        }
    }
}
