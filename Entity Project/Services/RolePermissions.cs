using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Entity_Project.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace Entity_Project.Services
{
    class RolePermissions // Map its roletype to a set of permission
                         //Uses bitwise AND (&) to check if the role includes the requested permission.
                        //Returns true if the user has the permission, otherwise false.
    {
        public static readonly Dictionary<RoleType, Permission> RoleToPermissions = new()
    {
        { RoleType.Employee, Permission.Search | Permission.Add },
        { RoleType.Admin, Permission.FullControl }
    };

        public static bool HasPermission(Employee employee, Permission permission)
        {
            return (RoleToPermissions[employee.Role] & permission) == permission;
        }
    }
}
