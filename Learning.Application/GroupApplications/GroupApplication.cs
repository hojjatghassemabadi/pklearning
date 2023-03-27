using Learning.Application.Contracts.GroupContract;
using Learning.Application.Contracts.RoleContract;
using Learning.Domain.Groups;
using Learning.Domain.Users;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.GroupApplications
{
    public class GroupApplication : IGroupApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGroupRepository _groupRepository;
        public GroupApplication(IUnitOfWork unitOfWork, IGroupRepository groupRepository)
        {
            _unitOfWork = unitOfWork;
            _groupRepository = groupRepository;
        }

        public void ChangeStatus(long id)
        {
            _unitOfWork.BeginTran();
            var group = _groupRepository.Get(id);
            group.ChangeStatus(!group.Status);
            _unitOfWork.CommitTran();
        }

        public void Create(RegisterGroupViewModel command)
        {
            _unitOfWork.BeginTran();
            var group = new Group(command.Name, command.Status);
            _groupRepository.Create(group);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditGroupViewModel command)
        {
            _unitOfWork.BeginTran();
            var group = _groupRepository.Get(command.Id);
            group.EditGroup(command.Name,command.Code, command.Status, 1);
            _unitOfWork.CommitTran();
        }

        public GetGroupWithIdViewModel Get(long id)
        {
            var group = _groupRepository.Get(id);
            if (group != null)
            {
                return new GetGroupWithIdViewModel
                {
                    Id = group.Id,
                    Name = group.Name,
                    Code=group.Code,
                    Status = group.Status
                };
            }
            return null;
        }

        public List<GetGroupWithIdViewModel> List(RequestDto request)
        {
            return _groupRepository.GetAll().Select(x => new GetGroupWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Code=x.Code,
                Status = x.Status
            }).ToList();
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var role = _groupRepository.Get(id);
            role.Remove(1, DateTime.Now);
            _unitOfWork.CommitTran();
        }
    }
}
