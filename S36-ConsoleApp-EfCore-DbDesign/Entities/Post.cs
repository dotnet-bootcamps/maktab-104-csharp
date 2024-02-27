using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S36_ConsoleApp_EfCore_DbDesign.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
        public int AutherId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime CreatedAt1 { get; set; }
        //public int LikeId { get; set; }
        //public List<Like> Likes { get; set; }
    }
}




