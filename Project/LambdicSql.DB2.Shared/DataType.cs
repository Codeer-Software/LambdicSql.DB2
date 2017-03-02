using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.DB2
{
    /// <summary>
    /// Data type.
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public static class DataType
    {
        /// <summary>
        /// BIGINT
        /// </summary>
        /// <returns>BIGINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement BigInt() { throw new InvalitContextException(nameof(BigInt)); }

        /// <summary>
        /// BINARY
        /// </summary>
        /// <returns>BINARY</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Binary() { throw new InvalitContextException(nameof(Binary)); }

        /// <summary>
        /// BINARY
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>BINARY</returns>
        [FuncStyleConverter]
        public static DataTypeElement Binary(int n) { throw new InvalitContextException(nameof(Binary)); }

        /// <summary>
        /// BLOB
        /// </summary>
        /// <returns>BLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Blob() { throw new InvalitContextException(nameof(Blob)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <returns>CHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Char() { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement Char(int n) { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CLOB
        /// </summary>
        /// <returns>CLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Clob() { throw new InvalitContextException(nameof(Clob)); }

        /// <summary>
        /// DATE
        /// </summary>
        /// <returns>DATE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Date() { throw new InvalitContextException(nameof(Date)); }

        /// <summary>
        /// DBCLOB
        /// </summary>
        /// <returns>DBCLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement DbClob() { throw new InvalitContextException(nameof(DbClob)); }

        /// <summary>
        /// DOUBLE
        /// </summary>
        /// <returns>DOUBLE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Double() { throw new InvalitContextException(nameof(Double)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <returns>FLOAT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Float() { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>FLOAT</returns>
        [FuncStyleConverter]
        public static DataTypeElement Float(int n) { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// GRAPHIC
        /// </summary>
        /// <returns>GRAPHIC</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Graphic() { throw new InvalitContextException(nameof(Graphic)); }

        /// <summary>
        /// INT
        /// </summary>
        /// <returns>INT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int() { throw new InvalitContextException(nameof(Int)); }

        /// <summary>
        /// INTEGER
        /// </summary>
        /// <returns>INTEGER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Integer() { throw new InvalitContextException(nameof(Integer)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <returns>NUMERIC</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Numeric() { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision, int scale) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// REAL
        /// </summary>
        /// <returns>REAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Real() { throw new InvalitContextException(nameof(Real)); }

        /// <summary>
        /// SMALLINT
        /// </summary>
        /// <returns>SMALLINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallInt() { throw new InvalitContextException(nameof(SmallInt)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <returns>TIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Time() { throw new InvalitContextException(nameof(Time)); }

        /// <summary>
        /// TIME
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIME</returns>
        [FuncStyleConverter]
        public static DataTypeElement Time(int n) { throw new InvalitContextException(nameof(Time)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <returns>TIMESTAMP</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TimeStamp() { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIMESTAMP</returns>
        [FuncStyleConverter]
        public static DataTypeElement TimeStamp(int n) { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <returns>VARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar() { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar(int n) { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR2
        /// </summary>
        /// <returns>VARCHAR2</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar2() { throw new InvalitContextException(nameof(VarChar2)); }

        /// <summary>
        /// VARCHAR2
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR2</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar2(int n) { throw new InvalitContextException(nameof(VarChar2)); }
    }
}
