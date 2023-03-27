namespace Learning.Application.UserApplications;
using Learning.Application.Contracts.UserContract;
using Learning.Domain.Users;
using Learning.Framework.Domains;
using Learning.Framework.Infrastructure;
using Learning.Framework.Jwt;

public class UserApplication : IUserApplication
{
    private readonly IUserRepository _userRepository;
    private readonly IRoleRepository _RoleRepository;
    private readonly IUserInRoleRepository _userInRoleRepository;
    private readonly IUnitOfWork _unitOfWork;
    public UserApplication(IUserRepository userRepository, IRoleRepository roleRepository, IUserInRoleRepository userInRoleRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _RoleRepository = roleRepository;
        _userInRoleRepository = userInRoleRepository;
        _unitOfWork = unitOfWork;
    }

    public JwtAuthResponse Autentication(string username, string password)
    {
        throw new NotImplementedException();
    }

    public void ChangeStatus(long id)
    {
        throw new NotImplementedException();
    }

    public void Create(CreateUsersViewModel command)
    {
        throw new NotImplementedException();
    }

    public void Edit(EditUserViewModel command)
    {
        throw new NotImplementedException();
    }

    public EditUserViewModel Get(long id)
    {
        throw new NotImplementedException();
    }

    public ResultGetUsers List(RequestDto request)
    {
        throw new NotImplementedException();
    }

    public void Remove(long id)
    {
        throw new NotImplementedException();
    }

    public EditUserViewModel SignIn(string username, string password)
    {
        throw new NotImplementedException();
    }
}

