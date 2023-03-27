﻿using Learning.Application.Contracts.RoleContract;
using Learning.Domain.Users;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.RoleApplications
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RoleApplication(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public void ChangeStatus(long id)
        {
            _unitOfWork.BeginTran();
            var role = _roleRepository.Get(id);
            role.ChangeStatus(!role.Status);
            _unitOfWork.CommitTran();
        }

        public void Create(RegisterRoleViewModel command)
        {
            _unitOfWork.BeginTran();
            var role = new Role(command.Name, command.Status);
            _roleRepository.Create(role);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditRoleViewModel command)
        {
            _unitOfWork.BeginTran();
            var role = _roleRepository.Get(command.Id);
            role.EditRole(command.Name, command.Status, 1);
            _unitOfWork.CommitTran();
        }

        public GetRolesWithIdViewModel Get(long id)
        {
            var role = _roleRepository.Get(id);
            if (role != null)
            {
                return new GetRolesWithIdViewModel
                {
                    Id = role.Id,
                    Name = role.Name,
                    Status = role.Status
                };
            }
            return null;
        }

        public List<GetRolesWithIdViewModel> List(RequestDto request)
        {
            return _roleRepository.GetAll().Select(x => new GetRolesWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status
            }).ToList();
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var role = _roleRepository.Get(id);
            role.Remove(1, DateTime.Now);
            _unitOfWork.CommitTran();
        }
    }
}
