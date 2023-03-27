using Learning.Application.Contracts.DegreeContract;
using Learning.Application.Contracts.GroupContract;
using Learning.Application.Contracts.LinkContract;
using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.ScopeContract;
using Learning.Application.Contracts.UserContract;
using Learning.Application.DegreeApplications;
using Learning.Application.GroupApplications;
using Learning.Application.LinkApplications;
using Learning.Application.RoleApplications;
using Learning.Application.ScopeApplications;
using Learning.Application.UserApplications;
using Learning.Domain.AboutUses;
using Learning.Domain.Degrees;
using Learning.Domain.Groups;
using Learning.Domain.Links;
using Learning.Domain.Scopes;
using Learning.Domain.Users;
using Learning.Framework.Infrastructure;
using Learning.Infrastructure.EFCore.Context;
using Learning.Infrastructure.EFCore.Repositories;
using Learning.Infrastructure.EFCore.Repositories.AboutUses;
using Learning.Infrastructure.EFCore.Repositories.Degrees;
using Learning.Infrastructure.EFCore.Repositories.Groups;
using Learning.Infrastructure.EFCore.Repositories.Links;
using Learning.Infrastructure.EFCore.Repositories.Scopes;
using Learning.Infrastructure.EFCore.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services, string ConnectionString)
        {
            services.AddEntityFrameworkSqlServer().AddDbContext<LearningContext>(options => options.UseSqlServer(ConnectionString));
            services.AddTransient<IUserApplication, UserApplication>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IRoleApplication, RoleApplication>();

            services.AddTransient<IUserInRoleRepository, UserInRoleRepository>();

            services.AddTransient<IScopeRepository, ScopeRepository>();
            services.AddTransient<IScopeApplication, ScopeApplication>();
            services.AddTransient<ILinkRepository, LinkRepository>();
            services.AddTransient<ILinkApplication, LinkApplication>();
            services.AddTransient<IGroupRepository, Grouprepository>();
            services.AddTransient<IGroupApplication, GroupApplication>();
            services.AddTransient<IDegreeRepository, DegreeRepository>();
            services.AddTransient<IDegreeApplication, DegreeApplication>();
            services.AddTransient<IAboutUsrepository, AboutUsRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
