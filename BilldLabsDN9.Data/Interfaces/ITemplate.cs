using BilldLabsDN9.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.Interfaces
{
    public interface ITemplate
    {
        public Guid TemplateId { get; set; }
        
        public IEnumerable<Guid> AvailableForCategories { get; set; }
        public PostTypes PostType { get; set; }
    }
}
