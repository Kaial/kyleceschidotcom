using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Collections.Generic;
using kyleceschidotcom.DAL;

namespace kyleceschidotcom.Controllers
{
   /// <summary>
   /// The main controller for the blog type logic
   /// </summary>
   public class BlogController : Controller
   {
      //the service that's used to get data
      IBlogService m_BlogService;
      int MAX = 1200;//the maximum amount of characters in a post blurb

      /// <summary>
      /// Default ctor, takes a blog service that is injected by the framework
      /// </summary>
      /// <param name="blogService"></param>
      public BlogController(IBlogService blogService)
      {
         m_BlogService = blogService;
      }
      
      public IActionResult Index()
      {
         var posts = new List<ExpandoObject>();
         foreach (var post in m_BlogService.GetRecientPosts())
         {
            dynamic expandoPost = new ExpandoObject();
            expandoPost.Title = post.Title;
            expandoPost.Created = post.Created;
            //truncate the post to 1200 characters. 
            //TODO: should probably do something a little more elegant, like by word count and embed a readmore link into the view but this works for now. 
            expandoPost.Content = post.Content.Substring(0, post.Content.Length > MAX ? MAX : post.Content.Length);
            posts.Add(expandoPost);
         }
         ViewBag.Posts = posts;
         return View();
      }
   }
}