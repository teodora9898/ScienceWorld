using System;
using System.Collections.Generic;

namespace ScienceWorld.Entities
{
    public class Article
    {
        public String title { get; set; }
        public String username { get; set; }
        public DateTime uploaddate { get; set; }
        public String articletext { get; set; }
        public String fieldofscience { get; set; }
        public String subfieldofscience { get; set; }
        public List<Comment> comments{ get; set; }
    }
}
