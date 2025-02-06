using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.BDConnection
{
    public sealed class BDNpgsql
    {
        private static BDNpgsql _instance = null;
        private static readonly object _lock = new();
        private readonly NpgsqlConnection _connection;


        private const string Host = "192.168.0.189";
        private const string Port = "62354";
        private const string Username = "postgres";
        private const string Password = "athena_4116";
        private const string Database = "bdetiquetas";

        private const string connString = "Host="+Host+";Port="+Port+";Username="+Username+";Password="+Password+";Database="+ Database+";MaxPoolSize=200;";

        private BDNpgsql()
        {
            _connection = new NpgsqlConnection(connString);
        }

        public static BDNpgsql Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new BDNpgsql();
                    }
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection
        {
            get
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                return _connection;
            }
        }

        public async Task<NpgsqlConnection> GetConnectionAsync()
        {
            
                if (_connection.State != System.Data.ConnectionState.Open)
                    await _connection.OpenAsync();

                return _connection;
            
        }

        public void CloseConnection()
        {
            try
            {

            if (_connection.State != System.Data.ConnectionState.Closed)
                _connection.Close();
            }
            catch (InvalidOperationException e)
            {

                Utils.Util.CartelError(e.Message, e.ToString());
            }
        }

    }
}
