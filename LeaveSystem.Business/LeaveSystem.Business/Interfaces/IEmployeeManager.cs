﻿using LeaveSystem.Data.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LeaveSystem.Business
{
    public interface IEmployeeManager
    {
        Task<bool> HasPasswordAsync(Employee employee);
        Task<bool> CheckPasswordAsync(Employee user, string password);
        Task<Tuple<bool, string[]>> CreateRoleAsync(Role role, IEnumerable<string> claims);
        Task<Tuple<bool, string[]>> CreateUserAsync(Employee user, IEnumerable<string> roles, string password);
        //Task<Tuple<bool, string[]>> DeleteUserAsync(Employee user);
        //Task<Tuple<bool, string[]>> DeleteUserAsync(string userId);
        Task<Role> GetRoleByIdAsync(string roleId);
        Task<Role> GetRoleByNameAsync(string roleName);
        Tuple<Employee, string[]> GetUserAndRolesAsync(string userId);
        Employee GetEmployeeByEmail(string email);
        Task<Employee> GetUserByIdAsync(string userId);
        Task<Employee> GetUserByUserNameAsync(string userName);
        List<string> GetEmployeeRoles(Employee user);
        Task<Tuple<bool, string[]>> ResetPasswordAsync(Employee user, string newPassword);
        Task<Tuple<bool, string[]>> UpdatePasswordAsync(Employee user, string currentPassword, string newPassword);
        Task<Tuple<bool, string[]>> UpdateUserAsync(Employee user);
        Task<Tuple<bool, string[]>> UpdateUserAsync(Employee user, IEnumerable<string> roles);

        

    }
}
