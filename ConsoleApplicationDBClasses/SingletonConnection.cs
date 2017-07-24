using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDBClasses
{
    public sealed class SingletonConnection
    {
        private static readonly string conn_string = @"Driver={SQL Server};Server=SBT-PC1\SQLEXPRESS;Database=TziporahStore";
        private static readonly Lazy<SingletonConnection> lazy = new Lazy<SingletonConnection>(() => new SingletonConnection());

        private static OdbcConnection dbConn = null;

        public static SingletonConnection Instance
        {
            get { return lazy.Value; }
        }

        private SingletonConnection()
        {
            dbConn = new OdbcConnection(conn_string);
            dbConn.Open();
        }

        public OdbcDataReader GetReader(string sql)
        {
            OdbcCommand command = dbConn.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }
    }
}
