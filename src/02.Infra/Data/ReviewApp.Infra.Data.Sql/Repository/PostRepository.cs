using Microsoft.Extensions.Logging;
using ReviewApp.Core.Abstraction.Repository;
using ReviewApp.Core.Domain.Entity;
using ReviewApp.Infra.Data.Sql.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Infra.Data.Sql.Repository
{
    public class PostRepository : Repositorybase<Post>,IPostRepository
    {
        public PostRepository(ReviewAppContext context) : base(context) { }

    }
}
