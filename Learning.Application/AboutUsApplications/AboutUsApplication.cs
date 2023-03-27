using Learning.Application.Contracts.AboutUsContract;
using Learning.Application.Contracts.RoleContract;
using Learning.Domain.AboutUses;
using Learning.Domain.Users;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.AboutUsApplications
{
    public class AboutUsApplication : IAboutUsApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAboutUsrepository _aboutUsrepository;
        public AboutUsApplication(IUnitOfWork unitOfWork, IAboutUsrepository aboutUsrepository)
        {
            _unitOfWork = unitOfWork;
            _aboutUsrepository = aboutUsrepository;
        }

        public void ChangeStatus(long id)
        {
            _unitOfWork.BeginTran();
            var about = _aboutUsrepository.Get(id);
            about.ChangeStatus(!about.Status);
            _unitOfWork.CommitTran();
        }

        public void Create(RegisterAboutUsViewModel command)
        {
            _unitOfWork.BeginTran();
            var about = new AboutUs(command.Text, command.Status);
            _aboutUsrepository.Create(about);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditAboutUsViewModel command)
        {
            _unitOfWork.BeginTran();
            var about = _aboutUsrepository.Get(command.Id);
            about.EditAboutUs(command.Text, command.Status, 1);
            _unitOfWork.CommitTran();
        }

        public GetAbouUsWithIdViewModel Get(long id)
        {
            var role = _aboutUsrepository.Get(id);
            if (role != null)
            {
                return new GetAbouUsWithIdViewModel
                {
                    Text = role.Text,
                    Status = role.Status
                };
            }
            return null;
        }

        public List<GetAbouUsWithIdViewModel> List(RequestDto request)
        {
            return _aboutUsrepository.GetAll().Select(x => new GetAbouUsWithIdViewModel
            {
                Text = x.Text,
                Status = x.Status
            }).ToList();
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var role = _aboutUsrepository.Get(id);
            role.Remove(1, DateTime.Now);
            _unitOfWork.CommitTran();
        }
    }
}
