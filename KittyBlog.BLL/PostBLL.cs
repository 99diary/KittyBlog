using KittyBlog.IBLL;
using KittyBlog.IDAL;
using KittyBlog.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KittyBlog.BLL
{
    public class PostBLL:IPostBLL
    {
        private readonly IPostProvider _iPostProvider;

        public PostBLL(IPostProvider iPostProvider)
        {
            this._iPostProvider = iPostProvider;
        }

        public bool AddOnePost(Post post)
        {
            return _iPostProvider.AddOnePost(post);
        }
        public bool DelOnePost(Int64 id)
        {
            return _iPostProvider.DelOnePost(id);
        }
        public bool UpdateOnePost(Post post)
        {
            return _iPostProvider.UpdateOnePost(post);
        }

        public List<Post> GetAllPosts()
        {
            return _iPostProvider.GetAllPosts().ToList();
        }
        public Post GetOnePostByID(Int64 id)
        {
            return _iPostProvider.GetAllPosts().First(t => t.ID == id);
        }

        public List<Post> GetPostsByAuthorID(Int64 authorID)
        {
            return _iPostProvider.GetAllPosts().Where(post => post.AuthorID == authorID).ToList();
        }

        public List<Post> GetPostsByPage(Int32 pageNum, Int32 pageSize)
        {
            return _iPostProvider.GetAllPosts().OrderByDescending(post => EF.Property<Int64>(post, "PublishTimeStamp")).Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();
        }

    }
}
