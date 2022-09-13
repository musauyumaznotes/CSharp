using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{

    public class BlogYorum
    {
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Yorum> Yorum { get; set; }
        public IEnumerable<Yorum> SonYorumlar { get; set; }
        public IEnumerable<Blog> SonBloglar { get; set; }

    }
}