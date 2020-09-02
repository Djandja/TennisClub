using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TennisClub.Models;

namespace TennisClub.Helpers.UserHelper
{
    public interface IUserHelper
    {
        public ApplicationUser GetLoggedInUser();
        public string GetLoggedInUserRole();
      




    }
}

