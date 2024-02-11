using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration config;

    public SqlDataAccess(IConfiguration config)
    {
        this.config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string conn = "Default")
    {
        using IDbConnection connection = new SqlConnection(config.GetConnectionString(conn));

        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure, T parameters, string conn = "Default")
    {
        using IDbConnection connection = new SqlConnection(config.GetConnectionString(conn));

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        
    }
}
