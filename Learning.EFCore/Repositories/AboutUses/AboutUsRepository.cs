using Learning.Domain.AboutUses;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using System.Linq.Expressions;

namespace Learning.Infrastructure.EFCore.Repositories.AboutUses
{
    public class AboutUsRepository : BaseRepository<long, AboutUs>, IAboutUsrepository
    {
        private readonly LearningContext _context;

        public AboutUsRepository(LearningContext context) : base(context)
        {
            _context = context;
        }

       
    }
}
