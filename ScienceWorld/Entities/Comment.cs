using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceWorld.Entities
{
    public class Comment
    {
        public string text { get; set; }
        public string username { get; set; } // username of the one who left comment
        public DateTime dateadded { get; set; }
        public string usernameforarticle { get; set; }
        public DateTime uploaddatearticle { get; set; }
    }
}
