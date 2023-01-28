using BookDemoApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemoApi.Repository.Contract
{
    public interface Iuser_info
    {
        Task<IEnumerable<user_info_model>> GetUserInfo();

        Task<user_info_model> GetUserInfo(int Id);

        Task<user_info_model> CreateUser(user_info_model User_Data);

        Task UpdateUser(user_info_model User_Data);

        Task DeleteDelete(int Id);


    }
}
