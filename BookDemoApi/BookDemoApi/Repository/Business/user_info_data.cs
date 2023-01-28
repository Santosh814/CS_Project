using BookDemoApi.Model;
using BookDemoApi.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace BookDemoApi.Repository.Business
{
    public class user_info_data : Iuser_info
    {

        private readonly IConfiguration _configuration;
        private readonly string connDB = "";
        public user_info_data(IConfiguration configuration)
        {
            _configuration = configuration;
            connDB = _configuration.GetConnectionString("dbconnection");
        }

        
    }
}
