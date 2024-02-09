﻿
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string conn = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string conn = "Default");
    }
}