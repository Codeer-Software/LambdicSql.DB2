using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.DB2
{
    /// <summary>
    /// Element of DateTime.
    /// </summary>
    [EnumToStringConverter]
    public enum DateTimeElement
    {
        /// <summary>
        /// Year.
        /// </summary>
        Year,

        /// <summary>
        /// Quarter.
        /// </summary>
        Quarter,

        /// <summary>
        /// Month.
        /// </summary>
        Month,

        /// <summary>
        /// Dayofyear.
        /// </summary>
        Dayofyear,

        /// <summary>
        /// Day.
        /// </summary>
        Day,

        /// <summary>
        /// Week.
        /// </summary>
        Week,

        /// <summary>
        /// Weekday.
        /// </summary>
        Weekday,

        /// <summary>
        /// Hour.
        /// </summary>
        Hour,

        /// <summary>
        /// Minute.
        /// </summary>
        Minute,

        /// <summary>
        /// Second.
        /// </summary>
        Second,

        /// <summary>
        /// Millisecond.
        /// </summary>
        Millisecond,

        /// <summary>
        /// Microsecond.
        /// </summary>
        Microsecond,

        /// <summary>
        /// Nanosecond.
        /// </summary>
        Nanosecond,

        /// <summary>
        /// ISO_WEEK.
        /// </summary>
        ISO_WEEK,
    }

    /// <summary>
    /// Interval Type.
    /// </summary>
    [EnumToStringConverter]
    public enum IntervalType
    {
        /// <summary>
        /// YEAR
        /// </summary>
        Year,

        /// <summary>
        /// MONTH
        /// </summary>
        Month,

        /// <summary>
        /// DAY
        /// </summary>
        Day,

        /// <summary>
        /// HOUR
        /// </summary>
        Hour,

        /// <summary>
        /// MINUTE
        /// </summary>
        Minute,

        /// <summary>
        /// SECOND
        /// </summary>
        Second,

        /// <summary>
        /// YEAR TO MONTH
        /// </summary>
        [FieldSqlName("YEAR TO MONTH")]
        YearToMonth,

        /// <summary>
        /// DAY TO HOUR
        /// </summary>
        [FieldSqlName("DAY TO HOUR")]
        DayToHour,

        /// <summary>
        /// DAY TO MINUTE
        /// </summary>
        [FieldSqlName("DAY TO MINUTE")]
        DayToMinute,

        /// <summary>
        /// DAY TO SECOND
        /// </summary>
        [FieldSqlName("DAY TO SECOND")]
        DayToSecond,

        /// <summary>
        /// HOUR TO MINUTE
        /// </summary>
        [FieldSqlName("HOUR TO MINUTE")]
        HOURToMinute,

        /// <summary>
        /// HOUR TO SECOND
        /// </summary>
        [FieldSqlName("HOUR TO SECOND")]
        HOURToSecond,

        /// <summary>
        /// MINUTE TO SECOND
        /// </summary>
        [FieldSqlName("MINUTE TO SECOND")]
        MinuteToSecond,
    }

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
