using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyleceschidotcom.Models
{
   public class Post
   {
      public string Title { get; internal set; }
      public DateTime Created { get; internal set; }
      public string Content { get; internal set; }
   }
}
