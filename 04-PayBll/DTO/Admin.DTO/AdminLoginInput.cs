using Admin.PayModel;
using System;

namespace Admin.DTO
{
    public class AdminLoginInput : InputDTO<AdminLoginModel, ResponseModel>
    {
        public string LoginIP { get; set; }
    }
}
