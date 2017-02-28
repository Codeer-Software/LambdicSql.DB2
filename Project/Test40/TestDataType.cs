using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.DB2.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using LambdicSql.DB2;

namespace Test
{
    [TestClass]
    public class TestDataType
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

        [TestMethod]
        public void Test_CreateTable_DB2()
        {
            if (!_connection.IsTarget(TargetDB.DB2)) return;

            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                CreateTable(db.table3,
                    new Column(db.table3.obj1, DataType.BigInt()),
                    new Column(db.table3.obj2, DataType.Binary()),
                    new Column(db.table3.obj3, DataType.Blob()),
                    new Column(db.table3.obj4, DataType.Char(1)),
                    new Column(db.table3.obj5, DataType.Clob()),
                 // new Column(db.table3.obj6, DataType.Currency()),
                    new Column(db.table3.obj7, DataType.Date()),
                 // new Column(db.table3.obj8, DataType.DateTime()),
                    new Column(db.table3.obj9, DataType.DbClob()),
                    new Column(db.table3.obj10, DataType.Double()),
                    new Column(db.table3.obj11, DataType.Float()),
                    new Column(db.table3.obj12, DataType.Graphic()),
                    new Column(db.table3.obj13, DataType.Int()),
                    new Column(db.table3.obj14, DataType.Integer()),
                 // new Column(db.table3.obj15, DataType.LongVarchar(1)),
                 // new Column(db.table3.obj16, DataType.LongVarGraphic()),
                    new Column(db.table3.obj17, DataType.Numeric()),
                    new Column(db.table3.obj18, DataType.Real()),
                    new Column(db.table3.obj19, DataType.SmallInt()),
                 // new Column(db.table3.obj20, DataType.Text()),
                    new Column(db.table3.obj21, DataType.Time()),
                    new Column(db.table3.obj22, DataType.TimeStamp()),
                    new Column(db.table3.obj23, DataType.VarChar(1))
                 // new Column(db.table3.obj24, DataType.VarGraphic())
                ));

            _connection.Execute(sql);
        }

        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table3));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
