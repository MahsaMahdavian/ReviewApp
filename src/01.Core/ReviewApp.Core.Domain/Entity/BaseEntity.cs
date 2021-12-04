using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public  Guid Guid { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
