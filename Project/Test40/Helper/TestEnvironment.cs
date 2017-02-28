using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using LambdicSql.feat.Dapper;
using IBM.Data.DB2;

namespace Test.Helper
{
    static class TestEnvironment
    {
        internal static string ConnectionString => File.ReadAllText(FindNearFile("db.txt")).Trim();

        static string FindNearFile(string fileName)
        {
            var path = typeof(TestEnvironment).Assembly.Location;
            while (true)
            {
                var filePath = Path.Combine(path, fileName);
                if (File.Exists(filePath))
                {
                    return filePath;
                }
                path = Path.GetDirectoryName(path);
            }
            throw new NotSupportedException();
        }

        internal static IDbConnection CreateConnection(TestContext context)
        {
            DapperAdapter.Assembly = typeof(Dapper.SqlMapper).Assembly;
            return new DB2Connection(ConnectionString);
        }
    }
}
