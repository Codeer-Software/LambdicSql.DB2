using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.DB2.Inside.CodeParts;
using System.Collections.Generic;
using System.Linq.Expressions;
using static LambdicSql.DB2.Inside.PartsUtils;

namespace LambdicSql.DB2.ConverterAttributes
{
    /// <summary>
    /// Converter for WITH clause conversion.
    /// </summary>
    public class WithConverterAttribute : MethodConverterAttribute
    {
        /// <summary>
        /// Does a Recursive clause exist?
        /// </summary>
        public bool ExistRecursiveClause { get; set; }

        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var arry = expression.Arguments[0] as NewArrayExpression;
            return ConvertNormalWith(converter, arry);
        }

        static ICode ConvertNormalWith(ExpressionConverter converter, NewArrayExpression arry)
        {
            var with = new VCode() { Indent = 1, Separator = "," };
            var names = new List<string>();
            foreach (var e in arry.Expressions)
            {
                var table = converter.ConvertToCode(e);
                var body = FromConverterAttribute.GetSubQuery(e);
                names.Add(body);
                with.Add(Clause(LineSpace(body.ToCode(), "AS".ToCode()), table));
            }
            return new WithEntriedCode(new VCode("WITH".ToCode(), with), names.ToArray());
        }
    }
}
