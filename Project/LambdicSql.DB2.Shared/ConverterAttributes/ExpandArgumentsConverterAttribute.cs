﻿using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.DB2.Inside.CodeParts;
using LambdicSql.DB2.MultiplatformCompatibe;
using System.Linq;
using System.Linq.Expressions;
using static LambdicSql.DB2.Inside.PartsUtils;

namespace LambdicSql.DB2.ConverterAttributes
{
    /// <summary>
    /// Converter for xx(a, b, c)
    /// </summary>
    public class ExpandArgumentsConverterAttribute : MethodConverterAttribute
    {
        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var name = FromConverterAttribute.GetSubQuery(expression.Arguments[0]);
            var coreType = expression.Arguments[0].Type.GetGenericArgumentsEx()[0];
            var info = ObjectCreateAnalyzer.MakeObjectCreateInfo(coreType);
            //TODO
            return new WithEntriedCode(Line(name.ToCode(), Blanket(info.Members.Select(e => e.Name.ToCode()).ToArray())), new[] { name });
        }
    }
}
