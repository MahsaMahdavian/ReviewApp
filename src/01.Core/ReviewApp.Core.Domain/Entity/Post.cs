using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity

{
   public  class Post:BaseEntity
    {
        public DateTime LastModifiedDate { get; set; }
        public String Caption { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Location location { get; set; }
        public ICollection<Comment> comments { get; set; }
        public ICollection<Like> likes { get; set; }

    }
}
