using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? SuspendDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsContributor { get; set; }
        public string? PassKeyPublicKey { get; set; }
    }
}
