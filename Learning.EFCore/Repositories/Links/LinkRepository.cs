using Learning.Domain.Links;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories.Links
{
    public class LinkRepository : BaseRepository<long, Link>, ILinkRepository
    {
        private readonly LearningContext _context;
        public LinkRepository(LearningContext context) : base(context)
        {
            _context = context;
        }

    }
}
