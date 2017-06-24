using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserModel CreatedBy { get; set; }
    }
}