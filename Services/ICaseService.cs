﻿using ElevatorMobileApplication.Models;

namespace ElevatorMobileApplication.Services
{
    public interface ICaseService
    {
        public Task<List<Case>> GetCasesAsync();
        public Task<Case> GetCaseByIdAsync(int id);
    }
}