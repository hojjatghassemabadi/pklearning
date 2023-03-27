using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LearningContext _context;
        public UnitOfWork(LearningContext context)
        {
            _context = context;
        }

        public void BeginTran()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            _context.SaveChanges();
            _context.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }
    }
}
