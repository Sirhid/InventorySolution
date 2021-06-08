using HRIS.Application.DTOs.Account;
using System.Collections.Generic;

namespace HRIS.Infrastructure.Interfaces.Repositories
{
    public interface IMenuRepository
    {
        List<MenuRole> GetMenu(int RoleID);
        List<PermissionDTO> GetPermissionbyUserID(int UserID);
    }
}