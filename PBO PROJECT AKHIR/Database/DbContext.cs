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
        public string connStr;

        public DbContext()
        {
            Env.Load();
            connStr = Environment.GetEnvironmentVariable("CONN_STR")
                      ?? throw new Exception("CONN_STR not found");
        }
    }
}