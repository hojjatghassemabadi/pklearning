using Learning.Application.Contracts.DegreeContract;
using Learning.Application.Contracts.LinkContract;
using Learning.Domain.Degrees;
using Learning.Domain.Links;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Application.DegreeApplications
{
    public class DegreeApplication : IDegreeApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDegreeRepository _degreeRepository;
        public DegreeApplication(IUnitOfWork unitOfWork, IDegreeRepository degreeRepository)
        {
            _unitOfWork = unitOfWork;
            _degreeRepository = degreeRepository;
        }

        public void ChangeStatus(long id)
        {
            _unitOfWork.BeginTran();
            var degree = _degreeRepository.Get(id);
            degree.ChangeStatus(!degree.Status);
            _unitOfWork.CommitTran();
        }

        public void Create(RegisterDegreeViewModel command)
        {
            _unitOfWork.BeginTran();
            var degree = new Degree(command.Name, command.Status);
            _degreeRepository.Create(degree);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditDegreeViewModel command)
        {
            _unitOfWork.BeginTran();
            var degree = _degreeRepository.Get(command.Id);
            degree.EditDegree(command.Name,command.Status, 1);
            _unitOfWork.CommitTran();
        }

        public GetDegreeWithIdViewModel Get(long id)
        {
            var degree = _degreeRepository.Get(id);
            if (degree != null)
            {
                return new GetDegreeWithIdViewModel
                {
                    Id = degree.Id,
                    Name = degree.Name,
                    Status = degree.Status
                };
            }
            return null;
        }

        public List<GetDegreeWithIdViewModel> List(RequestDto request)
        {
            return _degreeRepository.GetAll().Select(x => new GetDegreeWithIdViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status
            }).ToList();
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var role = _degreeRepository.Get(id);
            role.Remove(1, DateTime.Now);
            _unitOfWork.CommitTran();
        }
    }
}
