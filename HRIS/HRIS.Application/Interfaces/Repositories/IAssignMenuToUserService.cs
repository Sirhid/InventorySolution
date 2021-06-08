using HRIS.Application.DTOs.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.Interfaces.Repositories
{
    public interface IAssignMenuToUserService
    {
        int CreateMenuRequest(MenuRequest model);
        int UpdateRequest(MenuRequest model);
        int DeleteMenuRequest(MenuRequest model);
    }
}
