using Learning.Application.Contracts.LinkContract;
using Learning.Domain.Links;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;

namespace Learning.Application.LinkApplications
{
    public class LinkApplication : ILinkApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILinkRepository _linkRepository;
        public LinkApplication(IUnitOfWork unitOfWork, ILinkRepository linkRepository)
        {
            _unitOfWork = unitOfWork;
            _linkRepository = linkRepository;
        }

        public void ChangeStatus(long id)
        {
            _unitOfWork.BeginTran();
            var role = _linkRepository.Get(id);
            role.ChangeStatus(!role.Status);
            _unitOfWork.CommitTran();
        }

        public void Create(RegisterLinkViewModel command)
        {
            _unitOfWork.BeginTran();
            var role = new Link(command.Text, command.Address, command.Status);
            _linkRepository.Create(role);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditLinkViewModel command)
        {
            _unitOfWork.BeginTran();
            var role = _linkRepository.Get(command.Id);
            role.EditLink(command.Text, command.Address, command.Status, 1);
            _unitOfWork.CommitTran();
        }

        public GetLinkWithIdViewModel Get(long id)
        {
            var link = _linkRepository.Get(id);
            if (link != null)
            {
                return new GetLinkWithIdViewModel
                {
                    Id = link.Id,
                    Text = link.Text,
                    Address = link.Address,
                    Status = link.Status
                };
            }
            return null;
        }

        public List<GetLinkWithIdViewModel> List(RequestDto request)
        {
            return _linkRepository.GetAll().Select(x => new GetLinkWithIdViewModel
            {
                Id = x.Id,
                Text = x.Text,
                Address = x.Address,
                Status = x.Status
            }).ToList();
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var role = _linkRepository.Get(id);
            role.Remove(1, DateTime.Now);
            _unitOfWork.CommitTran();
        }
    }
}
