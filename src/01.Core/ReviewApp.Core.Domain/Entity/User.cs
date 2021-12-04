using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity
{
   public class User:BaseEntity
    {
        public DateTime LastModifiedDate { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public bool Sex { get; set; }
        public long Password { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public ICollection<Post> posts { get; set; }

    }
}
