using Microsoft.EntityFrameworkCore;
using System;

namespace Base.PayBll
{
    public interface IPayBll
    {
        DbContext DbContext { get;}
    }
}
