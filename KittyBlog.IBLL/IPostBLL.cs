using KittyBlog.Model;
using System;
using System.Collections.Generic;

namespace KittyBlog.IBLL
{
    public interface IPostBLL
    {
        bool AddOnePost(Post post);
        bool DelOnePost(Int64 id);
        bool UpdateOnePost(Post post);

        Post GetOnePostByID(Int64 id);

        List<Post> GetPostsByAuthorID(Int64 id);

        List<Post> GetAllPosts();

        List<Post> GetPostsByPage(Int32 pageNum, Int32 pageSize);
    }
}
