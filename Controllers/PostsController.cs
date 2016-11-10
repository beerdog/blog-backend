using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BlogBackend.Controllers
{
    public class ContentController : ApiController
    {
        public IEnumerable<IPost> Get()
        {
            return TextPub.Application.Posts.OrderByDescending(p => p.Title);
        }

        [Route("api/content/newest")]
        public IPost GetNewest()
        {
            return TextPub.Application.Posts.OrderByDescending(p => p.Title).FirstOrDefault();
        }

        public IPost GetSingle(string id)
        {
             return TextPub.Application.Posts.Where(p => p.Id == id).FirstOrDefault();
        }
    }      
}