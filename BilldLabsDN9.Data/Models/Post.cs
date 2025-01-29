using BilldLabsDN9.Data.Enums;
using BilldLabsDN9.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public PostTypes PostType { get; set; }
        public Guid? PostDetiailId { get; set; }
        public BasePostDetail? PostDetail { get; set; }
    }
}
