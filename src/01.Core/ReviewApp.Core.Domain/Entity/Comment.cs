using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity
{
    public class Comment:BaseEntity
    {
        public string Text { get; set; }
        public bool Is_Deleted { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }
       
    }
}
