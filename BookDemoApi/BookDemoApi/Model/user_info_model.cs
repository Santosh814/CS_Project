using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemoApi.Model
{

    /// <summary>
    /// this modal content infomation about user detail
    /// </summary>
    public class user_info_model
    {
        public string first_name { get; set; }

        public string middle_name { get; set; }
        public string last_name { get; set; }

        public string email_id { get; set; }

        public string password { get; set; }

        public string Religion { get; set; }
        public string dob { get; set; }
        public string contact_number { get; set; }
        public string gender { get; set; }
        public string created_on { get; set; }
        public string updated_on  { get; set; }
        public string published { get; set; }
       


    }
}
