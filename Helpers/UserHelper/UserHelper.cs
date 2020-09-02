using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TennisClub.Models;
using TennisClub.Data.Context;
using TennisClub.Helpers.UserHelper;

namespace TennisClub.Helpers.UserHelper
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

   
        public UserHelper()
        {
           
        }

        public UserHelper(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
          
        }

      

        public ApplicationUser GetLoggedInUser()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var usr = _userManager.FindByIdAsync(userId).Result;
            return usr;
        }

        public string GetLoggedInUserRole()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var usr = _userManager.FindByIdAsync(userId).Result;
            return usr.RoleName;
        }

       
    }
}