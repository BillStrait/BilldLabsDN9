using BilldLabsDN9.Data.Enums;
using BilldLabsDN9.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.Interfaces
{
    public abstract class BasePostDetail
    {
        [Key]
        public Guid PostDetailId { get; set; }
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        public Guid? AuthorId { get; set; }
        public User? Author { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? UnpublishDate { get; set; }
        public PostTypes PostType { get; set; }
        

        public abstract string GetBody();

    }
}
