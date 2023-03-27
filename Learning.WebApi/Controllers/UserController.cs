using Learning.Application.Contracts.RoleContract;
using Learning.Application.Contracts.UserContract;
using Learning.Framework.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Learning.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserApplication _usersApplication;
        private readonly IRoleApplication _roleApplication;

        public UserController(IUserApplication usersApplication, IRoleApplication roleApplication)
        {
            _usersApplication = usersApplication;
            _roleApplication = roleApplication;
        }
        //login 
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromForm] AuthenticationRequest authenticationRequest)
        {
            var user = _usersApplication.SignIn(authenticationRequest.UserName, authenticationRequest.Password);
            if (user == null)
            {
                return NotFound(new { Message = "User Not Found!" });
            }

            var authResult = _usersApplication.Autentication(authenticationRequest.UserName, authenticationRequest.Password);
            if (authResult == null)
            {
                return NotFound(new { Message = "User Not Found!" });
            }
            else
            {
                return Ok(authResult);
            }
        }
        // User Operations
        #region user 
        [HttpPost]

        [Route("GetUsers")]
        public ResultGetUsers GetUsers([FromBody] RequestDto requsetDto)
        {
            var result = _usersApplication.List(requsetDto);
            return result;
        }
        [HttpPost]
        [Route("CreateUser")]


        public ResultDto CreateUser(CreateUsersViewModel command)
        {
            _usersApplication.Create(command);
            return new ResultDto { IsSuccess = true, Message = "Register Was Successfull" };
        }
        [HttpPost]
        [Route("EditUser")]


        public ResultDto EditUser(EditUserViewModel command)
        {
            _usersApplication.Edit(command);
            return new ResultDto { IsSuccess = true, Message = "Edit Was Successfull" };
        }
        [HttpPost]
        [Route("RemoveUser")]


        public ResultDto RemoveUser(long id)
        {
            _usersApplication.Remove(id);
            return new ResultDto { IsSuccess = true, Message = "Remove Was Successfull" };
        }
        [HttpPut]
        [Route("ChangeStatus")]
        public ResultDto ChangeStatus(long id)
        {
            _usersApplication.ChangeStatus(id);
            return new ResultDto { IsSuccess = true, Message = "ChangeStatus Was Successfull" };
        }
        [HttpPost]
        [Route("GetUser")]
        public EditUserViewModel GetUser(long id)
        {
            var result = _usersApplication.Get(id);
            return new EditUserViewModel
            {

                Name = result.Name,
                Status = result.Status,
                Famil = result.Famil,
                Id = result.Id,
                Password = result.Password,
                UserName = result.UserName,
                ActiveMobile=result.ActiveMobile,
                Address=result.Address,
                ChangePassword=result.ChangePassword,
                Degrees=result.Degrees,
                Email=result.Email,
                Groups=result.Groups,
                LearningLevel=result.LearningLevel,
                Mobile=result.Mobile,
                Pic=result.Pic,
                Scopes=result.Scopes,
                Roles = result.Roles
            };
        }
        #endregion
        // Role Operations
        #region Role

        [HttpPost]
        [Route("GetRoles")]
        public List<GetRolesWithIdViewModel> GetRoles([FromBody] RequestDto requsetDto)
        {
            var result = _roleApplication.List(requsetDto);
            return result;
        }
        [HttpPost]
        [Route("CreateRole")]
        public ResultDto CreateRole(RegisterRoleViewModel command)
        {
            _roleApplication.Create(command);
            return new ResultDto { IsSuccess = true, Message = "Register Was Successfull" };
        }
        [HttpPost]
        [Route("EditRole")]
        public ResultDto EditRole(EditRoleViewModel command)
        {
            _roleApplication.Edit(command);
            return new ResultDto { IsSuccess = true, Message = "Edit Was Successfull" };
        }
        [HttpPost]
        [Route("RemoveRole")]
        public ResultDto RemoveRole(long id)
        {
            _roleApplication.Remove(id);
            return new ResultDto { IsSuccess = true, Message = "Remove Was Successfull" };
        }
        [HttpPut]
        [Route("ChangeRoleStatus")]
        public ResultDto ChangeRoleStatus(long id)
        {
            _roleApplication.ChangeStatus(id);
            return new ResultDto { IsSuccess = true, Message = "ChangeStatus Was Successfull" };
        }
        [HttpPost]
        [Route("GetRole")]
        public GetRolesViewModel GetRole(long id)
        {
            var result = _roleApplication.Get(id);
            if (result != null)
            {
                return new GetRolesViewModel
                {
                    Name = result.Name,
                    Status = result.Status
                };
            }
            return null;
        }
        #endregion
    }
}
