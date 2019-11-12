using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dapper2MVC.Models.User
{
    public class UserEdit
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [Phone(ErrorMessage = "Invalid Phone number")]
        public string UserMobile { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }
        [Url(ErrorMessage = "Invalid url")]
        public string FaceBookUrl { get; set; }
        [Url(ErrorMessage = "Invalid url")]
        public string LinkedInUrl { get; set; }
        [Url(ErrorMessage = "Invalid url")]
        public string TwitterUrl { get; set; }
        [Url(ErrorMessage = "Invalid url")]
        public string PersonalWebUrl { get; set; }
    }
}
