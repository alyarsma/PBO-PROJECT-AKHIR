using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBO_PROJECT_AKHIR.Database
{
    public class DbContext
    {
        private string _dbHost;
        private string _dbPort;
        private string _dbUser;
        private string _dbPassword;
        private string _dbName;
        private string _sslMode;
        private string _chanelBinding;

        public string connStr;
        public DbContext()
        {
            Env.Load();

            _dbHost = Environment.GetEnvironmentVariable("DB_Host");
            _dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            _dbUser = Environment.GetEnvironmentVariable("DB_Username");
            _dbPassword = Environment.GetEnvironmentVariable("DB_Password");
            _dbName = Environment.GetEnvironmentVariable("DB_NAME");
            _sslMode = Environment.GetEnvironmentVariable("SSL_Mode");
            _chanelBinding = Environment.GetEnvironmentVariable("Channel_Binding");

            connStr = $"Host={_dbHost};Port={_dbPort};Username={_dbUser};Password={_dbPassword};Database={_dbName}; SSL Mode= {_sslMode}; Channel Binding = {_chanelBinding}";
        }
    }

}