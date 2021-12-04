﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Domain.Entity
{
   public class Location:BaseEntity
    {
        public string Name { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
