﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.Interfaces
{
    public interface ICategory
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool Enabled { get; set; }
    }
}
