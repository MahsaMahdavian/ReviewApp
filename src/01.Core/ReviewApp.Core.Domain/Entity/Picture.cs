using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity
{
    public class Picture:BaseEntity
    {
        public string PicAddress { get; set; }
        public int PostId { get; set; }
        public Post post { get; set; }
    }
}
