using RMDataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RMDataManager.Library.DataAccess;
using RMDataManager.Library.Models;
using Microsoft.AspNet.Identity;

namespace RMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();         

            return data.GetUserById(userId).First();
        }

        
    }
}
