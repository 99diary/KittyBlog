using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KittyBlog.DAL;
using KittyBlog.IDAL;
using KittyBlog.Model;
using Newtonsoft.Json;


namespace KittyBlog.Api.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostProvider _iPostProvider;

        public PostController(IPostProvider iPostProvider)
        {
            _iPostProvider = iPostProvider;
        }

        [HttpGet]
        [Route("GetPosts")]
        public IEnumerable<Post> GetPosts()
        {
            return _iPostProvider.GetAllPosts();
        }

        [HttpGet]
        [Route("AP")]
        public Page GetAllPosts()
        {
            List<Post> lst= _iPostProvider.GetAllPosts();
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
                page.Data = new Object();
            }
            return page;
        }

        //[HttpPost]
        //[Route("AddOnePost")]
        //public Page AddOnePost(Post post)
        //{
        //    _iPostProvider.AddOnePost(post);
        //}

        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}