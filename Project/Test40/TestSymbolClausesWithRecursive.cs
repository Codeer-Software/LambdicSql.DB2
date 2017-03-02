using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.DB2.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesWithRecursive
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();

        class SelectedData
        {
            public int id { get; set; }
        }

        [TestMethod]
        public void Test_With()
        {
            var sub1 = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).
                From(db.tbl_staff));

            var sub2 = Db<DB>.Sql(db =>
                Select(Asterisk(sub1.Body)).
                From(sub1));

            var sub3 = Db<DB>.Sql(db => sub2);
            
            var sql = Db<DB>.Sql(db =>
                With(sub1, sub2).
                Select(new SelectedData
                {
                    id = sub3.Body.id
                }).
                From(sub3)
            );

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"WITH
	sub1 AS
		(SELECT *
		FROM tbl_staff),
	sub2 AS
		(SELECT *
		FROM sub1)
SELECT
	sub3.id AS id
FROM sub2 sub3");
        }
    }
}
