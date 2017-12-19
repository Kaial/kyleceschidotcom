using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kyleceschidotcom.Models;

namespace kyleceschidotcom.DAL
{
    /// <summary>
   /// A test blog service that implements the IBlogService interface, this is used so we don't actually need a database for testing and getting the app running. 
   /// </summary>
   public class BlogServiceTest : IBlogService
   {
      private const string FILLER_TEXT = 
         @"Sed fermentum mattis malesuada. Nullam vitae dolor in tortor vulputate dictum. Nulla luctus tellus arcu, quis porttitor erat lacinia tincidunt. Proin sollicitudin, enim sed ultricies facilisis, turpis nibh imperdiet ex, non porta eros diam nec mi. Donec et ex vulputate, iaculis neque et, porttitor ligula. Ut diam nulla, congue nec elementum ut, efficitur quis dolor. Etiam id tincidunt dui. Phasellus porttitor, dui in commodo finibus, sem libero sagittis ligula, at aliquet metus mauris nec mauris. Praesent commodo auctor orci in egestas. Maecenas erat eros, eleifend at efficitur a, lobortis at ipsum. Integer risus arcu, bibendum sed fringilla at, accumsan id diam. Praesent dignissim in sapien in placerat. Phasellus convallis nibh risus, eu consequat arcu varius at. Suspendisse pellentesque dapibus ex id dapibus. Mauris nisi ante, aliquet a justo sed, auctor maximus ante. Donec lacus metus, viverra ac metus et, ultricies lobortis elit. 
         Nullam sit amet molestie mauris. Integer eget nisl quis diam interdum fermentum. Nulla urna ante, sodales in elit sit amet, aliquam convallis justo. Maecenas tempus aliquet magna nec scelerisque. Phasellus consectetur condimentum nunc, sed mattis sem posuere nec. Phasellus vitae fermentum diam, sed tempus erat. Fusce at ligula vel nunc sollicitudin facilisis. Nunc aliquam ligula aliquam sapien lacinia ultricies. Maecenas vel ex tortor. In tristique, magna sed sodales egestas, magna arcu hendrerit libero, id convallis enim libero id mi. Donec sed luctus nulla. Fusce dignissim, ipsum et blandit elementum, leo turpis blandit sem, id ullamcorper lacus turpis imperdiet risus. Praesent eu sem ligula. Sed iaculis augue eget diam dictum porttitor.
         Quisque efficitur urna sodales, mollis mi eu, convallis ipsum. Sed rhoncus eleifend velit auctor dapibus. Ut tincidunt pellentesque felis, sed commodo ante interdum commodo. Integer at sodales urna, vitae pharetra nibh. Integer iaculis diam a diam semper aliquet. Ut pharetra nunc non dolor pellentesque, et efficitur libero ornare. Maecenas maximus, odio sed mollis ultricies, ipsum dui gravida lacus, et volutpat erat velit vel lorem. Aliquam viverra vel dolor sed dignissim. Fusce tempus a magna sit amet viverra. Curabitur at vestibulum metus. Donec erat libero, auctor eu sapien accumsan, laoreet auctor felis. In efficitur, felis mattis dapibus suscipit, tellus sapien eleifend diam, ut semper turpis mauris ut lorem. Integer ac nisi mattis, bibendum tortor id, venenatis dui.";


      public Post GetPostByTitle(string title)
      {
         throw new NotImplementedException();
      }
      
      public IEnumerable<Post> GetRecientPosts()
      {
         var blogList = new List<Post>();
         blogList.Add(new Post { Title = "Test Title Please Ignore", Created = DateTime.Now, Content = FILLER_TEXT });
         blogList.Add(new Post { Title = "This is a second post", Created = DateTime.Now, Content = FILLER_TEXT });
         return blogList.OrderByDescending(p => p.Created);
      }
   }
}