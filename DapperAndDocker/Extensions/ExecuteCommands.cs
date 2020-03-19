using System;
using Microsoft.Data.SqlClient;

namespace DapperAndDocker.Extensions
{
    public static class ExecuteCommands
    {
        public static void ExecuteCommand(string connStr, Action<SqlConnection> task)
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            task(conn);
        }
        public static T ExecuteCommand<T>(string connStr, Func<SqlConnection, T> task)
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            return task(conn);
        }
    }
}