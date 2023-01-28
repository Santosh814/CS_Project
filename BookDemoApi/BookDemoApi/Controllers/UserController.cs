using BookDemoApi.Repository.Business;
using BookDemoApi.Repository.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly Iuser_info objUserInfo=null;
        public UserController(Iuser_info UserInfo)
        {
            this.objUserInfo = UserInfo;
        }

        //public IEnumerable<user_info_data> GetUserInformation()
        //{ 
        
        
        
        //}


    }
}
