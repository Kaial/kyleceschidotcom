using kyleceschidotcom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyleceschidotcom.DAL
{
   public interface IBlogService
   {
      /// <summary>
      /// Gets the 10 most recient posts from the datastore, whatever that store may be
      /// </summary>
      /// <returns></returns>
      IEnumerable<Post> GetRecientPosts();
      
      /// /// <summary>
      /// returns a post by it's title, in this blog the titles will be unique identifiers. 
      /// </summary>
      /// <param name="title"></param>
      /// <returns></returns>
      Post GetPostByTitle(string title);
   }
}
