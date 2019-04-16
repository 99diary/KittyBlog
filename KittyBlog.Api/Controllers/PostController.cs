using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KittyBlog.IDAL;
using KittyBlog.Model;
using Newtonsoft.Json;
using KittyBlog.API.Controllers;
using KittyBlog.API.Filter;
using KittyBlog.BLL;

namespace KittyBlog.Api.Controllers
{
    [Route("api/[controller]")]
    public class PostController : BaseController
    {
        private IPostProvider _iPostProvider;

        public PostController(IPostProvider iPostProvider)
        {
            _iPostProvider = iPostProvider;
        }

        PostBLL postBLL = new PostBLL(_iPostProvider);

        //[HttpGet]
        //public IEnumerable<Post> GetPosts()
        //{
        //    return _iPostProvider.GetAllPosts();
        //}
        
        //[HttpPost]
        //[Route("AddOnePost")]
        //public Page AddOnePost(Post post)
        //{
        //    Page page = new Page();
        //    page.Success = _iPostProvider.AddOnePost(post);
        //    page.Code = page.Success ? EnumCode.Success : EnumCode.Failed;
        //    return page;
        //}

        //[HttpPost("{id}")]
        //[Route("DelOnePost")]
        //public Page DelOnePost(Int64 id)
        //{
        //    Page page = new Page();
        //    page.Success = _iPostProvider.DelOnePost(id);
        //    page.Code = page.Success ? EnumCode.Success : EnumCode.Failed;
        //    return page;
        //}

        //[HttpPost]
        //[Route("UpdateOnePost")]
        //public Page UpdateOnePost(Post post)
        //{
        //    Page page = new Page();
        //    page.Success = _iPostProvider.UpdateOnePost(post);
        //    page.Code = page.Success?EnumCode.Success:EnumCode.Failed;
        //    return page;
        //}

        //[HttpPost]
        //[Route("GetOnePostByID")]
        //public Page GetOnePostByID(Int64 id)
        //{
        //    Page page = new Page();
        //    page.Data = _iPostProvider.GetOnePostByID(id); ;
        //    page.Success = page.Data != null;
        //    page.Code = page.Success ? EnumCode.Success : EnumCode.Failed;
        //    return page;
        //}

        [HttpGet]
        [TokenFilterAttribute()]
        [Route("GetAllPosts")]
        public Page GetAllPosts()
        {
            List<Post> lst = postBLL.GetAllPosts();
            Page page = new Page();
            if (lst.Count >= 0)
            {
                page.Success = true;
                page.Code = EnumCode.Success;
                page.Data = lst;
            }
            else
            {
                page.Success = false;
                page.Code = EnumCode.DataError;
            }
            return page;
        }


        //[HttpPost("{authorID}")]
        //[Route("GetPostsByAuthorID")]
        //public Page GetPostsByAuthorID(Int64 authorID)
        //{
        //    List<Post> lst = _iPostProvider.GetPostsByAuthorID(authorID);
        //    Page page = new Page();
        //    if (lst.Count >= 0)
        //    {
        //        page.Success = true;
        //        page.Code = EnumCode.Success;
        //        page.Data = lst;
        //    }
        //    else
        //    {
        //        page.Success = false;
        //        page.Code = EnumCode.DataError;
        //    }
        //    return page;
        //}



        //// GET: Post
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Post/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Post/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Post/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Post/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Post/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Post/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Post/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}