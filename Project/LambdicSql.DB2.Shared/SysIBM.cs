using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.DB2
{
    /// <summary>
    /// SYSIBM keyword.
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public static class SysIBM
    {
        /// <summary>
        /// SYSDUMMY1 keyword.
        /// </summary>
        [MemberConverter(Name = "SYSIBM.SYSDUMMY1")]
        public static object SysDummy1 { get { throw new InvalitContextException(nameof(SysDummy1)); } }
    }
}
