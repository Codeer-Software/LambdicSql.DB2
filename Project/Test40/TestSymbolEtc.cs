﻿using System.Data;
using System.Linq;
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
    public class TestSymbolEtc
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
        public void Test_Asterisk_1()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).
                From(db.tbl_staff));

            var datas = _connection.Query<Staff>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Asterisk_2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Asterisk_3()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk<Staff>()).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff");
        }
        
        [TestMethod]
        public void Test_Asc_Desc()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).
                From(db.tbl_staff).
                OrderBy(Asc(db.tbl_staff.id), Desc(db.tbl_staff.name)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff
ORDER BY
	tbl_staff.id ASC,
	tbl_staff.name DESC");
        }

        [TestMethod]
        public void Test_All()
        {
            var sql = Db<DB>.Sql(db =>
                Select(All(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT ALL *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_Distinct()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Distinct(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT DISTINCT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_CurrentDate_3()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Current_Date()
                }).From(SysIBM.SysDummy1));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CURRENT DATE AS Val
FROM SYSIBM.SYSDUMMY1");
        }

        [TestMethod]
        public void Test_CurrentTime_2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Current_Time()
                }).
                From(SysIBM.SysDummy1));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CURRENT TIME AS Val
FROM SYSIBM.SYSDUMMY1");
        }

        [TestMethod]
        public void Test_CurrentTimeStamp_3()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Current_TimeStamp()
                }).
                From(SysIBM.SysDummy1));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CURRENT TIMESTAMP AS Val
FROM SYSIBM.SYSDUMMY1");
        }
    }
}
