using Base.Common;
using Base.Common.Enums;

namespace Admin.PayModel
{
    public class CreateAccountModel : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }
    }
}
