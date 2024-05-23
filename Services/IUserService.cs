﻿using System.Threading.Tasks;
using CSVDataManager.Models;
using X.PagedList;

namespace CSVDataManager.Services
{
    public interface IUserService
    {
        Task<IPagedList<User>> GetUsersAsync(int pageNumber, int pageSize);
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
        bool UserExists(int id);
        Task ProcessCsvFileAsync(string filePath);
    }
}
