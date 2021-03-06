﻿using DoctorHouse.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorHouse.Core
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
        void Add(User user);
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserToDelete(int id);
        void Remove(User user);
    }
}