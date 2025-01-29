using BilldLabsDN9.Data.Enums;
using BilldLabsDN9.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.PostTemplates
{
    public class Template : ITemplate
    {
        public Guid TemplateId { get; set; }
        
        public IEnumerable<Guid> AvailableForCategories { get; set; } = new List<Guid>();
        public PostTypes PostType { get; set; }
    }
}
