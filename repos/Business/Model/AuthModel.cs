using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class AuthModel
    {
        public bool Status { get; set; }
        public string Code { get; set; }
        public UserModel User { get; set; }
        public string Role { get; set; }
        public List<string> Roles { get; set; }
        public int WaitingTime { get; set; }
        public bool ChangePasswordOnLogin { get; set; }
        public bool PasswordExpired { get; set; }
        public string ResetPasswordToken { get; set; }

    }
}
