using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DP_Project
{
    public interface IDatabaseAdapter : IDisposable
    {
        Task OpenConnectionAsync();
        Task CloseConnectionAsync();
        Task<int> ExecuteNonQueryAsync(string sql, Dictionary<string, object> parameters);
        Task<object> ExecuteScalarAsync(string sql, Dictionary<string, object> parameters);
        Task<IEnumerable<Dictionary<string, object>>> QueryAsync(string sql, Dictionary<string, object> parameters);
    }
    public sealed class DatabaseConn : IDisposable
    {
        private static DatabaseConn _instance;
        private static readonly object _lock = new object();
        private readonly SqlConnection _connection;

        private DatabaseConn(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public static DatabaseConn Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
                        _instance = new DatabaseConn(connectionString);
                    }
                    return _instance;
                }
            }
        }

        public async Task OpenConnectionAsync()
        {
            if (_connection.State != ConnectionState.Open)
            {
                await _connection.OpenAsync();
            }
        }

        public async Task CloseConnectionAsync()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<int> ExecuteNonQueryAsync(string sql, Dictionary<string, object> parameters)
        {
            await OpenConnectionAsync();
            using (var cmd = new SqlCommand(sql, _connection))
            {
                AddParameters(cmd, parameters);
                return await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<object> ExecuteScalarAsync(string sql, Dictionary<string, object> parameters)
        {
            await OpenConnectionAsync();
            using (var cmd = new SqlCommand(sql, _connection))
            {
                AddParameters(cmd, parameters);
                return await cmd.ExecuteScalarAsync();
            }
        }

        public async Task<DataTable> ExecuteQueryAsync(string sql, Dictionary<string, object> parameters = null)
        {
            await OpenConnectionAsync();
            using (var cmd = new SqlCommand(sql, _connection))
            {
                if (parameters != null)
                {
                    AddParameters(cmd, parameters);
                }

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    await Task.Run(() => da.Fill(dt));
                    return dt;
                }
            }
        }

        private void AddParameters(SqlCommand cmd, Dictionary<string, object> parameters)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
        }

        public void Dispose()
        {
            _connection?.Dispose();
            _instance = null;
        }
    }

}



