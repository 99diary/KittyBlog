using System;
using System.Collections.Generic;
using KittyBlog.Model;

namespace KittyBlog.IDAL
{
    public interface IPostProvider
    {
        bool AddOnePost(Post post);
        bool DelOnePost(Int64 id);
        bool UpdateOnePost(Post post);

        Post GetOnePostByID(Int64 id);

        List<Post> GetPostsByAuthorID(Int64 id);

        List<Post> GetAllPosts();
    }
}
